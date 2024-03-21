namespace httphelper;

using System.Net;


public class ClientHelper
{
    public async Task<String> GetRandomProxy()
    {
        var lines = await File.ReadAllLinesAsync("data/proxies.txt");
        
        return lines[
            new Random().Next(lines.Length)
        ];
    }
    
    public async Task<HttpClient> CreateHttpClient(string proxy)
    {
        var parts = proxy.Split('@');
    
        var credentialsAndHost = parts[0].Split(':');
        var hostAndPort = parts[1].Split(':');
    
        var username = credentialsAndHost[0];
        var password = credentialsAndHost[1];
    
        var host = hostAndPort[0];
        var port = int.Parse(hostAndPort[1]);

        var proxyUrl = $"http://{host}:{port}";

        var handler = new HttpClientHandler();
        handler.Proxy = new WebProxy(proxyUrl, false)
        {
            Credentials = new NetworkCredential(username, password)
        };

        var httpClient = new HttpClient(handler);
        httpClient.Timeout = TimeSpan.FromSeconds(30);

        return httpClient;
    }

}