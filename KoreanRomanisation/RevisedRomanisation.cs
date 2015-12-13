using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml;

namespace KoreanRomanisation
{
    public class RevisedRomanisation : Romanisation
    {
        public override string Romanise(Syllable Syllable1, Syllable? PrecedingSyllable = null, Syllable? SucceedingSyllable = null)
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
                    var Initials = new string[] { "g", "kk", "n", "d", "tt", "r", "m", "b", "pp", "s", "ss", "", "j", "jj", "ch", "k", "t", "p", "h" };

                    StringBuilder1.Append(Initials[Syllable1.Initial]);
                }

            }

            var Medials = new string[] { "a", "ae", "ya", "yae", "eo", "e", "yeo", "ye", "o", "wa", "wae", "oe", "yo", "u", "wo", "we", "wi", "yu", "eu", "ui", "i" };

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

        public override string Romanise(Jamo Jamo1)
        {
            throw new NotImplementedException();
        }
    }
}
