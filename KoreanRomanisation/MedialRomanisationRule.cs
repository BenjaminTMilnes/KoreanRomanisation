using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class MedialRomanisationRule
    {
        public KoreanLetter Jamo { get; set; }
        public string Romanisation { get; set; }

        public MedialRomanisationRule(KoreanLetter Jamo1, string Romanisation1)
        {
            Jamo = Jamo1;
            Romanisation = Romanisation1;
        }
    }
}
