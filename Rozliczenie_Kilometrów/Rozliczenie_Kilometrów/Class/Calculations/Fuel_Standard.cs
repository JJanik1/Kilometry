using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rozliczenie_Kilometrów;
using Rozliczenie_Kilometrów.Class.Database;

namespace Settlement_of_kilometers.Class.Calculations
{
    //klasa wyliczająca normę paliwa

    class Fuel_Standard
    {
        //internal double FuelStandart
        // {
        //   get
        //  {
        //string[] capacity = File.ReadAllLines(CapacityFile);
        //       double result = Convert.ToDouble(Capacity[Capacity.Length - 1]) * 0.4 + 23;

        //      return result;
        //    }
        //  }

    
       PrzejazdyEntities4 _przejazdyEntities = new PrzejazdyEntities4();
        
       // Wszystko co zwracam z metody asynchronicznej jest typu task 
       internal async Task<Task> FuelStandart(double capacity)
       {
        var result = Task<double>.Run(() =>
        {
        var r = capacity * 0.4 + 23;
        });

        
        return result;
        }
        
    }
}
