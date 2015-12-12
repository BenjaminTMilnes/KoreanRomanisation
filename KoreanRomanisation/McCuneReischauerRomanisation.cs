using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class McCuneReischauerRomanisation : Romanisation, IRomanisation
    {

        public string Romanise(string Document)
        {
            var StringBuilder1 = new StringBuilder();

            var Document1 = GetDocument(Document);

            foreach (var Text in Document1.Text)
            {
                if (Text is KoreanText)
                {
                    var KoreanText1 = Text as KoreanText;

                    for (var i = 0; i < KoreanText1.Syllables.Count(); i++)
                    {
                        if (i == 0)
                        {
                            StringBuilder1.Append(Romanise(KoreanText1.Syllables[i], null, KoreanText1.Syllables[i + 1]));
                        }
                        else if (i == KoreanText1.Syllables.Count() - 1)
                        {
                            StringBuilder1.Append(Romanise(KoreanText1.Syllables[i], KoreanText1.Syllables[i - 1], null));
                        }
                        else
                        {
                            StringBuilder1.Append(Romanise(KoreanText1.Syllables[i], KoreanText1.Syllables[i - 1], KoreanText1.Syllables[i + 1]));
                        }
                    }
                }
                else if (Text is NonKoreanText)
                {
                    StringBuilder1.Append((Text as NonKoreanText).Content);
                }
            }

            return StringBuilder1.ToString();
        }

        public string Romanise(Syllable Syllable1, Syllable PrecedingSyllable = null, Syllable SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            if (PrecedingSyllable != null)
            {

            }
            else
            {

            }

            switch (Syllable1.Medial)
            {
                case 1:
                    StringBuilder1.Append("a");
                    break;
                case 2:
                    StringBuilder1.Append("ae");
                    break;
                case 3:
                    StringBuilder1.Append("ya");
                    break;
                case 4:
                    StringBuilder1.Append("yae");
                    break;
                case 5:
                    StringBuilder1.Append("ŏ");
                    break;
                case 6:
                    StringBuilder1.Append("e");
                    break;
                case 7:
                    StringBuilder1.Append("yŏ");
                    break;
                case 8:
                    StringBuilder1.Append("ye");
                    break;
                case 9:
                    StringBuilder1.Append("o");
                    break;
                case 10:
                    StringBuilder1.Append("wa");
                    break;
                case 11:
                    StringBuilder1.Append("wae");
                    break;
                case 12:
                    StringBuilder1.Append("oe");
                    break;
                case 13:
                    StringBuilder1.Append("yo");
                    break;
                case 14:
                    StringBuilder1.Append("u");
                    break;
                case 15:
                    StringBuilder1.Append("wŏ");
                    break;
                case 16:
                    StringBuilder1.Append("we");
                    break;
                case 17:
                    StringBuilder1.Append("wi");
                    break;
                case 18:
                    StringBuilder1.Append("yu");
                    break;
                case 19:
                    StringBuilder1.Append("ŭ");
                    break;
                case 20:
                    StringBuilder1.Append("ŭi");
                    break;
                case 21:
                    StringBuilder1.Append("i");
                    break;
                default:
                    break;
            }

            if (SucceedingSyllable != null)
            {

            }
            else
            {

            }

            return StringBuilder1.ToString();
        }
    }
}
