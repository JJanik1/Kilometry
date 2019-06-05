using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozliczenie_Kilometrów.Class.AddRide
{
    public class Ride
    {
        double stardRoad;
        double endRoad;
        double capacity;
        DateTime date;

        // właściwości
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
}
