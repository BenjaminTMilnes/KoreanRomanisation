using System.Collections.Generic;

namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a block of Korean or mixed Korean and non-Korean text to be romanised.
    /// </summary>
    public class TextBlock
    {
        /// <summary>
        /// The list of text sections contained within the text block, each of which is either Korean text or non-Korean text.
        /// </summary>
        public IList<ITextSection> TextSections { get; set; }

        public TextBlock()
        {
            TextSections = new List<ITextSection>();
        }
    }
}
