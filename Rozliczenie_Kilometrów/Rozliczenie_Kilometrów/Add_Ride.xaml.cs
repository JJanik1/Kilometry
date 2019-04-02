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
using System.Windows.Shapes;

namespace Settlement_of_kilometers
{
    /// <summary>
    /// Logika interakcji dla klasy Add_Ride.xaml
    /// </summary>
    public partial class Add_Ride : Window
    {
        public Add_Ride()
        {
            InitializeComponent();
        }

        private void Initial_value_of_kilometers_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void The_final_value_of_kilometers_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Capacity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Add_Ride addRide = new Add_Ride();

            mainWindow.Show();
            this.Close();
        }
    }
}
