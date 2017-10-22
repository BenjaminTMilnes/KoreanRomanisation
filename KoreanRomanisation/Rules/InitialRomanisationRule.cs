namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a rule for how to romanise an initial.
    /// </summary>
    public sealed class InitialRomanisationRule : RomanisationRule
    {
        public KoreanLetter Initial { get; private set; }

        public InitialRomanisationRule(KoreanLetter Initial1, string Romanisation1) : base(Romanisation1)
        {
            Initial = Initial1;
        }
    }
}
