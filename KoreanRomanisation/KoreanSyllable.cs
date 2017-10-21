using System;
using System.Globalization;

namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a syllable in Korean.
    /// </summary>
    public struct KoreanSyllable : IEquatable<KoreanSyllable>, IEquatable<char>, IEquatable<int>, IComparable<KoreanSyllable>, IComparable<char>, IComparable<int>, IFormattable
    {
        #region Character Code Constants

        private const int FirstKoreanSyllableCharacterCode = 44032;
        private const int LastKoreanSyllableCharacterCode = 55203;

        private const int NumberOfInitials = 19;
        private const int NumberOfMedials = 21;
        private const int NumberOfFinals = 28;

        #endregion

        #region Core Properties

        private int _CharacterCode;

        public int CharacterCode { get { return _CharacterCode; } }

        public KoreanLetter Initial
        {
            get
            {
                var InitialCharacterCode = (CharacterCode - FirstKoreanSyllableCharacterCode) / (NumberOfMedials * NumberOfFinals);

                return KoreanLetter.GetKoreanLetterFromInitialCharacterCode(InitialCharacterCode);
            }
        }

        public KoreanLetter Medial
        {
            get
            {
                var MedialCharacterCode = ((CharacterCode - FirstKoreanSyllableCharacterCode) % (NumberOfMedials * NumberOfFinals)) / NumberOfFinals;

                return KoreanLetter.GetKoreanLetterFromMedialCharacterCode(MedialCharacterCode);
            }
        }

        public KoreanLetter Final
        {
            get
            {
                var FinalCharacterCode = ((CharacterCode - FirstKoreanSyllableCharacterCode) % (NumberOfMedials * NumberOfFinals)) % NumberOfFinals;

                return KoreanLetter.GetKoreanLetterFromFinalCharacterCode(FinalCharacterCode);
            }
        }

        public bool HasFinal
        {
            get
            {
                var FinalCharacterCode = ((CharacterCode - FirstKoreanSyllableCharacterCode) % (NumberOfMedials * NumberOfFinals)) % NumberOfFinals;

                return FinalCharacterCode > 0;
            }
        }

        #endregion

        #region Operator Overloads

        public static bool operator ==(KoreanSyllable KoreanSyllable1, KoreanSyllable KoreanSyllable2)
        {
            return KoreanSyllable1.CharacterCode == KoreanSyllable2.CharacterCode;
        }

        public static bool operator !=(KoreanSyllable KoreanSyllable1, KoreanSyllable KoreanSyllable2)
        {
            return KoreanSyllable1.CharacterCode != KoreanSyllable2.CharacterCode;
        }

        #endregion

        #region Constructors

        public KoreanSyllable(int CharacterCode1)
        {
            if (!IsAKoreanSyllable(CharacterCode1))
            {
                var Message = $"Korean syllables have character codes between {FirstKoreanSyllableCharacterCode} and {LastKoreanSyllableCharacterCode}.";

                throw new ArgumentOutOfRangeException(nameof(CharacterCode1), Message);
            }

            _CharacterCode = CharacterCode1;
        }

        public KoreanSyllable(int Initial1, int Medial1) : this(Initial1, Medial1, 0) { }

        public KoreanSyllable(int Initial1, int Medial1, int Final1)
        {
            if (Initial1 < 0 || Initial1 >= NumberOfInitials)
            {
                throw new ArgumentOutOfRangeException(nameof(Initial1), $"The initial character code must be between 0 and {NumberOfInitials - 1}");
            }

            if (Medial1 < 0 || Medial1 >= NumberOfMedials)
            {
                throw new ArgumentOutOfRangeException(nameof(Medial1), $"The medial character code must be between 0 and {NumberOfMedials - 1}");
            }

            if (Final1 < 0 || Final1 >= NumberOfFinals)
            {
                throw new ArgumentOutOfRangeException(nameof(Final1), $"The final character code must be between 0 and {NumberOfFinals - 1}");
            }

            _CharacterCode = Initial1 * NumberOfMedials * NumberOfFinals + Medial1 * NumberOfFinals + Final1;
        }

        public static bool IsAKoreanSyllable(int CharacterCode1)
        {
            return (CharacterCode1 >= FirstKoreanSyllableCharacterCode && CharacterCode1 <= LastKoreanSyllableCharacterCode);
        }

        #endregion

        #region Comparisons

        public bool Equals(KoreanSyllable KoreanSyllable1)
        {
            if (KoreanSyllable1 == null)
            {
                return false;
            }

            return CharacterCode == KoreanSyllable1.CharacterCode;
        }

        public bool Equals(char c)
        {
            return CharacterCode == c;
        }

        public bool Equals(int i)
        {
            return CharacterCode == i;
        }

        public int CompareTo(KoreanSyllable KoreanSyllable1)
        {
            return CharacterCode.CompareTo(KoreanSyllable1.CharacterCode);
        }

        public int CompareTo(char c)
        {
            return CharacterCode.CompareTo(c);
        }

        public int CompareTo(int i)
        {
            return CharacterCode.CompareTo(i);
        }

        #endregion

        #region String Formatting

        public override string ToString()
        {
            return ToString("S");
        }

        public string ToString(string Format)
        {
            return ToString(Format, CultureInfo.CurrentCulture);
        }

        public string ToString(string Format, IFormatProvider FormatProvider)
        {
            Format = Format.Replace("S", ((char)_CharacterCode).ToString());

            return Format;
        }

        #endregion
    }
}
