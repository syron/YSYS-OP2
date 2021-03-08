using KalleKulaDemo02.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace KalleKulaDemo02.Services
{
    public class WeatherService
    {
        public double Temp(string city)
        {
            var apiKey = "4dc272b0fe47f930cc4cb05603914351";
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";
            
            using (var client = new HttpClient())
            {
                var t = client.GetAsync(url);
                var response = t.GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    var readResponse = response.Content.ReadAsStringAsync();
                    var readResponseResult = readResponse.GetAwaiter().GetResult();

                    var weatherResult = JsonSerializer.Deserialize<Root>(readResponseResult);
                    return weatherResult.main.tempCelsius;
                }
            }

            throw new Exception($"{city} not found.");
        }

        public async Task<double> TempAsync(string city)
        {
            var apiKey = "4dc272b0fe47f930cc4cb05603914351";
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var readResponseResult = await response.Content.ReadAsStringAsync();

                    var weatherResult = JsonSerializer.Deserialize<Root>(readResponseResult);
                    return weatherResult.main.tempCelsius;
                }
            }

            throw new Exception($"{city} not found.");
        }
    }
}
