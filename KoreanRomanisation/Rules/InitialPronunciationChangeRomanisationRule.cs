namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a rule for how to romanise an initial when it is preceded by a given final.
    /// </summary>
    public sealed class InitialPronunciationChangeRomanisationRule : RomanisationRule
    {
        public KoreanLetter PrecedingFinal { get; private set; }
        public KoreanLetter Initial { get; private set; }

        public InitialPronunciationChangeRomanisationRule(KoreanLetter precedingFinal, KoreanLetter initial, string romanisation) : base(romanisation)
        {
            PrecedingFinal = precedingFinal;
            Initial = initial;
        }
    }
}
