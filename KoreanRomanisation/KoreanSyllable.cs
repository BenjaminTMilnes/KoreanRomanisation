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

        public static bool operator ==(KoreanSyllable koreanSyllable1, KoreanSyllable koreanSyllable2)
        {
            return koreanSyllable1.CharacterCode == koreanSyllable2.CharacterCode;
        }

        public static bool operator !=(KoreanSyllable koreanSyllable1, KoreanSyllable koreanSyllable2)
        {
            return koreanSyllable1.CharacterCode != koreanSyllable2.CharacterCode;
        }

        #endregion

        #region Constructors

        public KoreanSyllable(int characterCode)
        {
            if (!IsAKoreanSyllable(characterCode))
            {
                var message = $"Korean syllables have character codes between {FirstKoreanSyllableCharacterCode} and {LastKoreanSyllableCharacterCode}.";

                throw new ArgumentOutOfRangeException(nameof(characterCode), message);
            }

            _CharacterCode = characterCode;
        }

        public KoreanSyllable(int initial, int medial) : this(initial, medial, 0) { }

        public KoreanSyllable(int initial, int medial, int final)
        {
            if (initial < 0 || initial >= NumberOfInitials)
            {
                throw new ArgumentOutOfRangeException(nameof(initial), $"The initial character code must be between 0 and {NumberOfInitials - 1}");
            }

            if (medial < 0 || medial >= NumberOfMedials)
            {
                throw new ArgumentOutOfRangeException(nameof(medial), $"The medial character code must be between 0 and {NumberOfMedials - 1}");
            }

            if (final < 0 || final >= NumberOfFinals)
            {
                throw new ArgumentOutOfRangeException(nameof(final), $"The final character code must be between 0 and {NumberOfFinals - 1}");
            }

            _CharacterCode = initial * NumberOfMedials * NumberOfFinals + medial * NumberOfFinals + final;
        }

        public static bool IsAKoreanSyllable(int characterCode)
        {
            return (characterCode >= FirstKoreanSyllableCharacterCode && characterCode <= LastKoreanSyllableCharacterCode);
        }

        #endregion

        #region Comparisons

        public bool Equals(KoreanSyllable koreanSyllable)
        {
            if (koreanSyllable == null)
            {
                return false;
            }

            return CharacterCode == koreanSyllable.CharacterCode;
        }

        public bool Equals(char c)
        {
            return CharacterCode == c;
        }

        public bool Equals(int i)
        {
            return CharacterCode == i;
        }

        public int CompareTo(KoreanSyllable koreanSyllable)
        {
            return CharacterCode.CompareTo(koreanSyllable.CharacterCode);
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

        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            format = format.Replace("S", ((char)_CharacterCode).ToString());

            return format;
        }

        #endregion
    }
}
