using System.Linq;
using System.Text;

namespace KoreanRomanisation
{
    /// <summary>
    /// A base class for classes that can romanise Korean text according to their own internal romanisation rules.
    /// </summary>
    public abstract class Romanisation : IRomanisation
    {
        #region Properties

        public bool PreserveNonKoreanText { get; protected set; }
        public bool UseSh { get; protected set; }
        public bool UseOi { get; protected set; }

        #endregion

        #region Constructors

        public Romanisation()
        {
            PreserveNonKoreanText = true;
            UseSh = true;
            UseOi = false;
        }

        #endregion

        /// <summary>
        /// Takes a text string and converts it into a text block of Korean and non-Korean text sections.
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public TextBlock GetTextBlock(string Text)
        {
            var TextBlock1 = new TextBlock();
            var KoreanTextSection1 = new KoreanTextSection();
            var NonKoreanTextSection1 = new NonKoreanTextSection();

            foreach (var Character in Text)
            {
                if (KoreanSyllable.IsAKoreanSyllable(Character))
                {
                    var Syllable = new KoreanSyllable(Character);

                    if (NonKoreanTextSection1.Content != "")
                    {
                        TextBlock1.TextSections.Add(NonKoreanTextSection1);
                        NonKoreanTextSection1 = new NonKoreanTextSection();
                    }

                    KoreanTextSection1.Syllables.Add(Syllable);
                }
                else
                {
                    if (KoreanTextSection1.Syllables.Any())
                    {
                        TextBlock1.TextSections.Add(KoreanTextSection1);
                        KoreanTextSection1 = new KoreanTextSection();
                    }

                    NonKoreanTextSection1.Content += Character;
                }
            }

            if (NonKoreanTextSection1.Content != "")
            {
                TextBlock1.TextSections.Add(NonKoreanTextSection1);
            }

            if (KoreanTextSection1.Syllables.Any())
            {
                TextBlock1.TextSections.Add(KoreanTextSection1);
            }

            return TextBlock1;
        }

        public string RomaniseText(string Text)
        {
            var StringBuilder1 = new StringBuilder();
            var TextBlock1 = GetTextBlock(Text);

            foreach (var TextSection in TextBlock1.TextSections)
            {
                if (TextSection is KoreanTextSection)
                {
                    var KoreanTextSection1 = TextSection as KoreanTextSection;
                    var Syllables = KoreanTextSection1.Syllables.ToArray();

                    if ( Syllables.Length > 1)
                    {
                        for (var i = 0; i < Syllables.Length; i++)
                        {
                            KoreanSyllable? PrecedingSyllable = null;
                            KoreanSyllable Syllable = Syllables[i];
                            KoreanSyllable? SucceedingSyllable = null;

                            var RomanisedText = "";

                            if (i > 0)
                            {
                                PrecedingSyllable = Syllables[i - 1];
                            }
                            else if (i < Syllables.Length - 1)
                            {
                                SucceedingSyllable = Syllables[i + 1];
                            }

                            RomanisedText = RomaniseSyllable(Syllable, PrecedingSyllable, SucceedingSyllable);

                            StringBuilder1.Append(RomanisedText);
                        }
                    }
                    else if (Syllables.Length == 1)
                    {
                        StringBuilder1.Append(RomaniseSyllable(Syllables[0]));
                    }
                }
                else if (TextSection is NonKoreanTextSection)
                {
                    StringBuilder1.Append((TextSection as NonKoreanTextSection).Content);
                }
            }

            return StringBuilder1.ToString();
        }

        public abstract string RomaniseTextBlock(TextBlock TextBlock1);
        public abstract string RomaniseSyllable(KoreanSyllable Syllable1, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null);
        public abstract string RomaniseLetter(KoreanLetter Jamo1);
    }
}
