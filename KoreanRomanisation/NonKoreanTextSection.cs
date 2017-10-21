namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a section of non-Korean text.
    /// </summary>
    public class NonKoreanTextSection : ITextSection
    {
        /// <summary>
        /// The content of this text section. Since it is non-Korean text, it is not going to be processed, and can be stored just as a string.
        /// </summary>
        public string Content { get; set; }

        public NonKoreanTextSection() { }

        public NonKoreanTextSection(string Content1)
        {
            Content = Content1;
        }
    }
}
