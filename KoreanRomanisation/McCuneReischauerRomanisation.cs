using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class McCuneReischauerRomanisation : Romanisation
    {
        public override string Romanise(Syllable Syllable1, Syllable PrecedingSyllable = null, Syllable SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            if (PrecedingSyllable != null)
            {

            }
            else
            {
                if (UseSh && Syllable1.Initial == 9 && (Syllable1.Medial == 20 || Syllable1.Medial == 2 || Syllable1.Medial == 3 || Syllable1.Medial == 6 || Syllable1.Medial == 7 || Syllable1.Medial == 12 || Syllable1.Medial == 17))
                {
                    StringBuilder1.Append("sh");
                }
                else if (UseSh && Syllable1.Initial == 10 && (Syllable1.Medial == 20 || Syllable1.Medial == 2 || Syllable1.Medial == 3 || Syllable1.Medial == 6 || Syllable1.Medial == 7 || Syllable1.Medial == 12 || Syllable1.Medial == 17))
                {
                    StringBuilder1.Append("ssh");
                }
                else
                {
                    var Initials = new string[] { "k", "kk", "n", "t", "tt", "r", "m", "p", "pp", "s", "ss", "", "ch", "tch", "ch'", "k'", "t'", "p'", "h" };

                    StringBuilder1.Append(Initials[Syllable1.Initial]);
                }

            }

            if (PrecedingSyllable != null && (PrecedingSyllable.Medial == 0 || PrecedingSyllable.Medial == 4) && PrecedingSyllable.Final == 0 && Syllable1.Initial == 11 && Syllable1.Medial == 5)
            {
                StringBuilder1.Append("ë");
            }
            else
            {
                var Medials = new string[] { "a", "ae", "ya", "yae", "ŏ", "e", "yŏ", "ye", "o", "wa", "wae", "oe", "yo", "u", "wŏ", "we", "wi", "yu", "ŭ", "ŭi", "i" };

                StringBuilder1.Append(Medials[Syllable1.Medial]);
            }

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
