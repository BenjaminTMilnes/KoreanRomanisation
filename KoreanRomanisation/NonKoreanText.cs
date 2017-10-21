using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a block of non-Korean text.
    /// </summary>
    public class NonKoreanText : ITextSection
    {
        public string Content { get; set; }

        public NonKoreanText()
        {

        }

        public NonKoreanText(string Content1)
        {
            Content = Content1;
        }
    }
}
