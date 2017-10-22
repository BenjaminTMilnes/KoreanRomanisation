namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a rule for how to romanise a medial.
    /// </summary>
    public sealed class MedialRomanisationRule : RomanisationRule
    {
        public KoreanLetter Medial { get; private set; }

        public MedialRomanisationRule(KoreanLetter Medial1, string Romanisation1) : base(Romanisation1)
        {
            Medial = Medial1;
        }
    }
}
