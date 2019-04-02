using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Settlement_of_kilometers
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
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
    }
}
