using System.Collections.Generic;
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

        public bool PreserveNonKoreanText { get; set; }
        public bool UseSh { get; set; }
        public bool UseOi { get; set; }

        protected IEnumerable<InitialRomanisationRule> InitialRomanisationRules;
        protected IEnumerable<InitialPronunciationChangeRomanisationRule> InitialPronunciationChangeRomanisationRules;

        protected IEnumerable<MedialRomanisationRule> MedialRomanisationRules;

        protected IEnumerable<FinalRomanisationRule> FinalRomanisationRules;
        protected IEnumerable<FinalPronunciationChangeRomanisationRule> FinalPronunciationChangeRomanisationRules;

        #endregion

        #region Constructors

        public Romanisation()
        {
            PreserveNonKoreanText = true;
            UseSh = true;
            UseOi = false;
        }

        /// <summary>
        /// Sets the rules of the romanisation system. In this library, romanisation rules are hard-coded, since they rarely change - this function is where they are set.
        /// </summary>
        protected abstract void SetRules();

        #endregion

        #region Romanisation Functions

        /// <summary>
        /// Takes a text string and converts it into a text block of Korean and non-Korean text sections.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public TextBlock GetTextBlock(string text)
        {
            var textBlock = new TextBlock();
            var koreanTextSection = new KoreanTextSection();
            var nonKoreanTextSection = new NonKoreanTextSection();

            foreach (var character in text)
            {
                if (KoreanSyllable.IsAKoreanSyllable(character))
                {
                    var syllable = new KoreanSyllable(character);

                    if (nonKoreanTextSection.Content != "")
                    {
                        textBlock.TextSections.Add(nonKoreanTextSection);
                        nonKoreanTextSection = new NonKoreanTextSection();
                    }

                    koreanTextSection.Syllables.Add(syllable);
                }
                else
                {
                    if (koreanTextSection.Syllables.Any())
                    {
                        textBlock.TextSections.Add(koreanTextSection);
                        koreanTextSection = new KoreanTextSection();
                    }

                    nonKoreanTextSection.Content += character;
                }
            }

            if (nonKoreanTextSection.Content != "")
            {
                textBlock.TextSections.Add(nonKoreanTextSection);
            }

            if (koreanTextSection.Syllables.Any())
            {
                textBlock.TextSections.Add(koreanTextSection);
            }

            return textBlock;
        }

        /// <summary>
        /// Returns whether or not the given letter is an 'i' medial, which is useful for romanising the letters shiot and ssangshiot.
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        protected bool IsIMedial(KoreanLetter letter)
        {
            var iMedials = new List<KoreanLetter>() { KoreanLetter.I, KoreanLetter.Ya, KoreanLetter.Yae, KoreanLetter.Yeo, KoreanLetter.Ye, KoreanLetter.Yo, KoreanLetter.Yu };

            return iMedials.Any(m => m == letter);
        }

        public string RomaniseText(string text)
        {
            var textBlock = GetTextBlock(text);

            return RomaniseTextBlock(textBlock);
        }

        public string RomaniseTextBlock(TextBlock textBlock)
        {
            var stringBuilder = new StringBuilder();

            foreach (var textSection in textBlock.TextSections)
            {
                if (textSection is KoreanTextSection)
                {
                    var koreanTextSection = textSection as KoreanTextSection;
                    var syllables = koreanTextSection.Syllables.ToArray();

                    if (syllables.Length > 1)
                    {
                        for (var i = 0; i < syllables.Length; i++)
                        {
                            KoreanSyllable? precedingSyllable = null;
                            KoreanSyllable syllable = syllables[i];
                            KoreanSyllable? succeedingSyllable = null;

                            var romanisedText = "";

                            if (i > 0)
                            {
                                precedingSyllable = syllables[i - 1];
                            }
                            else if (i < syllables.Length - 1)
                            {
                                succeedingSyllable = syllables[i + 1];
                            }

                            romanisedText = RomaniseSyllable(syllable, precedingSyllable, succeedingSyllable);

                            stringBuilder.Append(romanisedText);
                        }
                    }
                    else if (syllables.Length == 1)
                    {
                        var romanisedText = RomaniseSyllable(syllables[0]);

                        stringBuilder.Append(romanisedText);
                    }
                }
                else if (textSection is NonKoreanTextSection)
                {
                    var content = (textSection as NonKoreanTextSection).Content;

                    stringBuilder.Append(content);
                }
            }

            return stringBuilder.ToString();
        }

        public abstract string RomaniseSyllable(KoreanSyllable syllable, KoreanSyllable? precedingSyllable = null, KoreanSyllable? succeedingSyllable = null);
        public abstract string RomaniseLetter(KoreanLetter letter);

        #endregion
    }
}
