using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class PronunciationChangeRomanisationRule
    {
        public KoreanLetter Final { get; set; }
        public KoreanLetter Initial { get; set; }
        public string FinalRomanisation { get; set; }
        public string InitialRomanisation { get; set; }

        public PronunciationChangeRomanisationRule(KoreanLetter Final1, KoreanLetter Initial1, string FinalRomanisation1, string InitialRomanisation1)
        {
            Final = Final1;
            Initial = Initial1;
            FinalRomanisation = FinalRomanisation1;
            InitialRomanisation = InitialRomanisation1;
        }
    }
}
