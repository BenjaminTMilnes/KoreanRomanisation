using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public interface IRomanisation
    {
        bool PreserveNonKoreanCharacters { get; set; }
        bool UseSh { get; set; }

        string Romanise(string Document);
                        
        string Romanise(KoreanSyllable Syllable1, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null);

        string Romanise(KoreanLetter Jamo1);
    }
}
