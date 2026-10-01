using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeatherApp
{
    /// <summary>
    /// Repräsentiert die vom OpenWeather-API empfangenen Wetterdaten.
    /// </summary>
    public class WeatherData
    {
        [JsonPropertyName("name")]
        public string CityName { get; set; } = string.Empty;

        [JsonPropertyName("main")]
        public MainInfo Main { get; set; } = new();

        [JsonPropertyName("weather")]
        public List<WeatherDescription> Weather { get; set; } = new();

        [JsonPropertyName("wind")]
        public WindInfo Wind { get; set; } = new();
    }

    public class MainInfo
    {
        [JsonPropertyName("temp")]
        public double Temperature { get; set; }

        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }

    public class WeatherDescription
    {
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }

    public class WindInfo
    {
        [JsonPropertyName("speed")]
        public double Speed { get; set; }
    }
}
