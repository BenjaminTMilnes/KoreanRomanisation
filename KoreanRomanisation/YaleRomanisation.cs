using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class YaleRomanisation : Romanisation
    {
        public override string Romanise(Syllable Syllable1, Syllable? PrecedingSyllable = null, Syllable? SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            var Initials = new string[] { "k", "kk", "n", "t", "tt", "l", "m", "p", "pp", "s", "ss", "", "c", "cc", "ch", "kh", "th", "ph", "h" };

            StringBuilder1.Append(Initials[Syllable1.Initial]);

            var Medials = new string[] { "a", "ay", "ya", "yay", "e", "ey", "ye", "yey", "o", "wa", "way", "oy", "yo", "u", "we", "wey", "wi", "yu", "u", "uy", "i" };

            StringBuilder1.Append(Medials[Syllable1.Medial]);

            var Finals = new string[] { "", "k", "kk", "ks", "n", "nc", "nh", "t", "l", "lk", "lm", "lp", "ls", "lth", "lph", "lh", "m", "p", "ps", "s", "ss", "ng", "c", "ch", "kh", "th", "ph", "h" };

            StringBuilder1.Append(Finals[Syllable1.Final]);

            return StringBuilder1.ToString();
        }

        public override string Romanise(Jamo Jamo1)
        {
            throw new NotImplementedException();
        }
    }
}
