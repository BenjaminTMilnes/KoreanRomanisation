using System;
using System.Globalization;

namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a single letter of Korean - a jamo.
    /// </summary>
    public struct KoreanLetter : IEquatable<KoreanLetter>, IEquatable<char>, IEquatable<int>, IComparable<KoreanLetter>, IComparable<char>, IComparable<int>, IFormattable
    {
        #region Character Code Constants

        private const int FirstKoreanLetterCharacterCode = 4352;
        private const int LastKoreanLetterCharacterCode = 4607;

        private const int FirstCommonInitialCharacterCode = 4352;
        private const int LastCommonInitialCharacterCode = 4370;

        private const int FirstCommonMedialCharacterCode = 4449;
        private const int LastCommonMedialCharacterCode = 4469;

        private const int FirstCommonFinalCharacterCode = 4520;
        private const int LastCommonFinalCharacterCode = 4546;

        #endregion

        #region Instantiation Shortcuts

        public static KoreanLetter None = new KoreanLetter(-1);

        public static KoreanLetter Giyeok = new KoreanLetter('ᄀ');
        public static KoreanLetter SsangGiyeok = new KoreanLetter('ᄁ');
        public static KoreanLetter Nieun = new KoreanLetter('ᄂ');
        public static KoreanLetter Digeut = new KoreanLetter('ᄃ');
        public static KoreanLetter SsangDigeut = new KoreanLetter('ᄄ');
        public static KoreanLetter Rieul = new KoreanLetter('ᄅ');
        public static KoreanLetter Mieum = new KoreanLetter('ᄆ');
        public static KoreanLetter Bieup = new KoreanLetter('ᄇ');
        public static KoreanLetter SsangBieup = new KoreanLetter('ᄈ');
        public static KoreanLetter Shiot = new KoreanLetter('ᄉ');
        public static KoreanLetter SsangShiot = new KoreanLetter('ᄊ');
        public static KoreanLetter Ieung = new KoreanLetter('ᄋ');
        public static KoreanLetter Jieut = new KoreanLetter('ᄌ');
        public static KoreanLetter SsangJieut = new KoreanLetter('ᄍ');
        public static KoreanLetter Chieut = new KoreanLetter('ᄎ');
        public static KoreanLetter Kieuk = new KoreanLetter('ᄏ');
        public static KoreanLetter Tieut = new KoreanLetter('ᄐ');
        public static KoreanLetter Pieup = new KoreanLetter('ᄑ');
        public static KoreanLetter Hieut = new KoreanLetter('ᄒ');

        public static KoreanLetter A = new KoreanLetter('ᅡ');
        public static KoreanLetter Ae = new KoreanLetter('ᅢ');
        public static KoreanLetter Ya = new KoreanLetter('ᅣ');
        public static KoreanLetter Yae = new KoreanLetter('ᅤ');
        public static KoreanLetter Eo = new KoreanLetter('ᅥ');
        public static KoreanLetter E = new KoreanLetter('ᅦ');
        public static KoreanLetter Yeo = new KoreanLetter('ᅧ');
        public static KoreanLetter Ye = new KoreanLetter('ᅨ');
        public static KoreanLetter O = new KoreanLetter('ᅩ');
        public static KoreanLetter Wa = new KoreanLetter('ᅪ');
        public static KoreanLetter Wae = new KoreanLetter('ᅫ');
        public static KoreanLetter Oe = new KoreanLetter('ᅬ');
        public static KoreanLetter Yo = new KoreanLetter('ᅭ');
        public static KoreanLetter U = new KoreanLetter('ᅮ');
        public static KoreanLetter Wo = new KoreanLetter('ᅯ');
        public static KoreanLetter We = new KoreanLetter('ᅰ');
        public static KoreanLetter Wi = new KoreanLetter('ᅱ');
        public static KoreanLetter Yu = new KoreanLetter('ᅲ');
        public static KoreanLetter Eu = new KoreanLetter('ᅳ');
        public static KoreanLetter Ui = new KoreanLetter('ᅴ');
        public static KoreanLetter I = new KoreanLetter('ᅵ');

        public static KoreanLetter GiyeokBatchim = new KoreanLetter('ᆨ');
        public static KoreanLetter SsangGiyeokBatchim = new KoreanLetter('ᆩ');
        public static KoreanLetter GiyeokShiotBatchim = new KoreanLetter('ᆪ');
        public static KoreanLetter NieunBatchim = new KoreanLetter('ᆫ');
        public static KoreanLetter NieunJieutBatchim = new KoreanLetter('ᆬ');
        public static KoreanLetter NieunHieutBatchim = new KoreanLetter('ᆭ');
        public static KoreanLetter DigeutBatchim = new KoreanLetter('ᆮ');
        public static KoreanLetter RieulBatchim = new KoreanLetter('ᆯ');
        public static KoreanLetter RieulGiyeokBatchim = new KoreanLetter('ᆰ');
        public static KoreanLetter RieulMieumBatchim = new KoreanLetter('ᆱ');
        public static KoreanLetter RieulBieupBatchim = new KoreanLetter('ᆲ');
        public static KoreanLetter RieulShiotBatchim = new KoreanLetter('ᆳ');
        public static KoreanLetter RieulTieutBatchim = new KoreanLetter('ᆴ');
        public static KoreanLetter RieulPieupBatchim = new KoreanLetter('ᆵ');
        public static KoreanLetter RieulHieutBatchim = new KoreanLetter('ᆶ');
        public static KoreanLetter MieumBatchim = new KoreanLetter('ᆷ');
        public static KoreanLetter BieupBatchim = new KoreanLetter('ᆸ');
        public static KoreanLetter BieupShiotBatchim = new KoreanLetter('ᆹ');
        public static KoreanLetter ShiotBatchim = new KoreanLetter('ᆺ');
        public static KoreanLetter SsangShiotBatchim = new KoreanLetter('ᆻ');
        public static KoreanLetter IeungBatchim = new KoreanLetter('ᆼ');
        public static KoreanLetter JieutBatchim = new KoreanLetter('ᆽ');
        public static KoreanLetter ChieutBatchim = new KoreanLetter('ᆾ');
        public static KoreanLetter KieukBatchim = new KoreanLetter('ᆿ');
        public static KoreanLetter TieutBatchim = new KoreanLetter('ᇀ');
        public static KoreanLetter PieupBatchim = new KoreanLetter('ᇁ');
        public static KoreanLetter HieutBatchim = new KoreanLetter('ᇂ');

        #endregion

        #region Core Properties

        private int _CharacterCode;

        public int CharacterCode { get { return _CharacterCode; } }

        #endregion

        #region Operator Overloads

        public static bool operator ==(KoreanLetter koreanLetter1, KoreanLetter koreanLetter2)
        {
            return koreanLetter1.CharacterCode == koreanLetter2.CharacterCode;
        }

        public static bool operator !=(KoreanLetter koreanLetter1, KoreanLetter koreanLetter2)
        {
            return koreanLetter1.CharacterCode != koreanLetter2.CharacterCode;
        }

        #endregion

        #region Constructors

        public KoreanLetter(int characterCode)
        {
            if (!IsAKoreanLetter(characterCode) && characterCode != -1)
            {
                var message = $"Korean letters have character codes between {FirstKoreanLetterCharacterCode} and {LastKoreanLetterCharacterCode}.";

                throw new ArgumentOutOfRangeException(nameof(characterCode), message);
            }

            _CharacterCode = characterCode;
        }

        public static KoreanLetter GetKoreanLetterFromInitialCharacterCode(int initialCharacterCode)
        {
            if (!IsACommonInitial(FirstCommonInitialCharacterCode + initialCharacterCode))
            {
                var message = $"Korean initials are numbered between 0 and { LastCommonInitialCharacterCode - FirstCommonInitialCharacterCode }";

                throw new ArgumentOutOfRangeException(nameof(initialCharacterCode), message);
            }

            return new KoreanLetter(FirstCommonInitialCharacterCode + initialCharacterCode);
        }

        public static KoreanLetter GetKoreanLetterFromMedialCharacterCode(int medialCharacterCode)
        {
            if (!IsACommonMedial(FirstCommonMedialCharacterCode + medialCharacterCode))
            {
                var message = $"Korean medials are numbered between 0 and { LastCommonMedialCharacterCode - FirstCommonMedialCharacterCode }";

                throw new ArgumentOutOfRangeException(nameof(medialCharacterCode), message);
            }

            return new KoreanLetter(FirstCommonMedialCharacterCode + medialCharacterCode);
        }

        public static KoreanLetter GetKoreanLetterFromFinalCharacterCode(int finalCharacterCode)
        {
            if (finalCharacterCode == 0)
            {
                return new KoreanLetter(-1);
            }

            if (!IsACommonFinal(FirstCommonFinalCharacterCode + finalCharacterCode - 1))
            {
                var message = $"Korean finals are numbered between 1 and { LastCommonFinalCharacterCode - FirstCommonFinalCharacterCode + 1 }";

                throw new ArgumentOutOfRangeException(nameof(finalCharacterCode), message);
            }

            return new KoreanLetter(FirstCommonFinalCharacterCode + finalCharacterCode - 1);
        }

        public static bool IsAKoreanLetter(int characterCode)
        {
            return (characterCode >= FirstKoreanLetterCharacterCode && characterCode <= LastKoreanLetterCharacterCode);
        }

        public static bool IsACommonInitial(int characterCode)
        {
            return (characterCode >= FirstCommonInitialCharacterCode && characterCode <= LastCommonInitialCharacterCode);
        }

        public static bool IsACommonMedial(int characterCode)
        {
            return (characterCode >= FirstCommonMedialCharacterCode && characterCode <= LastCommonMedialCharacterCode);
        }

        public static bool IsACommonFinal(int characterCode)
        {
            return (characterCode >= FirstCommonFinalCharacterCode && characterCode <= LastCommonFinalCharacterCode);
        }

        #endregion

        #region Comparisons

        public bool Equals(KoreanLetter koreanLetter)
        {
            if (koreanLetter == null)
            {
                return false;
            }

            return CharacterCode == koreanLetter.CharacterCode;
        }

        public bool Equals(char c)
        {
            return CharacterCode == c;
        }

        public bool Equals(int i)
        {
            return CharacterCode == i;
        }

        public int CompareTo(KoreanLetter koreanLetter)
        {
            return CharacterCode.CompareTo(koreanLetter.CharacterCode);
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
            return ToString("H");
        }

        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            format = format.Replace("H", ((char)_CharacterCode).ToString());

            return format;
        }

        #endregion
    }
}
