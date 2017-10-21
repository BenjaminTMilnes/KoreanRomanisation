using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a syllable in Korean.
    /// </summary>
    public struct Syllable : IEquatable<Syllable>, IEquatable<char>, IEquatable<int>, IComparable<Syllable>, IComparable<char>, IComparable<int>, IFormattable
    {
        private const int FirstCode = 44032;
        private const int LastCode = 55203;

        private const int NumberOfInitialJamo = 19;
        private const int NumberOfMedialJamo = 21;
        private const int NumberOfFinalJamo = 28;

        private int _CharacterCode;

        public int CharacterCode
        {
            get
            {
                return _CharacterCode;
            }
        }

        public KoreanLetter Initial
        {
            get
            {
                return KoreanLetter.GetKoreanLetterFromInitialCharacterCode((CharacterCode - FirstCode) / (NumberOfMedialJamo * NumberOfFinalJamo));
            }
        }

        public KoreanLetter Medial
        {
            get
            {
                return KoreanLetter.GetKoreanLetterFromMedialCharacterCode(((CharacterCode - FirstCode) % (NumberOfMedialJamo * NumberOfFinalJamo)) / NumberOfFinalJamo);
            }
        }

        public KoreanLetter Final
        {
            get
            {
                return KoreanLetter.GetKoreanLetterFromFinalCharacterCode(((CharacterCode - FirstCode) % (NumberOfMedialJamo * NumberOfFinalJamo)) % NumberOfFinalJamo);
            }
        }

        public bool HasFinal
        {
            get
            {
                return ((CharacterCode - FirstCode) % (NumberOfMedialJamo * NumberOfFinalJamo)) % NumberOfFinalJamo > 0;
            }
        }

        public static bool operator ==(Syllable Syllable1, Syllable Syllable2)
        {
            return Syllable1.CharacterCode == Syllable2.CharacterCode;
        }

        public static bool operator !=(Syllable Syllable1, Syllable Syllable2)
        {
            return Syllable1.CharacterCode != Syllable2.CharacterCode;
        }

        public Syllable(int CharacterCode1)
        {
            if (!IsSyllable(CharacterCode1))
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

            _CharacterCode = Initial1 * NumberOfMedialJamo * NumberOfFinalJamo + Medial1 * NumberOfFinalJamo + Final1;
        }

        public static bool IsSyllable(int CharacterCode1)
        {
            return (CharacterCode1 >= FirstCode && CharacterCode1 <= LastCode);
        }

        public bool Equals(Syllable s)
        {
            if (s == null)
            {
                return false;
            }

            return CharacterCode == s.CharacterCode;
        }

        public bool Equals(char c)
        {
            return CharacterCode == c;
        }

        public bool Equals(int i)
        {
            return CharacterCode == i;
        }

        public int CompareTo(Syllable s)
        {
            return CharacterCode.CompareTo(s.CharacterCode);
        }

        public int CompareTo(char c)
        {
            return CharacterCode.CompareTo(c);
        }

        public int CompareTo(int i)
        {
            return CharacterCode.CompareTo(i);
        }

        public override string ToString()
        {
            return ToString("%S");
        }

        public string ToString(string Format)
        {
            return ToString(Format, CultureInfo.CurrentCulture);
        }

        public string ToString(string Format, IFormatProvider FormatProvider)
        {
            Format = Format.Replace("%S", ((char)_CharacterCode).ToString());

            return Format;
        }
    }
}
