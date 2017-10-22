namespace KoreanRomanisation
{
    public interface IRomanisation
    {
        /// <summary>
        /// Whether or not to remove any text that isn't Korean from the final output.
        /// </summary>
        bool PreserveNonKoreanText { get; }

        /// <summary>
        /// Whether or not to romanise the letter shiot as 'sh', and ssangshiot as 'ssh', when they appear before an 'i' sound.
        /// </summary>
        bool UseSh { get; }

        /// <summary>
        /// Whether or not to romanise o followed by i as 'oi' instead of 'oe'.
        /// </summary>
        bool UseOi { get; }

        /// <summary>
        /// Romanise a given text string.
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        string RomaniseText(string Text);

        /// <summary>
        /// Romanise a given text block.
        /// </summary>
        /// <param name="TextBlock1"></param>
        /// <returns></returns>
        string RomaniseTextBlock(TextBlock TextBlock1);

        /// <summary>
        /// Romanise a given Korean syllable.
        /// </summary>
        /// <param name="Syllable"></param>
        /// <param name="PrecedingSyllable"></param>
        /// <param name="SucceedingSyllable"></param>
        /// <returns></returns>
        string RomaniseSyllable(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null);

        /// <summary>
        /// Romanise a given Korean letter.
        /// </summary>
        /// <param name="Letter"></param>
        /// <returns></returns>
        string RomaniseLetter(KoreanLetter Letter);
    }
}
