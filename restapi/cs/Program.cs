using System;
using System.Net.Http;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            const string URL = "https://api.quum.us/api/v1/rates/APIKEY/EUR/USD";

            using (var client = new HttpClient())
            {
                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(client.GetStringAsync(URL).Result);
                Console.WriteLine($"timestamp: {data.utc}");
                Console.WriteLine($"symbol: {data.symbol}");
                Console.WriteLine($"rate: {data.rate}");

            }
        }
    }
}
