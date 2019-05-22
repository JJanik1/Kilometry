using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Rozliczenie_Kilometrów.Class.Database;

namespace Settlement_of_kilometers.Class.Calculations
{

    //klasa wyliczająca przemierzoną drogę

    class Traveled_Way
    {
        // internal double RoadTraveled
        //  {
        //  get
        // {
        // string[] linesStart = File.ReadAllLines(StartKilometersFile);
        //string[] linesEnd = File.ReadAllLines(EndKilometersFile);

        //   double result = Convert.ToDouble(linesEnd[linesEnd.Length - 1]) -
        // Convert.ToDouble(linesStart[linesStart.Length - 1]);

        //  return result;
        //  }
        //  }

        internal double TraveledWay(double startRoad, double endRoad)
        {

            return endRoad - startRoad;
        }



    }
}
