namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a rule for how to romanise a final when followed by a given initial.
    /// </summary>
    public sealed class FinalPronunciationChangeRomanisationRule : RomanisationRule
    {
        public KoreanLetter Final { get; private set; }
        public KoreanLetter SucceedingInitial { get; private set; }

        public FinalPronunciationChangeRomanisationRule(KoreanLetter final, KoreanLetter succeedingInitial, string romanisation) : base(romanisation)
        {
            Final = final;
            SucceedingInitial = succeedingInitial;
        }
    }
}
