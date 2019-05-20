using Rozliczenie_Kilometrów;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Settlement_of_kilometers
{
    /// <summary>
    /// Logika interakcji dla klasy RideList.xaml
    /// </summary>
    /// 

    public class Row
    {
        public string Id { get; set; }
        public string Traveled_Way { get; set; }
        public string FuelStandard { get; set; }
        public string FuelUsed { get; set; }
        public string Date { get; set; }
    }

    public partial class RideList : Window
    {
        public RideList()
        {
            InitializeComponent();

            PrzejazdyEntities4 context = new PrzejazdyEntities4();
            var przejazdy = context.Rozliczenie.ToList();

            foreach (var przejazd in przejazdy)
            {
                ListOfTraveled.Items.Add(new Row { Id = przejazd.Key.ToString(), Traveled_Way = przejazd.Traveled_Way.ToString() + " km", FuelStandard = przejazd.Fuel_Standard.ToString() + " l", FuelUsed = przejazd.Fuel_Used.ToString() + " l", Date = przejazd.Data_.Value.ToString("dd/MM/yyyy") });
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            RideList rideList = new RideList();

            mainWindow.Show();
            this.Close();
        }

        private void Remove_Ride_Click(object sender, RoutedEventArgs e)
        {
            if (ListOfTraveled.SelectedItem == null) return;

            var row = ListOfTraveled.SelectedItem as Row;

            PrzejazdyEntities4 context = new PrzejazdyEntities4();

            var toRemove = new Rozliczenie()
            {
                Key = int.Parse(row.Id)
            };
            context.Rozliczenie.Attach(toRemove);
            context.Rozliczenie.Remove(toRemove);
            context.SaveChanges();

            ListOfTraveled.Items.RemoveAt(ListOfTraveled.SelectedIndex);
        }
    }
}
