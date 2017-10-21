using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class InitialPronunciationChangeRomanisationRule
    {
        public KoreanLetter PrecedingFinal { get; set; }
        public KoreanLetter Initial { get; set; }
        public string Romanisation { get; set; }

        public InitialPronunciationChangeRomanisationRule(KoreanLetter PrecedingFinal1, KoreanLetter Initial1, string Romanisation1)
        {
            PrecedingFinal = PrecedingFinal1;
            Initial = Initial1;
            Romanisation = Romanisation1;
        }
    }
}
