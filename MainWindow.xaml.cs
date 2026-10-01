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

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Hier wird im nächsten Schritt die API aufgerufen
            MessageBox.Show($"Suche nach Stadt: {CityInput.Text}");
        }
    }
}
