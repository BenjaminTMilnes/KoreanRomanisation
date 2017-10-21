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
                new InitialRomanisationRule(KoreanLetter.Giyeok, "k"),
                new InitialRomanisationRule(KoreanLetter.SsangGiyeok, "kk"),
                new InitialRomanisationRule(KoreanLetter.Nieun, "n"),
                new InitialRomanisationRule(KoreanLetter.Digeut, "t"),
                new InitialRomanisationRule(KoreanLetter.SsangDigeut, "tt"),
                new InitialRomanisationRule(KoreanLetter.Rieul, "l"),
                new InitialRomanisationRule(KoreanLetter.Mieum, "m"),
                new InitialRomanisationRule(KoreanLetter.Bieup, "p"),
                new InitialRomanisationRule(KoreanLetter.SsangBieup, "pp"),
                new InitialRomanisationRule(KoreanLetter.Shiot, "s"),
                new InitialRomanisationRule(KoreanLetter.SsangShiot, "ss"),
                new InitialRomanisationRule(KoreanLetter.Ieung, ""),
                new InitialRomanisationRule(KoreanLetter.Jieut, "c"),
                new InitialRomanisationRule(KoreanLetter.SsangJieut, "cc"),
                new InitialRomanisationRule(KoreanLetter.Chieut, "ch"),
                new InitialRomanisationRule(KoreanLetter.Kieuk, "kh"),
                new InitialRomanisationRule(KoreanLetter.Tieut, "th"),
                new InitialRomanisationRule(KoreanLetter.Pieup, "ph"),
                new InitialRomanisationRule(KoreanLetter.Hieut, "h")
            };

            MedialRomanisationRules = new MedialRomanisationRule[] {
                new MedialRomanisationRule(KoreanLetter.A, "a"),
                new MedialRomanisationRule(KoreanLetter.Ae, "ay"),
                new MedialRomanisationRule(KoreanLetter.Ya, "ya"),
                new MedialRomanisationRule(KoreanLetter.Yae, "yay"),
                new MedialRomanisationRule(KoreanLetter.Eo, "e"),
                new MedialRomanisationRule(KoreanLetter.E, "ey"),
                new MedialRomanisationRule(KoreanLetter.Yeo, "ye"),
                new MedialRomanisationRule(KoreanLetter.Ye, "yey"),
                new MedialRomanisationRule(KoreanLetter.O, "o"),
                new MedialRomanisationRule(KoreanLetter.Wa, "wa"),
                new MedialRomanisationRule(KoreanLetter.Wae, "way"),
                new MedialRomanisationRule(KoreanLetter.Oe, "oy"),
                new MedialRomanisationRule(KoreanLetter.Yo, "yo"),
                new MedialRomanisationRule(KoreanLetter.U, "u"),
                new MedialRomanisationRule(KoreanLetter.Wo, "we"),
                new MedialRomanisationRule(KoreanLetter.We, "wey"),
                new MedialRomanisationRule(KoreanLetter.Wi, "wi"),
                new MedialRomanisationRule(KoreanLetter.Yu, "yu"),
                new MedialRomanisationRule(KoreanLetter.Eu, "u"),
                new MedialRomanisationRule(KoreanLetter.Ui, "uy"),
                new MedialRomanisationRule(KoreanLetter.I, "i")
            };

            FinalRomanisationRules = new FinalRomanisationRule[] {
                new FinalRomanisationRule(KoreanLetter.GiyeokBatchim, "k"),
                new FinalRomanisationRule(KoreanLetter.SsangGiyeokBatchim, "kk"),
                new FinalRomanisationRule(KoreanLetter.GiyeokShiotBatchim, "ks"),
                new FinalRomanisationRule(KoreanLetter.NieunBatchim, "n"),
                new FinalRomanisationRule(KoreanLetter.NieunJieutBatchim, "nc"),
                new FinalRomanisationRule(KoreanLetter.NieunHieutBatchim, "nh"),
                new FinalRomanisationRule(KoreanLetter.DigeutBatchim, "t"),
                new FinalRomanisationRule(KoreanLetter.RieulBatchim, "l"),
                new FinalRomanisationRule(KoreanLetter.RieulGiyeokBatchim, "lk"),
                new FinalRomanisationRule(KoreanLetter.RieulMieumBatchim, "lm"),
                new FinalRomanisationRule(KoreanLetter.RieulBieupBatchim, "lp"),
                new FinalRomanisationRule(KoreanLetter.RieulShiotBatchim, "ls"),
                new FinalRomanisationRule(KoreanLetter.RieulTieutBatchim, "lth"),
                new FinalRomanisationRule(KoreanLetter.RieulPieupBatchim, "lph"),
                new FinalRomanisationRule(KoreanLetter.RieulHieutBatchim, "lh"),
                new FinalRomanisationRule(KoreanLetter.MieumBatchim, "m"),
                new FinalRomanisationRule(KoreanLetter.BieupBatchim, "p"),
                new FinalRomanisationRule(KoreanLetter.BieupShiotBatchim, "ps"),
                new FinalRomanisationRule(KoreanLetter.ShiotBatchim, "s"),
                new FinalRomanisationRule(KoreanLetter.SsangShiotBatchim, "ss"),
                new FinalRomanisationRule(KoreanLetter.IeungBatchim, "ng"),
                new FinalRomanisationRule(KoreanLetter.JieutBatchim, "c"),
                new FinalRomanisationRule(KoreanLetter.ChieutBatchim, "ch"),
                new FinalRomanisationRule(KoreanLetter.KieukBatchim, "kh"),
                new FinalRomanisationRule(KoreanLetter.TieutBatchim, "th"),
                new FinalRomanisationRule(KoreanLetter.PieupBatchim, "ph"),
                new FinalRomanisationRule(KoreanLetter.HieutBatchim, "h")
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

        public override string Romanise(KoreanLetter Jamo1)
        {
            throw new NotImplementedException();
        }
    }
}
