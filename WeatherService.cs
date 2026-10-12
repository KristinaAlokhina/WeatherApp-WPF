using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WeatherApp
{
    /// <summary>
    /// Service für die Kommunikation mit der OpenWeatherMap-API.
    /// </summary>
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public WeatherService(string apiKey)
        {
            _httpClient = new HttpClient();
            _apiKey = apiKey;
        }

        /// <summary>
        /// Ruft die aktuellen Wetterdaten für eine bestimmte Stadt ab.
        /// </summary>
        public async Task<WeatherData?> GetWeatherAsync(string city)
        {
            // units=metric stellt Celsius ein, lang=de liefert deutsche Beschreibungen
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric&lang=de";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    // Stadt wurde nicht gefunden
                    return null;
                }

                response.EnsureSuccessStatusCode();

                // Konvertiert JSON automatisch in das WeatherData-Objekt
                return await response.Content.ReadFromJsonAsync<WeatherData>();
            }
            catch (Exception)
            {
                // Netzwerkfehler oder andere Ausnahmen
                return null;
            }
        }
    }
}
