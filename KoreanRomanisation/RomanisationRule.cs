using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class RomanisationRule
    {
        public  string Jamo { get; set; }
        public string Romanisation { get; set; }

        public RomanisationRule( string Jamo1, string Romanisation1)
        {
            Jamo = Jamo1;
            Romanisation = Romanisation1;
        }
        
    }
}
