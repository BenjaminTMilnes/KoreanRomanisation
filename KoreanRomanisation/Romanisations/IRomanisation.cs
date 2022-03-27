namespace KoreanRomanisation
{
    public interface IRomanisation
    {
        /// <summary>
        /// Whether or not to remove any text that isn't Korean from the final output.
        /// </summary>
        bool PreserveNonKoreanText { get; set; }

        /// <summary>
        /// Whether or not to romanise the letter shiot as 'sh', and ssangshiot as 'ssh', when they appear before an 'i' sound.
        /// </summary>
        bool UseSh { get; set; }

        /// <summary>
        /// Whether or not to romanise o followed by i as 'oi' instead of 'oe'.
        /// </summary>
        bool UseOi { get; set; }

        /// <summary>
        /// Romanise a given text string.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string RomaniseText(string text);

        /// <summary>
        /// Romanise a given text block.
        /// </summary>
        /// <param name="textBlock"></param>
        /// <returns></returns>
        string RomaniseTextBlock(TextBlock textBlock);

        /// <summary>
        /// Romanise a given Korean syllable.
        /// </summary>
        /// <param name="syllable"></param>
        /// <param name="precedingSyllable"></param>
        /// <param name="succeedingSyllable"></param>
        /// <returns></returns>
        string RomaniseSyllable(KoreanSyllable syllable, KoreanSyllable? precedingSyllable = null, KoreanSyllable? succeedingSyllable = null);

        /// <summary>
        /// Romanise a given Korean letter.
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        string RomaniseLetter(KoreanLetter letter);
    }
}
