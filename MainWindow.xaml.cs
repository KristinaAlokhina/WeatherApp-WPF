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
               
                MessageBox.Show($"Wetterdaten für {cityName} erfolgreich geladen!");
            }
            else
            {
             
                MessageBox.Show("Stadt wurde nicht gefunden oder Netzwerkfehler.");
            }
        }
    }
}
