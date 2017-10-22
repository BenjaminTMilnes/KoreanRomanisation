namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a rule for how to romanise a final.
    /// </summary>
    public sealed class FinalRomanisationRule : RomanisationRule
    {
        public KoreanLetter Final { get; private set; }

        public FinalRomanisationRule(KoreanLetter Final1, string Romanisation1) : base(Romanisation1)
        {
            Final = Final1;
        }
    }
}
