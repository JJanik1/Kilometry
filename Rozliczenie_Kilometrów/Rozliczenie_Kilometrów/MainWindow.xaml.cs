using System.Windows;
using Rozliczenie_Kilometrów.Class.Database;

namespace Settlement_of_kilometers
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddRide_Click(object sender, RoutedEventArgs e)
        {
            Add_Ride add_Ride = new Add_Ride();
            add_Ride.Show();
            this.Close();
        }

        private void RideList_Click(object sender, RoutedEventArgs e)
        {
            RideList rideList = new RideList();
            rideList.Show();
            this.Close();
        }

        private void Statistics_Click(object sender, RoutedEventArgs e)
        {
            Statistics statistics  = new Statistics();
            statistics.Show();
            this.Close();
        }
    }
}
