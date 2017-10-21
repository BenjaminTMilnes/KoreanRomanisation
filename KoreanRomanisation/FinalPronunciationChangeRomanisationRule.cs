using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class FinalPronunciationChangeRomanisationRule
    {
        public KoreanLetter Final { get; set; }
        public KoreanLetter SucceedingInitial { get; set; }
        public string Romanisation { get; set; }

        public FinalPronunciationChangeRomanisationRule(KoreanLetter Final1, KoreanLetter SucceedingInitial1, string Romanisation1)
        {
            Final = Final1;
            SucceedingInitial = SucceedingInitial1;
            Romanisation = Romanisation1;
        }
    }
}
