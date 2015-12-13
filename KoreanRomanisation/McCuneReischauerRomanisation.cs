using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class McCuneReischauerRomanisation : Romanisation
    {
        public override string Romanise(Syllable Syllable1, Syllable? PrecedingSyllable = null, Syllable? SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            var HasWrittenInitial = false;

            if (PrecedingSyllable != null)
            {
                var Changes = new[] {
                new object[] { Jamo.GiyeokBatchim, Jamo.Rieul, "n" },
                new object[] { Jamo.NieunBatchim, Jamo.Giyeok, "'g" },
                new object[] { Jamo.NieunBatchim, Jamo.Digeut, "d" },
                new object[] { Jamo.NieunBatchim, Jamo.Rieul, "l" },
                new object[] { Jamo.NieunBatchim, Jamo.Bieup, "b" },
                new object[] { Jamo.NieunBatchim, Jamo.Jieut, "j" },
                new object[] { Jamo.RieulBatchim, Jamo.Giyeok, "g" },
                new object[] { Jamo.RieulBatchim, Jamo.Nieun, "l" },
                new object[] { Jamo.RieulBatchim, Jamo.Digeut, "d" },
                new object[] { Jamo.RieulBatchim, Jamo.Rieul, "l" },
                new object[] { Jamo.RieulBatchim, Jamo.Bieup, "b" },
                new object[] { Jamo.RieulBatchim, Jamo.Jieut, "j" },
                new object[] { Jamo.MieumBatchim, Jamo.Giyeok, "g" },
                new object[] { Jamo.MieumBatchim, Jamo.Digeut, "d" },
                new object[] { Jamo.MieumBatchim, Jamo.Rieul, "n" },
                new object[] { Jamo.MieumBatchim, Jamo.Bieup, "b" },
                new object[] { Jamo.MieumBatchim, Jamo.Jieut, "j" },
                new object[] { Jamo.BieupBatchim, Jamo.Rieul, "n" },
                new object[] { Jamo.IeungBatchim, Jamo.Giyeok, "g" },
                new object[] { Jamo.IeungBatchim, Jamo.Digeut, "d" },
                new object[] { Jamo.IeungBatchim, Jamo.Rieul, "n" },
                new object[] { Jamo.IeungBatchim, Jamo.Bieup, "b" },
                new object[] { Jamo.IeungBatchim, Jamo.Jieut, "j" } };

                if (Changes.Any(c => (Jamo)c[0] == Jamo.FromFinalCode(PrecedingSyllable.Value.Final) && (Jamo)c[1] == Jamo.FromInitialCode(Syllable1.Initial)))
                {
                    StringBuilder1.Append((string)Changes.First(c => (Jamo)c[0] == Jamo.FromFinalCode(PrecedingSyllable.Value.Final) && (Jamo)c[1] == Jamo.FromInitialCode(Syllable1.Initial))[2]);
                    HasWrittenInitial = true;
                }

            }

            if (PrecedingSyllable == null || HasWrittenInitial == false)
            {
                if (UseSh && Syllable1.Initial == 9 && (Syllable1.Medial == 20 || Syllable1.Medial == 2 || Syllable1.Medial == 3 || Syllable1.Medial == 6 || Syllable1.Medial == 7 || Syllable1.Medial == 12 || Syllable1.Medial == 17))
                {
                    StringBuilder1.Append("sh");
                }
                else if (UseSh && Syllable1.Initial == 10 && (Syllable1.Medial == 20 || Syllable1.Medial == 2 || Syllable1.Medial == 3 || Syllable1.Medial == 6 || Syllable1.Medial == 7 || Syllable1.Medial == 12 || Syllable1.Medial == 17))
                {
                    StringBuilder1.Append("ssh");
                }
                else
                {
                    var Initials = new string[] { "k", "kk", "n", "t", "tt", "r", "m", "p", "pp", "s", "ss", "", "ch", "tch", "ch'", "k'", "t'", "p'", "h" };

                    StringBuilder1.Append(Initials[Syllable1.Initial]);
                }

            }

            if (PrecedingSyllable != null && (PrecedingSyllable.Value.Medial == 0 || PrecedingSyllable.Value.Medial == 4) && PrecedingSyllable.Value.Final == 0 && Syllable1.Initial == 11 && Syllable1.Medial == 5)
            {
                StringBuilder1.Append("ë");
            }
            else
            {
                var Medials = new string[] { "a", "ae", "ya", "yae", "ŏ", "e", "yŏ", "ye", "o", "wa", "wae", "oe", "yo", "u", "wŏ", "we", "wi", "yu", "ŭ", "ŭi", "i" };

                StringBuilder1.Append(Medials[Syllable1.Medial]);
            }

            var HasWrittenFinal = false;

            if (SucceedingSyllable != null)
            {
                var Changes = new[] {
                new object[] { Jamo.GiyeokBatchim, Jamo.Ieung, "g" },
                new object[] { Jamo.GiyeokBatchim, Jamo.Nieun, "ng" },
                new object[] { Jamo.GiyeokBatchim, Jamo.Mieum, "ng" },
                new object[] { Jamo.NieunBatchim, Jamo.Rieul, "l" },
                new object[] { Jamo.RieulBatchim, Jamo.Ieung, "r" },
                new object[] { Jamo.RieulBatchim, Jamo.Hieut, "r" },
                new object[] { Jamo.BieupBatchim, Jamo.Ieung, "b" },
                new object[] { Jamo.BieupBatchim, Jamo.Nieun, "m" },
                new object[] { Jamo.BieupBatchim, Jamo.Rieul, "m" },
                new object[] { Jamo.BieupBatchim, Jamo.Mieum, "m" } };

                if (Changes.Any(c => (Jamo)c[0] == Jamo.FromFinalCode(Syllable1.Final) && (Jamo)c[1] == Jamo.FromInitialCode(SucceedingSyllable.Value.Initial)))
                {
                    StringBuilder1.Append((string)Changes.First(c => (Jamo)c[0] == Jamo.FromFinalCode(Syllable1.Final) && (Jamo)c[1] == Jamo.FromInitialCode(SucceedingSyllable.Value.Initial))[2]);
                    HasWrittenFinal = true;
                }
            }

            if (SucceedingSyllable == null || HasWrittenFinal == false)
            {
                var Finals = new string[] { "", "k", "k", "", "n", "", "", "t", "l", "", "", "", "", "", "", "", "m", "p", "", "t", "t", "ng", "t", "t", "k", "t", "p", "t" };

                StringBuilder1.Append(Finals[Syllable1.Final]);
            }

            return StringBuilder1.ToString();
        }

        public override string Romanise(Jamo Jamo1)
        {
            throw new NotImplementedException();
        }
    }
}
