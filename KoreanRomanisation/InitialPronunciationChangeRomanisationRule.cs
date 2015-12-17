using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class InitialPronunciationChangeRomanisationRule
    {
        public Jamo PrecedingFinal { get; set; }
        public Jamo Initial { get; set; }
        public string Romanisation { get; set; }

        public InitialPronunciationChangeRomanisationRule(Jamo PrecedingFinal1, Jamo Initial1, string Romanisation1)
        {
            PrecedingFinal = PrecedingFinal1;
            Initial = Initial1;
            Romanisation = Romanisation1;
        }
    }
}
