using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Settlement_of_kilometers;

namespace Rozliczenie_Kilometrów.Class.Database
{
    /// <summary>
    /// Logika interakcji dla klasy Statistics.xaml
    /// </summary>
    public partial class Statistics : Window
    {
        public Statistics()
        {
            InitializeComponent();
            SetSumOfKilometers();
            SetSumOfTravelers();
            LoadPieChartData();
            LoadScatterChartData();
        }

        private void SetSumOfTravelers()
        {
            // zlicza liczbę przejazdów
            PrzejazdyEntities4 context = new PrzejazdyEntities4();
            SumOfTravelers.Content = context.Rozliczenie.Count().ToString();
        }

        private void SetSumOfKilometers()
        {
            // zlicza liczbę przejechanych kilometrów
            PrzejazdyEntities4 context = new PrzejazdyEntities4();
            SumOfKilometers.Content = context.Rozliczenie.Sum(x => x.Traveled_Way).ToString() + " km";
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Statistics statitics = new Statistics();

            mainWindow.Show();
            this.Close();
        }

        private void LoadPieChartData()
        {
            PrzejazdyEntities4 context = new PrzejazdyEntities4();

            // Sortuje malejąco datę i bierze 5 najnowszych przejazdów
            var przejazdy = context.Rozliczenie.ToList().OrderByDescending(x => x.Data_).Take(5).ToList();

            var chartDate = new List<KeyValuePair<string, int>>();

            foreach (var przejazd in przejazdy)
            {
                // dodaje przejazd z datą i liczbą kilometrów do Listy
                chartDate.Add(new KeyValuePair<string, int>(przejazd.Data_.Value.ToString("dd/MM/yyyy"), Convert.ToInt32(przejazd.Traveled_Way)));
            }
            // Dodaje dane do wykresu
            ((System.Windows.Controls.DataVisualization.Charting.PieSeries) mcChart.Series[0]).ItemsSource = chartDate;
        }

        private void LoadScatterChartData()
        {
            PrzejazdyEntities4 context = new PrzejazdyEntities4();

            // Sortuje malejąco datę i bierze 5 najnowszych przejazdów
            var przejazdy = context.Rozliczenie.ToList().OrderByDescending(x => x.Data_).Take(5).ToList();

            var chartDate = new List<KeyValuePair<string, int>>();

            foreach (var przejazd in przejazdy)
            {
                // dodaje przejazd z datą i zużyciem paliwa do Listy
                chartDate.Add(new KeyValuePair<string, int>(przejazd.Data_.Value.ToString("dd/MM/yyyy"), Convert.ToInt32(przejazd.Fuel_Used)));
            }
            // Dodaje dane do wykresu
            ((ColumnSeries)mcChart2.Series[0]).ItemsSource = chartDate;
        }
    }
}
