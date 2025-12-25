using System;
using System.Net.Http;
using System.Threading.Tasks;

class ApiTest
{
    static async Task Main()
    {
        await TestVietstockAPI();
    }

    static async Task TestVietstockAPI()
    {
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");

            // Test multiple endpoints
            string[] endpoints = new[]
            {
                "https://finance.vietstock.vn/data/getstockpricelist",
                "https://finance.vietstock.vn/vi/data/getstdbestpagedata",
                "https://finance.vietstock.vn/data/getstdbestpagedata",
                "https://fapi.tcbs.com.vn/v1/stock/list"
            };

            foreach (var endpoint in endpoints)
            {
                try
                {
                    Console.WriteLine($"\nTesting: {endpoint}");
                    
                    var content = new FormUrlEncodedContent(new[]
                    {
                        new System.Collections.Generic.KeyValuePair<string, string>("size", "15"),
                        new System.Collections.Generic.KeyValuePair<string, string>("date", "25/12/2025")
                    });

                    var response = await client.PostAsync(endpoint, content);
                    Console.WriteLine($"Status: {response.StatusCode}");
                    
                    var responseText = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Response (first 300 chars): {responseText.Substring(0, Math.Min(300, responseText.Length))}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
