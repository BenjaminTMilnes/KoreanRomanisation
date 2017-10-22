using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml;

namespace KoreanRomanisation
{
    public class RevisedRomanisation : Romanisation
    {
        private InitialRomanisationRule[] InitialRomanisationRules;
        private InitialPronunciationChangeRomanisationRule[] InitialPronunciationChangesRomanisationRules;
        private MedialRomanisationRule[] MedialRomanisationRules;
        private FinalRomanisationRule[] FinalRomanisationRules;
        private FinalPronunciationChangeRomanisationRule[] FinalPronunciationChangesRomanisationRules;

        public RevisedRomanisation()
        {
            InitialRomanisationRules = new InitialRomanisationRule[] {
                new InitialRomanisationRule(KoreanLetter.Giyeok, "g"),
                new InitialRomanisationRule(KoreanLetter.SsangGiyeok, "kk"),
                new InitialRomanisationRule(KoreanLetter.Nieun, "n"),
                new InitialRomanisationRule(KoreanLetter.Digeut, "d"),
                new InitialRomanisationRule(KoreanLetter.SsangDigeut, "tt"),
                new InitialRomanisationRule(KoreanLetter.Rieul, "r"),
                new InitialRomanisationRule(KoreanLetter.Mieum, "m"),
                new InitialRomanisationRule(KoreanLetter.Bieup, "b"),
                new InitialRomanisationRule(KoreanLetter.SsangBieup, "pp"),
                new InitialRomanisationRule(KoreanLetter.Shiot, "s"),
                new InitialRomanisationRule(KoreanLetter.SsangShiot, "ss"),
                new InitialRomanisationRule(KoreanLetter.Ieung, ""),
                new InitialRomanisationRule(KoreanLetter.Jieut, "j"),
                new InitialRomanisationRule(KoreanLetter.SsangJieut, "jj"),
                new InitialRomanisationRule(KoreanLetter.Chieut, "ch"),
                new InitialRomanisationRule(KoreanLetter.Kieuk, "k"),
                new InitialRomanisationRule(KoreanLetter.Tieut, "t"),
                new InitialRomanisationRule(KoreanLetter.Pieup, "p"),
                new InitialRomanisationRule(KoreanLetter.Hieut, "h")
            };

            InitialPronunciationChangesRomanisationRules = new InitialPronunciationChangeRomanisationRule[] {
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Kieuk, "-k"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Kieuk, "-k"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.NieunBatchim, KoreanLetter.Giyeok, "-g"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.NieunBatchim, KoreanLetter.Rieul, "l"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Tieut, "-t"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Nieun, "l"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Rieul, "l"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.MieumBatchim, KoreanLetter.Rieul, "n"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Pieup, "-p"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Tieut, "-t"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Tieut, "-t"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.IeungBatchim, KoreanLetter.Ieung, "-"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.IeungBatchim, KoreanLetter.Rieul, "n"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Tieut, "-t"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Tieut, "-t"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.Kieuk, "-k"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.Tieut, "-t"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.Pieup, "-p"),

                new InitialPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Rieul, "n"),
                new InitialPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Tieut, "-t")
            };

            MedialRomanisationRules = new MedialRomanisationRule[] {
                new MedialRomanisationRule(KoreanLetter.A, "a"),
                new MedialRomanisationRule(KoreanLetter.Ae, "ae"),
                new MedialRomanisationRule(KoreanLetter.Ya, "ya"),
                new MedialRomanisationRule(KoreanLetter.Yae, "yae"),
                new MedialRomanisationRule(KoreanLetter.Eo, "eo"),
                new MedialRomanisationRule(KoreanLetter.E, "e"),
                new MedialRomanisationRule(KoreanLetter.Yeo, "yeo"),
                new MedialRomanisationRule(KoreanLetter.Ye, "ye"),
                new MedialRomanisationRule(KoreanLetter.O, "o"),
                new MedialRomanisationRule(KoreanLetter.Wa, "wa"),
                new MedialRomanisationRule(KoreanLetter.Wae, "wae"),
                new MedialRomanisationRule(KoreanLetter.Oe, "oe"),
                new MedialRomanisationRule(KoreanLetter.Yo, "yo"),
                new MedialRomanisationRule(KoreanLetter.U, "u"),
                new MedialRomanisationRule(KoreanLetter.Wo, "wo"),
                new MedialRomanisationRule(KoreanLetter.We, "we"),
                new MedialRomanisationRule(KoreanLetter.Wi, "wi"),
                new MedialRomanisationRule(KoreanLetter.Yu, "yu"),
                new MedialRomanisationRule(KoreanLetter.Eu, "eu"),
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
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.SsangGiyeok , ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Ieung , "g"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Nieun , "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul , "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.GiyeokBatchim, KoreanLetter.Mieum , "ng"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.SsangGiyeok , ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Nieun , "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul , "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Mieum , "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Ieung , "kk"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.NieunBatchim, KoreanLetter.Rieul , "l"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Nieun , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.SsangDigeut , ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Rieul , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Mieum , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.DigeutBatchim, KoreanLetter.Ieung , "d"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.RieulBatchim, KoreanLetter.Ieung , "r"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Ieung , "b"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Nieun , "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Rieul , "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.Mieum , "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.BieupBatchim, KoreanLetter.SsangBieup , ""),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.SsangDigeut , ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Ieung , "s"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Nieun , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Rieul , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Mieum , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ShiotBatchim, KoreanLetter.Shiot , "s"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Nieun , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.SsangDigeut , ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Mieum , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Shiot , "s"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.SsangShiotBatchim, KoreanLetter.Ieung , "ss"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Ieung , "j"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Nieun , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.SsangDigeut , ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Rieul , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.JieutBatchim, KoreanLetter.Mieum , "n"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Nieun , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.SsangDigeut , ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Rieul , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Mieum , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.ChieutBatchim, KoreanLetter.Ieung , "ch"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.SsangGiyeok , ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.Nieun , "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.Rieul , "ng"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.KieukBatchim, KoreanLetter.Mieum , "ng"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.SsangDigeut , ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.Nieun , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.Rieul , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.Mieum , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.TieutBatchim, KoreanLetter.Ieung , "t"),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.Nieun , "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.Rieul , "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.Mieum , "m"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.PieupBatchim, KoreanLetter.SsangBieup , ""),

                new FinalPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Ieung , "h"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Nieun , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.SsangDigeut , ""),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Rieul , "n"),
                new FinalPronunciationChangeRomanisationRule(KoreanLetter.HieutBatchim, KoreanLetter.Mieum , "n")
                            };

        }

        public override string RomaniseSyllable(KoreanSyllable Syllable1, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null)
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

                if (UseSh && Syllable1.Initial == KoreanLetter.Shiot && IsIMedial)
                {
                    return "sh";
                }
                if (UseSh && Syllable1.Initial == KoreanLetter.SsangShiot && IsIMedial)
                {
                    return "ssh";
                }
            }

            return InitialRomanisationRules.First(r => r.Initial == Syllable1.Initial).Romanisation;
        }

        private string RomaniseMedial(KoreanSyllable Syllable1, KoreanSyllable? PrecedingSyllable, KoreanSyllable? SucceedingSyllable)
        {
            return MedialRomanisationRules.First(m => m.Medial == Syllable1.Medial).Romanisation;
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

        public override string RomaniseLetter(KoreanLetter Jamo1)
        {
            throw new NotImplementedException();
        }
    }
}
