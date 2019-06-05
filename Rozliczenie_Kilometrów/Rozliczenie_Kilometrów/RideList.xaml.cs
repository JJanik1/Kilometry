using System.Linq;
using System.Windows;
using Rozliczenie_Kilometrów.Class.Database;
using Rozliczenie_Kilometrów.Class.RideList;

namespace Settlement_of_kilometers
{
    public partial class RideList : Window  
    {

        //pobranie z bazy listy dodanych przejazdów ora wyświetlenie ich
        public RideList()
        {
            InitializeComponent();

            PrzejazdyEntities4 context = new PrzejazdyEntities4();
            var przejazdy = context.Rozliczenie.ToList();

            foreach (var przejazd in przejazdy)
            {
                ListOfTraveled.Items.Add(new Rozliczenie_Kilometrów.Class.RideList.RideList { Id = przejazd.Key.ToString(), Traveled_Way = przejazd.Traveled_Way.ToString() + " km", FuelStandard = przejazd.Fuel_Standard.ToString() + " l", FuelUsed = przejazd.Fuel_Used.ToString() + " l", Date = przejazd.Data_.Value.ToString("dd/MM/yyyy") });
            }

        }

        //przycisk powrotu
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            RideList rideList = new RideList();

            mainWindow.Show();
            this.Close();
        }

        //usunięcie dodanego przejazdu
        private void Remove_Ride_Click(object sender, RoutedEventArgs e)
        {
            if (ListOfTraveled.SelectedItem == null) return;

            var row = ListOfTraveled.SelectedItem as Rozliczenie_Kilometrów.Class.RideList.RideList;

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
