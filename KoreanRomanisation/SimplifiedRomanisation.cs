using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class SimplifiedRomanisation : Romanisation, IRomanisation
    {
        public override string Romanise(Syllable Syllable1, Syllable PrecedingSyllable = null, Syllable SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            if (PrecedingSyllable != null)
            {

            }
            else
            {
                var Initials = new string[] { "k", "kk", "n", "t", "tt", "r", "m", "p", "pp", "s", "ts", "", "ch", "tch", "ch", "k", "t", "p", "h" };

                StringBuilder1.Append(Initials[Syllable1.Initial]);
            }

            var Medials = new string[] { "a", "e", "ya", "ye", "o", "ei", "yo", "yei", "o", "wa", "we", "we", "yo", "oo", "wo", "wei", "wi", "yoo", "u", "ui", "i" };

            StringBuilder1.Append(Medials[Syllable1.Medial]);

            if (SucceedingSyllable != null)
            {

            }
            else
            {
                var Finals = new string[] { "", "k", "k", "", "n", "", "", "t", "l", "", "", "", "", "", "", "", "m", "p", "", "t", "t", "ng", "t", "t", "k", "t", "p", "t" };

                StringBuilder1.Append(Finals[Syllable1.Final]);
            }

            return StringBuilder1.ToString();
        }
    }
}
