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
                new InitialRomanisationRule(KoreanLetter.Giyeok, "k"),
                new InitialRomanisationRule(KoreanLetter.SsangGiyeok, "kk"),
                new InitialRomanisationRule(KoreanLetter.Nieun, "n"),
                new InitialRomanisationRule(KoreanLetter.Digeut, "t"),
                new InitialRomanisationRule(KoreanLetter.SsangDigeut, "tt"),
                new InitialRomanisationRule(KoreanLetter.Rieul, "r"),
                new InitialRomanisationRule(KoreanLetter.Mieum, "m"),
                new InitialRomanisationRule(KoreanLetter.Bieup, "p"),
                new InitialRomanisationRule(KoreanLetter.SsangBieup, "pp"),
                new InitialRomanisationRule(KoreanLetter.Shiot, "s"),
                new InitialRomanisationRule(KoreanLetter.SsangShiot, "ts"),
                new InitialRomanisationRule(KoreanLetter.Ieung, ""),
                new InitialRomanisationRule(KoreanLetter.Jieut, "ch"),
                new InitialRomanisationRule(KoreanLetter.SsangJieut, "tch"),
                new InitialRomanisationRule(KoreanLetter.Chieut, "ch"),
                new InitialRomanisationRule(KoreanLetter.Kieuk, "k"),
                new InitialRomanisationRule(KoreanLetter.Tieut, "t"),
                new InitialRomanisationRule(KoreanLetter.Pieup, "p"),
                new InitialRomanisationRule(KoreanLetter.Hieut, "h")
            };

            InitialPronunciationChangesRomanisationRules = new InitialPronunciationChangeRomanisationRule[] {
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Hieut, ""),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Hieut, ""),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.NieunBatchim, KoreanLetter.Giyeok, "'g"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.NieunBatchim, KoreanLetter.Digeut, "d"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.NieunBatchim, KoreanLetter.Rieul, "l"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.NieunBatchim, KoreanLetter.Bieup, "b"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.NieunBatchim, KoreanLetter.Jieut, "j"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.NieunBatchim, KoreanLetter.Hieut, ""),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Hieut, ""),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Giyeok, "g"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Nieun, "l"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Digeut, "d"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Rieul, "l"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Bieup, "b"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Ieung, ""),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Jieut, "j"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Hieut, "")
                ,
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.MieumBatchim, KoreanLetter.Giyeok, "g"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.MieumBatchim, KoreanLetter.Digeut, "d"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.MieumBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.MieumBatchim, KoreanLetter.Bieup, "b"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.MieumBatchim, KoreanLetter.Jieut, "j"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.MieumBatchim, KoreanLetter.Hieut, "")
                ,
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Hieut, "")
                ,
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Hieut, "")
                ,
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Hieut, "")
                ,
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.IeungBatchim, KoreanLetter.Giyeok, "g"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.IeungBatchim, KoreanLetter.Digeut, "d"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.IeungBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.IeungBatchim, KoreanLetter.Bieup, "b"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.IeungBatchim, KoreanLetter.Ieung, "'"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.IeungBatchim, KoreanLetter.Jieut, "j")
                ,
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Hieut, "")
                ,
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Hieut, "")
                ,
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.Hieut, "")
                ,
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.Hieut, "")
                ,
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.Hieut, "")
                ,
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Hieut, "")


            };

            MedialRomanisationRules = new MedialRomanisationRule[] {
                new MedialRomanisationRule(KoreanLetter.A, "a"),
                new MedialRomanisationRule(KoreanLetter.Ae, "e"),
                new MedialRomanisationRule(KoreanLetter.Ya, "ya"),
                new MedialRomanisationRule(KoreanLetter.Yae, "ye"),
                new MedialRomanisationRule(KoreanLetter.Eo, "o"),
                new MedialRomanisationRule(KoreanLetter.E, "ei"),
                new MedialRomanisationRule(KoreanLetter.Yeo, "yo"),
                new MedialRomanisationRule(KoreanLetter.Ye, "yei"),
                new MedialRomanisationRule(KoreanLetter.O, "o"),
                new MedialRomanisationRule(KoreanLetter.Wa, "wa"),
                new MedialRomanisationRule(KoreanLetter.Wae, "we"),
                new MedialRomanisationRule(KoreanLetter.Oe, "we"),
                new MedialRomanisationRule(KoreanLetter.Yo, "yo"),
                new MedialRomanisationRule(KoreanLetter.U, "oo"),
                new MedialRomanisationRule(KoreanLetter.Wo, "wo"),
                new MedialRomanisationRule(KoreanLetter.We, "wei"),
                new MedialRomanisationRule(KoreanLetter.Wi, "wi"),
                new MedialRomanisationRule(KoreanLetter.Yu, "yoo"),
                new MedialRomanisationRule(KoreanLetter.Eu, "u"),
                new MedialRomanisationRule(KoreanLetter.Ui, "ui"),
                new MedialRomanisationRule(KoreanLetter.I, "i")
            };

            FinalRomanisationRules = new FinalRomanisationRule[] {
                new FinalRomanisationRule(KoreanLetter.GiyeokBatchim, "k"),
                new FinalRomanisationRule(KoreanLetter.SsangGiyeokBatchim, "k"),
                new FinalRomanisationRule(KoreanLetter.NieunBatchim, "n"),
                new FinalRomanisationRule(KoreanLetter.DigeutBatchim, "t"),
                new FinalRomanisationRule(KoreanLetter.RieulBatchim, "l"),
                new FinalRomanisationRule(KoreanLetter.MieumBatchim, "m"),
                new FinalRomanisationRule(KoreanLetter.BieupBatchim, "p"),
                new FinalRomanisationRule(KoreanLetter.ShiotBatchim, "t"),
                new FinalRomanisationRule(KoreanLetter.SsangShiotBatchim, "t"),
                new FinalRomanisationRule(KoreanLetter.IeungBatchim, "ng"),
                new FinalRomanisationRule(KoreanLetter.JieutBatchim, "t"),
                new FinalRomanisationRule(KoreanLetter.ChieutBatchim, "t"),
                new FinalRomanisationRule(KoreanLetter.KieukBatchim, "k"),
                new FinalRomanisationRule(KoreanLetter.TieutBatchim, "t"),
                new FinalRomanisationRule(KoreanLetter.PieupBatchim, "p"),
                new FinalRomanisationRule(KoreanLetter.HieutBatchim, "t")
            };

            FinalPronunciationChangesRomanisationRules = new FinalPronunciationChangeRomanisationRule[] {
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.SsangGiyeok, ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Nieun, "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul, "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Mieum, "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Ieung, "g"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.SsangGiyeok, ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Nieun, "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul, "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Mieum, "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Ieung, "kk"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.NieunBatchim, KoreanLetter.Rieul, "l"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Nieun, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.SsangDigeut, ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Rieul, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Mieum, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Ieung, "d")
                ,
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Ieung, "r"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Hieut, "r")
                ,
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Nieun, "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Rieul, "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Mieum, "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.SsangBieup, ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Ieung, "b")
                ,
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Nieun, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.SsangDigeut, ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Rieul, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Mieum, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Shiot, "s"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Ieung, "s")
                ,
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Nieun, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.SsangDigeut, ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Mieum, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Shiot, "s"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Ieung, "ts")
                ,
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Nieun, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.SsangDigeut, ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Rieul, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Mieum, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Ieung, "j")
                ,
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Nieun, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.SsangDigeut, ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Rieul, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Mieum, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Ieung, "ch")
                ,
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.SsangGiyeok, ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.Nieun, "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.Rieul, "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.Mieum, "ng")
                ,
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.Nieun, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.SsangDigeut, ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.Rieul, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.Mieum, "n")
                ,
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.Nieun, "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.Rieul, "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.Mieum, "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.SsangBieup, "")
                ,
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Nieun, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.SsangDigeut, ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Rieul, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Mieum, "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Ieung, "h")

                            };

        }

        public override string Romanise(KoreanSyllable Syllable1, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            StringBuilder1.Append(RomaniseInitial(Syllable1, PrecedingSyllable, SucceedingSyllable));
            StringBuilder1.Append(RomaniseMedial(Syllable1, PrecedingSyllable, SucceedingSyllable));
            StringBuilder1.Append(RomaniseFinal(Syllable1, PrecedingSyllable, SucceedingSyllable));

            return StringBuilder1.ToString();
        }

        private string RomaniseInitial(KoreanSyllable Syllable1, KoreanSyllable? PrecedingSyllable, KoreanSyllable? SucceedingSyllable)
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
                var IsIMedial = (Syllable1.Medial == KoreanLetter.I || Syllable1.Medial == KoreanLetter.Ya || Syllable1.Medial == KoreanLetter.Yae || Syllable1.Medial == KoreanLetter.Yeo || Syllable1.Medial == KoreanLetter.Ye || Syllable1.Medial == KoreanLetter.Yo || Syllable1.Medial == KoreanLetter.Yu);

                if (UseSh && (Syllable1.Initial == KoreanLetter.Shiot || Syllable1.Initial == KoreanLetter.SsangShiot) && IsIMedial)
                {
                    return "sh";
                }
                else if ((Syllable1.Initial == KoreanLetter.Shiot || Syllable1.Initial == KoreanLetter.SsangShiot) && IsIMedial)
                {
                    return "s";
                }
            }

            return InitialRomanisationRules.First(r => r.Initial == Syllable1.Initial).Romanisation;
        }

        private string RomaniseMedial(KoreanSyllable Syllable1, KoreanSyllable? PrecedingSyllable, KoreanSyllable? SucceedingSyllable)
        {
            return MedialRomanisationRules.First(m => m.Jamo == Syllable1.Medial).Romanisation;
        }

        private string RomaniseFinal(KoreanSyllable Syllable1, KoreanSyllable? PrecedingSyllable, KoreanSyllable? SucceedingSyllable)
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

        public override string Romanise(KoreanLetter Jamo1)
        {
            throw new NotImplementedException();
        }
    }
}
