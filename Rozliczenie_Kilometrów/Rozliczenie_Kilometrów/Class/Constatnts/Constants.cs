using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settlement_of_kilometers.Class.Constatnts
{

    //klasa stała wyświetlająca błąd z regaxa, jeśli wpisujemy inne znaki niż cyfry
    class Constants
    {
        public const string PatternRegexVeryficationEnteredData = @"^\d{1,8}$";
    }
}
