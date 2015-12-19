using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class PronunciationChangeRomanisationRule
    {
        public Jamo Final { get; set; }
        public Jamo Initial { get; set; }
        public string FinalRomanisation { get; set; }
        public string InitialRomanisation { get; set; }

        public PronunciationChangeRomanisationRule(Jamo Final1, Jamo Initial1, string FinalRomanisation1, string InitialRomanisation1)
        {
            Final = Final1;
            Initial = Initial1;
            FinalRomanisation = FinalRomanisation1;
            InitialRomanisation = InitialRomanisation1;
        }
    }
}
