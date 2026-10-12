using System;
using System.Windows;

namespace WeatherApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string cityName = CityInput.Text;

            if (string.IsNullOrWhiteSpace(cityName))
            {
                MessageBox.Show("Bitte geben Sie eine Stadt ein.");
                return;
            }

            string myApiKey = "d648333353308a37e471e57fb13a5008"; 

            WeatherService weatherService = new WeatherService(myApiKey);
            WeatherData data = await weatherService.GetWeatherAsync(cityName);

           
            if (data != null)
            {
                
                string description = data.Weather.Count > 0 ? data.Weather[0].Description : "Keine Beschreibung";

                
                string infoMessage = $"Wetter in {data.CityName}:\n\n" +
                                     $"🌡 Temperatur: {data.Main.Temperature}°C\n" +
                                     $"🥶 Gefühlt wie: {data.Main.FeelsLike}°C\n" +
                                     $"💧 Luftfeuchtigkeit: {data.Main.Humidity}%\n" +
                                     $"💨 Wind: {data.Wind.Speed} m/s\n" +
                                     $"☁️ Zustand: {description}";

                
                MessageBox.Show(infoMessage, "Wetterinformationen");
            }
            else
            {
                MessageBox.Show("Stadt wurde nicht gefunden oder Netzwerkfehler.");
            }
        }
    }
}
