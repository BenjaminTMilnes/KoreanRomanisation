using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a jamo.
    /// </summary>
    public struct Jamo : IEquatable<Jamo>, IEquatable<char>, IEquatable<int>, IComparable<Jamo>, IComparable<char>, IComparable<int>, IFormattable
    {
        private const int FirstCode = 4352;
        private const int LastCode = 4607;

        private const int FirstCommonInitial = 4352;
        private const int LastCommonInitial = 4370;

        private const int FirstCommonMedial = 4449;
        private const int LastCommonMedial = 4469;

        private const int FirstCommonFinal = 4520;
        private const int LastCommonFinal = 4546;

        public static Jamo None = new Jamo(-1);
        
        public static Jamo Giyeok = new Jamo('ᄀ');
        public static Jamo SsangGiyeok = new Jamo('ᄁ');
        public static Jamo Nieun = new Jamo('ᄂ');
        public static Jamo Digeut = new Jamo('ᄃ');
        public static Jamo SsangDigeut = new Jamo('ᄄ');
        public static Jamo Rieul = new Jamo('ᄅ');
        public static Jamo Mieum = new Jamo('ᄆ');
        public static Jamo Bieup = new Jamo('ᄇ');
        public static Jamo SsangBieup = new Jamo('ᄈ');
        public static Jamo Shiot = new Jamo('ᄉ');
        public static Jamo SsangShiot = new Jamo('ᄊ');
        public static Jamo Ieung = new Jamo('ᄋ');
        public static Jamo Jieut = new Jamo('ᄌ');
        public static Jamo SsangJieut = new Jamo('ᄍ');
        public static Jamo Chieut = new Jamo('ᄎ');
        public static Jamo Kieuk = new Jamo('ᄏ');
        public static Jamo Tieut = new Jamo('ᄐ');
        public static Jamo Pieup = new Jamo('ᄑ');
        public static Jamo Hieut = new Jamo('ᄒ');

        public static Jamo A = new Jamo('ᅡ');
        public static Jamo Ae = new Jamo('ᅢ');
        public static Jamo Ya = new Jamo('ᅣ');
        public static Jamo Yae = new Jamo('ᅤ');
        public static Jamo Eo = new Jamo('ᅥ');
        public static Jamo E = new Jamo('ᅦ');
        public static Jamo Yeo = new Jamo('ᅧ');
        public static Jamo Ye = new Jamo('ᅨ');
        public static Jamo O = new Jamo('ᅩ');
        public static Jamo Wa = new Jamo('ᅪ');
        public static Jamo Wae = new Jamo('ᅫ');
        public static Jamo Oe = new Jamo('ᅬ');
        public static Jamo Yo = new Jamo('ᅭ');
        public static Jamo U = new Jamo('ᅮ');
        public static Jamo Wo = new Jamo('ᅯ');
        public static Jamo We = new Jamo('ᅰ');
        public static Jamo Wi = new Jamo('ᅱ');
        public static Jamo Yu = new Jamo('ᅲ');
        public static Jamo Eu = new Jamo('ᅳ');
        public static Jamo Ui = new Jamo('ᅴ');
        public static Jamo I = new Jamo('ᅵ');

        public static Jamo GiyeokBatchim = new Jamo('ᆨ');
        public static Jamo SsangGiyeokBatchim = new Jamo('ᆩ');
        public static Jamo GiyeokShiotBatchim = new Jamo('ᆪ');
        public static Jamo NieunBatchim = new Jamo('ᆫ');
        public static Jamo NieunJieutBatchim = new Jamo('ᆬ');
        public static Jamo NieunHieutBatchim = new Jamo('ᆭ');
        public static Jamo DigeutBatchim = new Jamo('ᆮ');
        public static Jamo RieulBatchim = new Jamo('ᆯ');
        public static Jamo RieulGiyeokBatchim = new Jamo('ᆰ');
        public static Jamo RieulMieumBatchim = new Jamo('ᆱ');
        public static Jamo RieulBieupBatchim = new Jamo('ᆲ');
        public static Jamo RieulShiotBatchim = new Jamo('ᆳ');
        public static Jamo RieulTieutBatchim = new Jamo('ᆴ');
        public static Jamo RieulPieupBatchim = new Jamo('ᆵ');
        public static Jamo RieulHieutBatchim = new Jamo('ᆶ');
        public static Jamo MieumBatchim = new Jamo('ᆷ');
        public static Jamo BieupBatchim = new Jamo('ᆸ');
        public static Jamo BieupShiotBatchim = new Jamo('ᆹ');
        public static Jamo ShiotBatchim = new Jamo('ᆺ');
        public static Jamo SsangShiotBatchim = new Jamo('ᆻ');
        public static Jamo IeungBatchim= new Jamo('ᆼ');
        public static Jamo JieutBatchim = new Jamo('ᆽ');
        public static Jamo ChieutBatchim = new Jamo('ᆾ');
        public static Jamo KieukBatchim = new Jamo('ᆿ');
        public static Jamo TieutBatchim = new Jamo('ᇀ');
        public static Jamo PieupBatchim = new Jamo('ᇁ');
        public static Jamo HieutBatchim = new Jamo('ᇂ');
        
        private int _CharacterCode;

        public int CharacterCode { get { return _CharacterCode; } }

        public static bool operator ==(Jamo Jamo1, Jamo Jamo2)
        {
            return Jamo1.CharacterCode == Jamo2.CharacterCode;
        }

        public static bool operator !=(Jamo Jamo1, Jamo Jamo2)
        {
            return Jamo1.CharacterCode != Jamo2.CharacterCode;
        }

        public Jamo(int CharacterCode1)
        {
            if (!IsJamo(CharacterCode1) && CharacterCode1 != -1)
            {
                throw new ArgumentOutOfRangeException(nameof(CharacterCode1), $"Korean jamo have character codes between {FirstCode} and {LastCode}.");
            }

            _CharacterCode = CharacterCode1;
        }

        public static Jamo FromInitialCode(int InitialCode1)
        {
            if (!IsCommonInitial(FirstCommonInitial + InitialCode1))
            {
                throw new ArgumentOutOfRangeException(nameof(InitialCode1), $"Korean initials are numbered between 0 and { LastCommonInitial - FirstCommonInitial }");
            }

            return new Jamo(FirstCommonInitial + InitialCode1);
        }

        public static Jamo FromMedialCode(int MedialCode1)
        {
            if (!IsCommonMedial(FirstCommonMedial + MedialCode1))
            {
                throw new ArgumentOutOfRangeException(nameof(MedialCode1), $"Korean medials are numbered between 0 and { LastCommonMedial - FirstCommonMedial }");
            }

            return new Jamo(FirstCommonMedial + MedialCode1);
        }

        public static Jamo FromFinalCode(int FinalCode1)
        {
            if (FinalCode1 == 0)
            {
                return new Jamo(-1);
            }

            if (!IsCommonFinal(FirstCommonFinal + FinalCode1 - 1))
            {
                throw new ArgumentOutOfRangeException(nameof(FinalCode1), $"Korean finals are numbered between 1 and { LastCommonFinal - FirstCommonFinal + 1 }");
            }

            return new Jamo(FirstCommonFinal + FinalCode1 - 1);
        }

        public static bool IsJamo(int CharacterCode1)
        {
            return (CharacterCode1 >= FirstCode && CharacterCode1 <= LastCode);
        }

        public static bool IsCommonInitial(int CharacterCode1)
        {
            return (CharacterCode1 >= FirstCommonInitial && CharacterCode1 <= LastCommonInitial);
        }

        public static bool IsCommonMedial(int CharacterCode1)
        {
            return (CharacterCode1 >= FirstCommonMedial && CharacterCode1 <= LastCommonMedial);
        }

        public static bool IsCommonFinal(int CharacterCode1)
        {
            return (CharacterCode1 >= FirstCommonFinal && CharacterCode1 <= LastCommonFinal);
        }

        public bool Equals(Jamo j)
        {
            if (j == null)
            {
                return false;
            }

            return CharacterCode == j.CharacterCode;
        }

        public bool Equals(char c)
        {
            return CharacterCode == c;
        }

        public bool Equals(int i)
        {
            return CharacterCode == i;
        }

        public int CompareTo(Jamo j)
        {
            return CharacterCode.CompareTo(j.CharacterCode);
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
            return ToString("%H");
        }

        public string ToString(string Format)
        {
            return ToString(Format, CultureInfo.CurrentCulture);
        }

        public string ToString(string Format, IFormatProvider FormatProvider)
        {
            Format = Format.Replace("%H", ((char)_CharacterCode).ToString());

            return Format;
        }
    }
}
