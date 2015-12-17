using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class InitialRomanisationRule
    {
        public Jamo Initial { get; set; }
        public string Romanisation { get; set; }

        public InitialRomanisationRule(Jamo Initial1, string Romanisation1)
        {
            Initial = Initial1;
            Romanisation = Romanisation1;
        }
    }
}
