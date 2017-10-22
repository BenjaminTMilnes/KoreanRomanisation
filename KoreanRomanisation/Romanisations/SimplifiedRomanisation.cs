using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class SimplifiedRomanisation : Romanisation
    {
        public SimplifiedRomanisation()
        {
            var InitialRomanisationRulesList = new RomanisationRuleList(){
                {KoreanLetter.Giyeok, "k"},
                {KoreanLetter.SsangGiyeok, "kk"},
                {KoreanLetter.Nieun, "n"},
                {KoreanLetter.Digeut, "t"},
                {KoreanLetter.SsangDigeut, "tt"},
                {KoreanLetter.Rieul, "r"},
                {KoreanLetter.Mieum, "m"},
                {KoreanLetter.Bieup, "p"},
                {KoreanLetter.SsangBieup, "pp"},
                {KoreanLetter.Shiot, "s"},
                {KoreanLetter.SsangShiot, "ts"},
                {KoreanLetter.Ieung, ""},
                {KoreanLetter.Jieut, "ch"},
                {KoreanLetter.SsangJieut, "tch"},
                {KoreanLetter.Chieut, "ch"},
                {KoreanLetter.Kieuk, "k"},
                {KoreanLetter.Tieut, "t"},
                {KoreanLetter.Pieup, "p"},
                {KoreanLetter.Hieut, "h" }
            };

            var InitialPronunciationChangeRomanisationRulesList = new PronunciationChangeRomanisationRuleList(){
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Hieut, ""},

                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Hieut, ""},

                {KoreanLetter.NieunBatchim, KoreanLetter.Giyeok, "'g"},
                {KoreanLetter.NieunBatchim, KoreanLetter.Digeut, "d"},
                {KoreanLetter.NieunBatchim, KoreanLetter.Rieul, "l"},
                {KoreanLetter.NieunBatchim, KoreanLetter.Bieup, "b"},
                {KoreanLetter.NieunBatchim, KoreanLetter.Jieut, "j"},
                {KoreanLetter.NieunBatchim, KoreanLetter.Hieut, ""},

                {KoreanLetter.DigeutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.DigeutBatchim, KoreanLetter.Hieut, ""},

                {KoreanLetter.RieulBatchim, KoreanLetter.Giyeok, "g"},
                {KoreanLetter.RieulBatchim, KoreanLetter.Nieun, "l"},
                {KoreanLetter.RieulBatchim, KoreanLetter.Digeut, "d"},
                {KoreanLetter.RieulBatchim, KoreanLetter.Rieul, "l"},
                {KoreanLetter.RieulBatchim, KoreanLetter.Bieup, "b"},
                {KoreanLetter.RieulBatchim, KoreanLetter.Ieung, ""},
                {KoreanLetter.RieulBatchim, KoreanLetter.Jieut, "j"},
                {KoreanLetter.RieulBatchim, KoreanLetter.Hieut, "" }                ,

                {KoreanLetter.MieumBatchim, KoreanLetter.Giyeok, "g"},
                {KoreanLetter.MieumBatchim, KoreanLetter.Digeut, "d"},
                {KoreanLetter.MieumBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.MieumBatchim, KoreanLetter.Bieup, "b"},
                {KoreanLetter.MieumBatchim, KoreanLetter.Jieut, "j"},
                {KoreanLetter.MieumBatchim, KoreanLetter.Hieut, "" }                ,

                {KoreanLetter.BieupBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.BieupBatchim, KoreanLetter.Hieut, "" }                ,

                {KoreanLetter.ShiotBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.ShiotBatchim, KoreanLetter.Hieut, "" }                ,

                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Hieut, "" }                ,

                {KoreanLetter.IeungBatchim, KoreanLetter.Giyeok, "g"},
                {KoreanLetter.IeungBatchim, KoreanLetter.Digeut, "d"},
                {KoreanLetter.IeungBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.IeungBatchim, KoreanLetter.Bieup, "b"},
                {KoreanLetter.IeungBatchim, KoreanLetter.Ieung, "'"},
                {KoreanLetter.IeungBatchim, KoreanLetter.Jieut, "j" }                ,

                {KoreanLetter.JieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.JieutBatchim, KoreanLetter.Hieut, "" }                ,

                {KoreanLetter.ChieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.ChieutBatchim, KoreanLetter.Hieut, "" }                ,

                {KoreanLetter.KieukBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.KieukBatchim, KoreanLetter.Hieut, "" }                ,

                {KoreanLetter.TieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.TieutBatchim, KoreanLetter.Hieut, "" }                ,

                {KoreanLetter.PieupBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.PieupBatchim, KoreanLetter.Hieut, "" }                ,

                {KoreanLetter.HieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.HieutBatchim, KoreanLetter.Hieut, "" }

            };

            var MedialRomanisationRulesList = new RomanisationRuleList(){
                {KoreanLetter.A, "a"},
                {KoreanLetter.Ae, "e"},
                {KoreanLetter.Ya, "ya"},
                {KoreanLetter.Yae, "ye"},
                {KoreanLetter.Eo, "o"},
                {KoreanLetter.E, "ei"},
                {KoreanLetter.Yeo, "yo"},
                {KoreanLetter.Ye, "yei"},
                {KoreanLetter.O, "o"},
                {KoreanLetter.Wa, "wa"},
                {KoreanLetter.Wae, "we"},
                {KoreanLetter.Oe, "we"},
                {KoreanLetter.Yo, "yo"},
                {KoreanLetter.U, "oo"},
                {KoreanLetter.Wo, "wo"},
                {KoreanLetter.We, "wei"},
                {KoreanLetter.Wi, "wi"},
                {KoreanLetter.Yu, "yoo"},
                {KoreanLetter.Eu, "u"},
                {KoreanLetter.Ui, "ui"},
                {KoreanLetter.I, "i" }
            };

            var FinalRomanisationRulesList = new RomanisationRuleList(){
                {KoreanLetter.GiyeokBatchim, "k"},
                {KoreanLetter.SsangGiyeokBatchim, "k"},
                {KoreanLetter.NieunBatchim, "n"},
                {KoreanLetter.DigeutBatchim, "t"},
                {KoreanLetter.RieulBatchim, "l"},
                {KoreanLetter.MieumBatchim, "m"},
                {KoreanLetter.BieupBatchim, "p"},
                {KoreanLetter.ShiotBatchim, "t"},
                {KoreanLetter.SsangShiotBatchim, "t"},
                {KoreanLetter.IeungBatchim, "ng"},
                {KoreanLetter.JieutBatchim, "t"},
                {KoreanLetter.ChieutBatchim, "t"},
                {KoreanLetter.KieukBatchim, "k"},
                {KoreanLetter.TieutBatchim, "t"},
                {KoreanLetter.PieupBatchim, "p"},
                {KoreanLetter.HieutBatchim, "t" }
            };

            var FinalPronunciationChangeRomanisationRulesList = new PronunciationChangeRomanisationRuleList(){
                {KoreanLetter.GiyeokBatchim, KoreanLetter.SsangGiyeok, ""},
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Nieun, "ng"},
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul, "ng"},
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Mieum, "ng"},
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Ieung, "g"},

                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.SsangGiyeok, ""},
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Nieun, "ng"},
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul, "ng"},
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Mieum, "ng"},
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Ieung, "kk"},

                {KoreanLetter.NieunBatchim, KoreanLetter.Rieul, "l"},

                {KoreanLetter.DigeutBatchim, KoreanLetter.Nieun, "n"},
                {KoreanLetter.DigeutBatchim, KoreanLetter.SsangDigeut, ""},
                {KoreanLetter.DigeutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.DigeutBatchim, KoreanLetter.Mieum, "n"},
                {KoreanLetter.DigeutBatchim, KoreanLetter.Ieung, "d" },

                {KoreanLetter.RieulBatchim, KoreanLetter.Ieung, "r"},
                {KoreanLetter.RieulBatchim, KoreanLetter.Hieut, "r" },

                {KoreanLetter.BieupBatchim, KoreanLetter.Nieun, "m"},
                {KoreanLetter.BieupBatchim, KoreanLetter.Rieul, "m"},
                {KoreanLetter.BieupBatchim, KoreanLetter.Mieum, "m"},
                {KoreanLetter.BieupBatchim, KoreanLetter.SsangBieup, ""},
                {KoreanLetter.BieupBatchim, KoreanLetter.Ieung, "b" },

                {KoreanLetter.ShiotBatchim, KoreanLetter.Nieun, "n"},
                {KoreanLetter.ShiotBatchim, KoreanLetter.SsangDigeut, ""},
                {KoreanLetter.ShiotBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.ShiotBatchim, KoreanLetter.Mieum, "n"},
                {KoreanLetter.ShiotBatchim, KoreanLetter.Shiot, "s"},
                {KoreanLetter.ShiotBatchim, KoreanLetter.Ieung, "s" },

                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Nieun, "n"},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.SsangDigeut, ""},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Mieum, "n"},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Shiot, "s"},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Ieung, "ts" },

                {KoreanLetter.JieutBatchim, KoreanLetter.Nieun, "n"},
                {KoreanLetter.JieutBatchim, KoreanLetter.SsangDigeut, ""},
                {KoreanLetter.JieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.JieutBatchim, KoreanLetter.Mieum, "n"},
                {KoreanLetter.JieutBatchim, KoreanLetter.Ieung, "j" },

                {KoreanLetter.ChieutBatchim, KoreanLetter.Nieun, "n"},
                {KoreanLetter.ChieutBatchim, KoreanLetter.SsangDigeut, ""},
                {KoreanLetter.ChieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.ChieutBatchim, KoreanLetter.Mieum, "n"},
                {KoreanLetter.ChieutBatchim, KoreanLetter.Ieung, "ch" },

                {KoreanLetter.KieukBatchim, KoreanLetter.SsangGiyeok, ""},
                {KoreanLetter.KieukBatchim, KoreanLetter.Nieun, "ng"},
                {KoreanLetter.KieukBatchim, KoreanLetter.Rieul, "ng"},
                {KoreanLetter.KieukBatchim, KoreanLetter.Mieum, "ng" },

                {KoreanLetter.TieutBatchim, KoreanLetter.Nieun, "n"},
                {KoreanLetter.TieutBatchim, KoreanLetter.SsangDigeut, ""},
                {KoreanLetter.TieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.TieutBatchim, KoreanLetter.Mieum, "n" },

                {KoreanLetter.PieupBatchim, KoreanLetter.Nieun, "m"},
                {KoreanLetter.PieupBatchim, KoreanLetter.Rieul, "m"},
                {KoreanLetter.PieupBatchim, KoreanLetter.Mieum, "m"},
                {KoreanLetter.PieupBatchim, KoreanLetter.SsangBieup, "" },

                {KoreanLetter.HieutBatchim, KoreanLetter.Nieun, "n"},
                {KoreanLetter.HieutBatchim, KoreanLetter.SsangDigeut, ""},
                {KoreanLetter.HieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.HieutBatchim, KoreanLetter.Mieum, "n"},
                {KoreanLetter.HieutBatchim, KoreanLetter.Ieung, "h" }

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
