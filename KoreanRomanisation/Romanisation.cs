using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public abstract class Romanisation : IRomanisation
    {

        public bool PreserveNonKoreanCharacters { get; set; }
        public bool UseSh { get; set; }

        public Romanisation()
        {
            PreserveNonKoreanCharacters = true;
            UseSh = true;
        }
                        
        public TextBlock GetDocument(string Text)
        {
            var Document1 = new TextBlock();
            var KoreanText1 = new KoreanTextSection();
            var NonKoreanText1 = new NonKoreanText();

            foreach (var Character in Text)
            {
                if (Syllable.IsSyllable(Character))
                {
                    var Syllable = new Syllable(Character);

                    if (NonKoreanText1.Content != "")
                    {
                        Document1.TextSections.Add(NonKoreanText1);
                        NonKoreanText1 = new NonKoreanText();
                    }

                    KoreanText1.Syllables.Add(Syllable);
                }
                else
                {
                    if (KoreanText1.Syllables.Any())
                    {
                        Document1.TextSections.Add(KoreanText1);
                        KoreanText1 = new KoreanTextSection();
                    }

                    NonKoreanText1.Content += Character;
                }
            }

            if (NonKoreanText1.Content != "")
            {
                Document1.TextSections.Add(NonKoreanText1);
                NonKoreanText1 = new NonKoreanText();
            }

            if (KoreanText1.Syllables.Any())
            {
                Document1.TextSections.Add(KoreanText1);
                KoreanText1 = new KoreanTextSection();
            }

            return Document1;
        }

        public string Romanise(string Document)
        {
            var StringBuilder1 = new StringBuilder();

            var Document1 = GetDocument(Document);

            foreach (var Text in Document1.TextSections)
            {
                if (Text is KoreanTextSection)
                {
                    var KoreanText1 = Text as KoreanTextSection;

                    if (KoreanText1.Syllables.Count() > 1)
                    {
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
                    else if (KoreanText1.Syllables.Count() == 1)
                    {
                        StringBuilder1.Append(Romanise(KoreanText1.Syllables[0]));
                    }

                }
                else if (Text is NonKoreanText)
                {
                    StringBuilder1.Append((Text as NonKoreanText).Content);
                }
            }

            return StringBuilder1.ToString();
        }

        public abstract string Romanise(Syllable Syllable1, Syllable? PrecedingSyllable = null, Syllable? SucceedingSyllable = null);

        public abstract string Romanise(Jamo Jamo1);  
    }
}
