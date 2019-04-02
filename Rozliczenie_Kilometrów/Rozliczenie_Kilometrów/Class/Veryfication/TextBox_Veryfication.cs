using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Settlement_of_kilometers.Class.Constatnts;

namespace Settlement_of_kilometers.Class.Veryfication
{
    class TextBox_Veryfication
    {
        internal bool VeryficationTextBoxValue(string _string)
        { 
            Regex regex = new Regex(Constants.PatternRegexVeryficationEnteredData);  // wyrażenie regularne 
            bool result = regex.IsMatch(_string);
            return result;
        }
    }
}
