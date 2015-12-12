using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a block of Korean text.
    /// </summary>
   public  class KoreanText : IText
    {
         public IList<Syllable> Syllables { get; set; }

        public KoreanText()
        {
            Syllables = new List<Syllable>();
        }
    }
}
