using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rozliczenie_Kilometrów.Class.Database;

namespace Settlement_of_kilometers.Class.Calculations
{

    //klasa wyliczająca zużycie paliwa
    class Fuel_Used
    {
        //internal double AmountOfFuelConsumed
        // {
        // get
        // {
        //    double result = Traveled_Way / 100 * Fuel_Standard;
        //    return result;
        // }
        // }

        internal async Task<double> FuelStandart(double capacity)
        {
            PrzejazdyEntities przejazdyEntities=new PrzejazdyEntities();
            var result = Task.Run(() =>
            {
                
                var r = przejazdyEntities. / 100 * Fuel_Standard;
            });

            return Task;
        }



    }
}
