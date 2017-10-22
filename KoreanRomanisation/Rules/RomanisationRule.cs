namespace KoreanRomanisation
{
    /// <summary>
    /// A base class representing a rule for how to romanise something.
    /// </summary>
    public abstract class RomanisationRule
    {
        public string Romanisation { get; protected set; }

        public RomanisationRule(string Romanisation1)
        {
            Romanisation = Romanisation1;
        }
    }
}
