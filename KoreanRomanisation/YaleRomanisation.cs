using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class YaleRomanisation : Romanisation
    {
        private InitialRomanisationRule[] InitialRomanisationRules;
        private MedialRomanisationRule[] MedialRomanisationRules;
        private FinalRomanisationRule[] FinalRomanisationRules;

        public YaleRomanisation()
        {
            InitialRomanisationRules = new InitialRomanisationRule[] {
                new InitialRomanisationRule(Jamo.Giyeok, "k"),
                new InitialRomanisationRule(Jamo.SsangGiyeok, "kk"),
                new InitialRomanisationRule(Jamo.Nieun, "n"),
                new InitialRomanisationRule(Jamo.Digeut, "t"),
                new InitialRomanisationRule(Jamo.SsangDigeut, "tt"),
                new InitialRomanisationRule(Jamo.Rieul, "l"),
                new InitialRomanisationRule(Jamo.Mieum, "m"),
                new InitialRomanisationRule(Jamo.Bieup, "p"),
                new InitialRomanisationRule(Jamo.SsangBieup, "pp"),
                new InitialRomanisationRule(Jamo.Shiot, "s"),
                new InitialRomanisationRule(Jamo.SsangShiot, "ss"),
                new InitialRomanisationRule(Jamo.Ieung, ""),
                new InitialRomanisationRule(Jamo.Jieut, "c"),
                new InitialRomanisationRule(Jamo.SsangJieut, "cc"),
                new InitialRomanisationRule(Jamo.Chieut, "ch"),
                new InitialRomanisationRule(Jamo.Kieuk, "kh"),
                new InitialRomanisationRule(Jamo.Tieut, "th"),
                new InitialRomanisationRule(Jamo.Pieup, "ph"),
                new InitialRomanisationRule(Jamo.Hieut, "h")
            };

            MedialRomanisationRules = new MedialRomanisationRule[] {
                new MedialRomanisationRule(Jamo.A, "a"),
                new MedialRomanisationRule(Jamo.Ae, "ay"),
                new MedialRomanisationRule(Jamo.Ya, "ya"),
                new MedialRomanisationRule(Jamo.Yae, "yay"),
                new MedialRomanisationRule(Jamo.Eo, "e"),
                new MedialRomanisationRule(Jamo.E, "ey"),
                new MedialRomanisationRule(Jamo.Yeo, "ye"),
                new MedialRomanisationRule(Jamo.Ye, "yey"),
                new MedialRomanisationRule(Jamo.O, "o"),
                new MedialRomanisationRule(Jamo.Wa, "wa"),
                new MedialRomanisationRule(Jamo.Wae, "way"),
                new MedialRomanisationRule(Jamo.Oe, "oy"),
                new MedialRomanisationRule(Jamo.Yo, "yo"),
                new MedialRomanisationRule(Jamo.U, "u"),
                new MedialRomanisationRule(Jamo.Wo, "we"),
                new MedialRomanisationRule(Jamo.We, "wey"),
                new MedialRomanisationRule(Jamo.Wi, "wi"),
                new MedialRomanisationRule(Jamo.Yu, "yu"),
                new MedialRomanisationRule(Jamo.Eu, "u"),
                new MedialRomanisationRule(Jamo.Ui, "uy"),
                new MedialRomanisationRule(Jamo.I, "i")
            };

            FinalRomanisationRules = new FinalRomanisationRule[] {
                new FinalRomanisationRule(Jamo.GiyeokBatchim, "k"),
                new FinalRomanisationRule(Jamo.SsangGiyeokBatchim, "kk"),
                new FinalRomanisationRule(Jamo.GiyeokShiotBatchim, "ks"),
                new FinalRomanisationRule(Jamo.NieunBatchim, "n"),
                new FinalRomanisationRule(Jamo.NieunJieutBatchim, "nc"),
                new FinalRomanisationRule(Jamo.NieunHieutBatchim, "nh"),
                new FinalRomanisationRule(Jamo.DigeutBatchim, "t"),
                new FinalRomanisationRule(Jamo.RieulBatchim, "l"),
                new FinalRomanisationRule(Jamo.RieulGiyeokBatchim, "lk"),
                new FinalRomanisationRule(Jamo.RieulMieumBatchim, "lm"),
                new FinalRomanisationRule(Jamo.RieulBieupBatchim, "lp"),
                new FinalRomanisationRule(Jamo.RieulShiotBatchim, "ls"),
                new FinalRomanisationRule(Jamo.RieulTieutBatchim, "lth"),
                new FinalRomanisationRule(Jamo.RieulPieupBatchim, "lph"),
                new FinalRomanisationRule(Jamo.RieulHieutBatchim, "lh"),
                new FinalRomanisationRule(Jamo.MieumBatchim, "m"),
                new FinalRomanisationRule(Jamo.BieupBatchim, "p"),
                new FinalRomanisationRule(Jamo.BieupShiotBatchim, "ps"),
                new FinalRomanisationRule(Jamo.ShiotBatchim, "s"),
                new FinalRomanisationRule(Jamo.SsangShiotBatchim, "ss"),
                new FinalRomanisationRule(Jamo.IeungBatchim, "ng"),
                new FinalRomanisationRule(Jamo.JieutBatchim, "c"),
                new FinalRomanisationRule(Jamo.ChieutBatchim, "ch"),
                new FinalRomanisationRule(Jamo.KieukBatchim, "kh"),
                new FinalRomanisationRule(Jamo.TieutBatchim, "th"),
                new FinalRomanisationRule(Jamo.PieupBatchim, "ph"),
                new FinalRomanisationRule(Jamo.HieutBatchim, "h")
            };
        }

        public override string Romanise(Syllable Syllable1, Syllable? PrecedingSyllable = null, Syllable? SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            StringBuilder1.Append(RomaniseInitial(Syllable1));
            StringBuilder1.Append(RomaniseMedial(Syllable1));
            StringBuilder1.Append(RomaniseFinal(Syllable1));

            return StringBuilder1.ToString();
        }

        private string RomaniseInitial(Syllable Syllable1)
        {
            return InitialRomanisationRules.First(r => r.Initial == Syllable1.Initial).Romanisation;
        }

        private string RomaniseMedial(Syllable Syllable1)
        {
            return MedialRomanisationRules.First(m => m.Jamo == Syllable1.Medial).Romanisation;
        }

        private string RomaniseFinal(Syllable Syllable1)
        {
            if (Syllable1.HasFinal)
            {
                return FinalRomanisationRules.First(f => f.Final == Syllable1.Final).Romanisation;
            }

            return "";
        }

        public override string Romanise(Jamo Jamo1)
        {
            throw new NotImplementedException();
        }
    }
}
