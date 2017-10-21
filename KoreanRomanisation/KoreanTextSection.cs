using System.Collections.Generic;

namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a section of Korean text.
    /// </summary>
    public class KoreanTextSection : ITextSection
    {
        /// <summary>
        /// The list of Korean syllables contained within the text section.
        /// </summary>
        public IList<Syllable> Syllables { get; set; }

        public KoreanTextSection()
        {
            Syllables = new List<Syllable>();
        }
    }
}
