using Rozliczenie_Kilometrów;
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
    /// 

    public class Ride
    {
        double stardRoad;
        double endRoad;
        double capacity;
        DateTime date;

        // Stworzyłem właściwości, więc możesz jakoś pozmieniać modyfikatory
        // Można na przykład stworzyć właściwość, która zamienia km na mile i zapisuje do pola
        public double StardRoad { get => stardRoad; set => stardRoad = value; }
        public double EndRoad { get => endRoad; set => endRoad = value; }
        public double Capacity { get => capacity; set => capacity = value; }
        public DateTime Date { get => date; set => date = value; }

        public Ride()
        {
            // Inicjuje pola na 0
            stardRoad = 0;
            endRoad = 0;
            capacity = 0;
            date = DateTime.Now;
        }

        // Funkcje
        public double traveledWay()
        {
            return endRoad - stardRoad;
        }

        public double fuelUsed()
        {
            return traveledWay() / 100 * fuelStandard();
        }

        public double fuelStandard()
        {
            return capacity * 0.4 + 23;
        }

        public bool DataCompleted()
        {
            if (capacity == 0) return false;
            if (traveledWay() <= 0) return false;
            return true;
        }
    }

    public partial class Add_Ride : Window
    {
        // Tworzę obiekt przejazd 
        Ride NewRide = new Ride();

        public Add_Ride()
        {
            InitializeComponent();
        }

        private void Initial_value_of_kilometers_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Jeśli komórka z ilością kilometrów jest pusta to do New_ride zapisuje 0
            if (Initial_value_of_kilometers.Text == "") NewRide.StardRoad = 0;
            else
            {
                // Jeśli nie jest pusta, to zamieniam text na liczbę i zapisuje w New_ride
                Double.TryParse(Initial_value_of_kilometers.Text, out double kilometers);
                NewRide.StardRoad = kilometers;
            }

            // Do Labela Road zapisuje ile kilometrów przejechał samochów używając funkji traveledWay
            TraveledWay.Content = NewRide.traveledWay().ToString() + " km";
            // Aktualizacj Labela FuelUsed, bo najprawdopodobniej wartość zużytego paliwa się zmieniła
            FuelUsed.Content = NewRide.fuelUsed().ToString() + " l";
        }

        private void The_final_value_of_kilometers_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Jeśli komórka z ilością kilometrów jest pusta to do New_ride zapisuje 0
            if (The_final_value_of_kilometers.Text == "") NewRide.EndRoad = 0;
            else
            {
                // Jeśli nie jest pusta, to zamieniam text na liczbę i zapisuje w New_ride
                Double.TryParse(The_final_value_of_kilometers.Text, out double kilometers);
                NewRide.EndRoad = kilometers;
            }

            // Do Labela Road zapisuje ile kilometrów przejechał samochów używając funkji traveledWay
            TraveledWay.Content = NewRide.traveledWay().ToString() + " km";
            // Aktualizacj Labela FuelUsed, bo najprawdopodobniej wartość zużytego paliwa się zmieniła
            FuelUsed.Content = NewRide.fuelUsed().ToString() + " l";
        }

        private void Capacity_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Stprawdzam czy ładowność nie jest pusta i jeśli jest to w New_Ride zapisuje 0
            if (Capacity.Text == "") NewRide.Capacity = 0;
            else
            {
                // Jeśli nie jest pusta, to zamieniam text na liczbę i zapisuje w New_ride
                Double.TryParse(Capacity.Text, out double capacity);
                NewRide.Capacity = capacity;
            }

            StandardFuel.Content = NewRide.fuelStandard().ToString() + " l";
            // Aktualizacj Labela FuelUsed, bo najprawdopodobniej wartość zużytego paliwa się zmieniła
            FuelUsed.Content = NewRide.fuelUsed().ToString() + " l";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Add_Ride addRide = new Add_Ride();

            mainWindow.Show();
            this.Close();
        }

        private void AddRide_Click(object sender, RoutedEventArgs e)
        {
            if (NewRide.DataCompleted() == false)
            {
                MessageBox.Show("Wypełnij poprawnie formularz");
                return;
            }
            
            PrzejazdyEntities4 context = new PrzejazdyEntities4();

            // Tworze obiekt klasy entity wygenerowanej automatycznie na podstawie tabeli z bazy
            var Rozliczenie = new Rozliczenie()
            {
                // ustawiam zmienne w konstruktorze na te które chce zapisać do bazy
                Drive_List = 0,
                Traveled_Way = Convert.ToDecimal(NewRide.traveledWay()),
                Fuel_Used = Convert.ToDecimal(NewRide.fuelUsed()),
                Fuel_Standard = Convert.ToDecimal(NewRide.fuelStandard()),
                Data_ = NewRide.Date,
            };
            //  Context zapisuje zmiany w tabeli
            context.Rozliczenie.Add(Rozliczenie);
            context.SaveChanges();
            MessageBox.Show("Dodano przejazd");

        }

        private void Calendar_OnSelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            NewRide.Date = Calendar.SelectedDate.Value;
        }
    }
}
