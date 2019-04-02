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
        internal bool VeryficationInitial_value_of_kilometers()
        { 
            Regex regex = new Regex(Constants.PatternRegexVeryficationInitial_value_of_kilometers);  // wyrażenie regularne 


            return true;
        }

        internal bool VeryficationThe_final_value_of_kilometers()
        {
            Regex regex = new Regex(Constants.PatternRegexVeryficationThe_final_value_of_kilometers);  // wyrażenie regularne 


            return true;
        }

        internal bool VeryficationCapacity()
        {
            Regex regex = new Regex(Constants.PatternRegexVeryficationCapacity);  // wyrażenie regularne 


            return true;
        }
    }
}
