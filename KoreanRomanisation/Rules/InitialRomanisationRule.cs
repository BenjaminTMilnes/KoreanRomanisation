namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a rule for how to romanise an initial.
    /// </summary>
    public sealed class InitialRomanisationRule : RomanisationRule
    {
        public KoreanLetter Initial { get; private set; }

        public InitialRomanisationRule(KoreanLetter initial, string romanisation) : base(romanisation)
        {
            Initial = initial;
        }
    }
}
