namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a rule for how to romanise a final when followed by a given initial.
    /// </summary>
    public sealed class FinalPronunciationChangeRomanisationRule : RomanisationRule
    {
        public KoreanLetter Final { get; private set; }
        public KoreanLetter SucceedingInitial { get; private set; }

        public FinalPronunciationChangeRomanisationRule(KoreanLetter Final1, KoreanLetter SucceedingInitial1, string Romanisation1) : base(Romanisation1)
        {
            Final = Final1;
            SucceedingInitial = SucceedingInitial1;
        }
    }
}
