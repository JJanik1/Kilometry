﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        PrzejazdyEntities przejazdyEntities = new PrzejazdyEntities();
        internal async Task<double> FuelStandart(double capacity)
        {
        var result = Task.Run(() =>
        {
        var r = capacity * 0.4 + 23;
         });

        return Task;
        }
    }
}
