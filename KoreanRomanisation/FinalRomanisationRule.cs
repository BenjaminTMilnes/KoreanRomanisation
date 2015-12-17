using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
  public  class FinalRomanisationRule
    {
        public Jamo Final { get; set; }
        public string Romanisation { get; set; }

        public FinalRomanisationRule(Jamo Final1, string Romanisation1)
        {
            Final = Final1;
            Romanisation = Romanisation1;
        }
    }
}
