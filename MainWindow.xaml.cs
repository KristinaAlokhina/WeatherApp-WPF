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

               
                CityNameText.Text = data.CityName;
                
                
                TemperatureText.Text = $"{Math.Round(data.Main.Temperature)}°C";
                
                
                DescriptionText.Text = char.ToUpper(description[0]) + description.Substring(1);
                
                HumidityText.Text = $"{data.Main.Humidity}%";
                WindText.Text = $"{data.Wind.Speed} m/s";
            }
            else
            {
                MessageBox.Show("Stadt wurde nicht gefunden oder Netzwerkfehler.");
            }
        }
    }
}
