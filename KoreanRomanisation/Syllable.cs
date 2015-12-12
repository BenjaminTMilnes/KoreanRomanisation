using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a syllable in Korean.
    /// </summary>
    public class Syllable : IEquatable<Syllable>, IComparable<Syllable>
    {
        public int Initial { get; set; }
        public int Medial { get; set; }
        public int Final { get; set; }

        public Syllable(int Initial1, int Medial1)
        {
            Initial = Initial1;
            Medial = Medial1;
            Final = 0;
        }

        public Syllable(int Initial1, int Medial1, int Final1)
        {
            Initial = Initial1;
            Medial = Medial1;
            Final = Final1;
        }

        public int CharacterCode()
        {
            return Initial * 588 + Medial * 28 + Final + 44032;
        }

        public bool Equals(Syllable s)
        {
            if (s == null)
            {
                return false;
            }

            return s.Initial == Initial && s.Medial == Medial && s.Final == Final;
        }

        public int CompareTo(Syllable s)
        {
            return CharacterCode().CompareTo(s.CharacterCode());
        }
    }
}
