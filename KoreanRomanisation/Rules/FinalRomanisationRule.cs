namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a rule for how to romanise a final.
    /// </summary>
    public sealed class FinalRomanisationRule : RomanisationRule
    {
        public KoreanLetter Final { get; private set; }

        public FinalRomanisationRule(KoreanLetter final, string romanisation) : base(romanisation)
        {
            Final = final;
        }
    }
}
