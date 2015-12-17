using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class MedialRomanisationRule
    {
        public Jamo Jamo { get; set; }
        public string Romanisation { get; set; }

        public MedialRomanisationRule(Jamo Jamo1, string Romanisation1)
        {
            Jamo = Jamo1;
            Romanisation = Romanisation1;
        }
    }
}
