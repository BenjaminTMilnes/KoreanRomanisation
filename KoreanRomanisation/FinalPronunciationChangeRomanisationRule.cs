using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class FinalPronunciationChangeRomanisationRule
    {
        public Jamo Final { get; set; }
        public Jamo SucceedingInitial { get; set; }
        public string Romanisation { get; set; }

        public FinalPronunciationChangeRomanisationRule(Jamo Final1, Jamo SucceedingInitial1, string Romanisation1)
        {
            Final = Final1;
            SucceedingInitial = SucceedingInitial1;
            Romanisation = Romanisation1;
        }
    }
}
