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
        protected const int FirstCode = 44032;
        protected const int LastCode = 55203;

        protected const int NumberOfInitialJamo = 19;
        protected const int NumberOfMedialJamo = 21;
        protected const int NumberOfFinalJamo = 28;

        protected int _CharacterCode;

        public int CharacterCode
        {
            get
            {
                return _CharacterCode;
            }
        }

        public int Initial
        {
            get
            {
                return (CharacterCode - FirstCode) / (NumberOfMedialJamo * NumberOfFinalJamo);
            }
        }

        public int Medial
        {
            get
            {
                return ((CharacterCode - FirstCode) % (NumberOfMedialJamo * NumberOfFinalJamo)) / NumberOfFinalJamo;
            }
        }

        public int Final
        {
            get
            {
                return ((CharacterCode - FirstCode) % (NumberOfMedialJamo * NumberOfFinalJamo)) % NumberOfFinalJamo;
            }
        }
        
        public Syllable(int CharacterCode1)
        {
            if (CharacterCode1 < FirstCode || CharacterCode1 > LastCode)
            {
                throw new ArgumentOutOfRangeException(nameof(CharacterCode1), $"Korean syllables have character codes between { FirstCode} and { LastCode}.");
            }

            _CharacterCode = CharacterCode1;
        }

        public Syllable(int Initial1, int Medial1) : this(Initial1, Medial1, 0)
        {
        }

        public Syllable(int Initial1, int Medial1, int Final1)
        {
            if (Initial1 < 0 || Initial1 >= NumberOfInitialJamo)
            {
                throw new ArgumentOutOfRangeException(nameof(Initial1), $"The initial jamo code must be between 0 and {NumberOfInitialJamo - 1}");
            }
            if (Medial1 < 0 || Medial1 >= NumberOfMedialJamo)
            {
                throw new ArgumentOutOfRangeException(nameof(Medial1), $"The medial jamo code must be between 0 and {NumberOfMedialJamo - 1}");
            }
            if (Final1 < 0 || Final1 >= NumberOfFinalJamo)
            {
                throw new ArgumentOutOfRangeException(nameof(Final1), $"The final jamo code must be between 0 and {NumberOfFinalJamo - 1}");
            }

            _CharacterCode = Initial1 * 588 + Medial1 * 28 + Final1;
        }

        public static bool IsSyllable(int CharacterCode1)
        {
            if (CharacterCode1 >= FirstCode && CharacterCode1 <= LastCode)
            {
                return true;
            }

            return false;
        }

        public bool Equals(Syllable s)
        {
            if (s == null)
            {
                return false;
            }

            return CharacterCode == s.CharacterCode;
        }

        public int CompareTo(Syllable s)
        {
            return CharacterCode.CompareTo(s.CharacterCode);
        }
    }
}
