namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a rule for how to romanise a medial.
    /// </summary>
    public sealed class MedialRomanisationRule : RomanisationRule
    {
        public KoreanLetter Medial { get; private set; }

        public MedialRomanisationRule(KoreanLetter medial, string romanisation) : base(romanisation)
        {
            Medial = medial;
        }
    }
}
