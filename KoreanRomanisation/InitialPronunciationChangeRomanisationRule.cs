namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a rule for how to romanise an initial when it is preceded by a given final.
    /// </summary>
    public sealed class InitialPronunciationChangeRomanisationRule : RomanisationRule
    {
        public KoreanLetter PrecedingFinal { get; private set; }
        public KoreanLetter Initial { get; private set; }

        public InitialPronunciationChangeRomanisationRule(KoreanLetter PrecedingFinal1, KoreanLetter Initial1, string Romanisation1) : base(Romanisation1)
        {
            PrecedingFinal = PrecedingFinal1;
            Initial = Initial1;
        }
    }
}
