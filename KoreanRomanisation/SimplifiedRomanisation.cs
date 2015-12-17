using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class SimplifiedRomanisation : Romanisation
    {
        private InitialRomanisationRule[] InitialRomanisationRules;
        private InitialPronunciationChangeRomanisationRule[] InitialPronunciationChangesRomanisationRules;
        private MedialRomanisationRule[] MedialRomanisationRules;
        private FinalRomanisationRule[] FinalRomanisationRules;
        private FinalPronunciationChangeRomanisationRule[] FinalPronunciationChangesRomanisationRules;

        public SimplifiedRomanisation()
        {
            InitialRomanisationRules = new InitialRomanisationRule[] {
                new InitialRomanisationRule(Jamo.Giyeok, "k"),
                new InitialRomanisationRule(Jamo.SsangGiyeok, "kk"),
                new InitialRomanisationRule(Jamo.Nieun, "n"),
                new InitialRomanisationRule(Jamo.Digeut, "t"),
                new InitialRomanisationRule(Jamo.SsangDigeut, "tt"),
                new InitialRomanisationRule(Jamo.Rieul, "r"),
                new InitialRomanisationRule(Jamo.Mieum, "m"),
                new InitialRomanisationRule(Jamo.Bieup, "p"),
                new InitialRomanisationRule(Jamo.SsangBieup, "pp"),
                new InitialRomanisationRule(Jamo.Shiot, "s"),
                new InitialRomanisationRule(Jamo.SsangShiot, "ts"),
                new InitialRomanisationRule(Jamo.Ieung, ""),
                new InitialRomanisationRule(Jamo.Jieut, "ch"),
                new InitialRomanisationRule(Jamo.SsangJieut, "tch"),
                new InitialRomanisationRule(Jamo.Chieut, "ch"),
                new InitialRomanisationRule(Jamo.Kieuk, "k"),
                new InitialRomanisationRule(Jamo.Tieut, "t"),
                new InitialRomanisationRule(Jamo.Pieup, "p"),
                new InitialRomanisationRule(Jamo.Hieut, "h")
            };

            InitialPronunciationChangesRomanisationRules = new InitialPronunciationChangeRomanisationRule[] { };

            MedialRomanisationRules = new MedialRomanisationRule[] {
                new MedialRomanisationRule(Jamo.A, "a"),
                new MedialRomanisationRule(Jamo.Ae, "e"),
                new MedialRomanisationRule(Jamo.Ya, "ya"),
                new MedialRomanisationRule(Jamo.Yae, "ye"),
                new MedialRomanisationRule(Jamo.Eo, "o"),
                new MedialRomanisationRule(Jamo.E, "ei"),
                new MedialRomanisationRule(Jamo.Yeo, "yo"),
                new MedialRomanisationRule(Jamo.Ye, "yei"),
                new MedialRomanisationRule(Jamo.O, "o"),
                new MedialRomanisationRule(Jamo.Wa, "wa"),
                new MedialRomanisationRule(Jamo.Wae, "we"),
                new MedialRomanisationRule(Jamo.Oe, "we"),
                new MedialRomanisationRule(Jamo.Yo, "yo"),
                new MedialRomanisationRule(Jamo.U, "oo"),
                new MedialRomanisationRule(Jamo.Wo, "wo"),
                new MedialRomanisationRule(Jamo.We, "wei"),
                new MedialRomanisationRule(Jamo.Wi, "wi"),
                new MedialRomanisationRule(Jamo.Yu, "yoo"),
                new MedialRomanisationRule(Jamo.Eu, "u"),
                new MedialRomanisationRule(Jamo.Ui, "ui"),
                new MedialRomanisationRule(Jamo.I, "i")
            };

            FinalRomanisationRules = new FinalRomanisationRule[] {
                new FinalRomanisationRule(Jamo.GiyeokBatchim, "k"),
                new FinalRomanisationRule(Jamo.SsangGiyeokBatchim, "k"),
                new FinalRomanisationRule(Jamo.NieunBatchim, "n"),
                new FinalRomanisationRule(Jamo.DigeutBatchim, "t"),
                new FinalRomanisationRule(Jamo.RieulBatchim, "l"),
                new FinalRomanisationRule(Jamo.MieumBatchim, "m"),
                new FinalRomanisationRule(Jamo.BieupBatchim, "p"),
                new FinalRomanisationRule(Jamo.ShiotBatchim, "t"),
                new FinalRomanisationRule(Jamo.SsangShiotBatchim, "t"),
                new FinalRomanisationRule(Jamo.IeungBatchim, "ng"),
                new FinalRomanisationRule(Jamo.JieutBatchim, "t"),
                new FinalRomanisationRule(Jamo.ChieutBatchim, "t"),
                new FinalRomanisationRule(Jamo.KieukBatchim, "k"),
                new FinalRomanisationRule(Jamo.TieutBatchim, "t"),
                new FinalRomanisationRule(Jamo.PieupBatchim, "p"),
                new FinalRomanisationRule(Jamo.HieutBatchim, "t")
            };

            FinalPronunciationChangesRomanisationRules = new FinalPronunciationChangeRomanisationRule[] {
                            };

        }

        public override string Romanise(Syllable Syllable1, Syllable? PrecedingSyllable = null, Syllable? SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            StringBuilder1.Append(RomaniseInitial(Syllable1, PrecedingSyllable, SucceedingSyllable));
            StringBuilder1.Append(RomaniseMedial(Syllable1, PrecedingSyllable, SucceedingSyllable));
            StringBuilder1.Append(RomaniseFinal(Syllable1, PrecedingSyllable, SucceedingSyllable));

            return StringBuilder1.ToString();
        }

        private string RomaniseInitial(Syllable Syllable1, Syllable? PrecedingSyllable, Syllable? SucceedingSyllable)
        {
            if (PrecedingSyllable != null)
            {
                if (InitialPronunciationChangesRomanisationRules.Any(c => c.PrecedingFinal == PrecedingSyllable.Value.Final && c.Initial == Syllable1.Initial))
                {
                    return InitialPronunciationChangesRomanisationRules.First(c => c.PrecedingFinal == PrecedingSyllable.Value.Final && c.Initial == Syllable1.Initial).Romanisation;
                }
            }

            if (PrecedingSyllable == null)
            {
                var IsIMedial = (Syllable1.Medial == Jamo.I || Syllable1.Medial == Jamo.Ya || Syllable1.Medial == Jamo.Yae || Syllable1.Medial == Jamo.Yeo || Syllable1.Medial == Jamo.Ye || Syllable1.Medial == Jamo.Yo || Syllable1.Medial == Jamo.Yu);

                if (UseSh && (Syllable1.Initial == Jamo.Shiot || Syllable1.Initial == Jamo.SsangShiot) && IsIMedial)
                {
                    return "sh";
                }
            }

            return InitialRomanisationRules.First(r => r.Initial == Syllable1.Initial).Romanisation;
        }

        private string RomaniseMedial(Syllable Syllable1, Syllable? PrecedingSyllable, Syllable? SucceedingSyllable)
        {
            return MedialRomanisationRules.First(m => m.Jamo == Syllable1.Medial).Romanisation;
        }

        private string RomaniseFinal(Syllable Syllable1, Syllable? PrecedingSyllable, Syllable? SucceedingSyllable)
        {
            if (Syllable1.HasFinal)
            {
                if (SucceedingSyllable != null)
                {
                    if (FinalPronunciationChangesRomanisationRules.Any(c => c.Final == Syllable1.Final && c.SucceedingInitial == SucceedingSyllable.Value.Initial))
                    {
                        return FinalPronunciationChangesRomanisationRules.First(c => c.Final == Syllable1.Final && c.SucceedingInitial == SucceedingSyllable.Value.Initial).Romanisation;

                    }
                }

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
