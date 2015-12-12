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
                        
        string Romanise(Syllable Syllable1, Syllable PrecedingSyllable = null, Syllable SucceedingSyllable = null);
    }
}
