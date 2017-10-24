using System;
using System.Linq;
using System.Text;

namespace KoreanRomanisation
{
    /// <summary>
    /// A class for romanising text according to the Revised Romanisation of Korean.
    /// </summary>
    public sealed class RevisedRomanisation : Romanisation
    {
        public RevisedRomanisation()
        {
            SetRules();
        }

        protected override void SetRules()
        {
            var InitialRomanisationRulesList = new RomanisationRuleList(){
                {KoreanLetter.Giyeok, "g"},
                {KoreanLetter.SsangGiyeok, "kk"},
                {KoreanLetter.Nieun, "n"},
                {KoreanLetter.Digeut, "d"},
                {KoreanLetter.SsangDigeut, "tt"},
                {KoreanLetter.Rieul, "r"},
                {KoreanLetter.Mieum, "m"},
                {KoreanLetter.Bieup, "b"},
                {KoreanLetter.SsangBieup, "pp"},
                {KoreanLetter.Shiot, "s"},
                {KoreanLetter.SsangShiot, "ss"},
                {KoreanLetter.Ieung, ""},
                {KoreanLetter.Jieut, "j"},
                {KoreanLetter.SsangJieut, "jj"},
                {KoreanLetter.Chieut, "ch"},
                {KoreanLetter.Kieuk, "k"},
                {KoreanLetter.Tieut, "t"},
                {KoreanLetter.Pieup, "p"},
                {KoreanLetter.Hieut, "h"}
            };

            var InitialPronunciationChangeRomanisationRulesList = new PronunciationChangeRomanisationRuleList(){
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Kieuk, "-k"},

                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Kieuk, "-k"},

                {KoreanLetter.NieunBatchim, KoreanLetter.Giyeok, "-g"},
                {KoreanLetter.NieunBatchim, KoreanLetter.Rieul, "l"},

                {KoreanLetter.DigeutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.DigeutBatchim, KoreanLetter.Tieut, "-t"},

                {KoreanLetter.RieulBatchim, KoreanLetter.Nieun, "l"},
                {KoreanLetter.RieulBatchim, KoreanLetter.Rieul, "l"},

                {KoreanLetter.MieumBatchim, KoreanLetter.Rieul, "n"},

                {KoreanLetter.BieupBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.BieupBatchim, KoreanLetter.Pieup, "-p"},

                {KoreanLetter.ShiotBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.ShiotBatchim, KoreanLetter.Tieut, "-t"},

                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Tieut, "-t"},

                {KoreanLetter.IeungBatchim, KoreanLetter.Ieung, "-"},
                {KoreanLetter.IeungBatchim, KoreanLetter.Rieul, "n"},

                {KoreanLetter.JieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.JieutBatchim, KoreanLetter.Tieut, "-t"},

                {KoreanLetter.ChieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.ChieutBatchim, KoreanLetter.Tieut, "-t"},

                {KoreanLetter.KieukBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.KieukBatchim, KoreanLetter.Kieuk, "-k"},

                {KoreanLetter.TieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.TieutBatchim, KoreanLetter.Tieut, "-t"},

                {KoreanLetter.PieupBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.PieupBatchim, KoreanLetter.Pieup, "-p"},

                {KoreanLetter.HieutBatchim, KoreanLetter.Rieul, "n"},
                {KoreanLetter.HieutBatchim, KoreanLetter.Tieut, "-t"}
            };

            var MedialRomanisationRulesList = new RomanisationRuleList(){
                {KoreanLetter.A, "a"},
                {KoreanLetter.Ae, "ae"},
                {KoreanLetter.Ya, "ya"},
                {KoreanLetter.Yae, "yae"},
                {KoreanLetter.Eo, "eo"},
                {KoreanLetter.E, "e"},
                {KoreanLetter.Yeo, "yeo"},
                {KoreanLetter.Ye, "ye"},
                {KoreanLetter.O, "o"},
                {KoreanLetter.Wa, "wa"},
                {KoreanLetter.Wae, "wae"},
                {KoreanLetter.Oe, "oe"},
                {KoreanLetter.Yo, "yo"},
                {KoreanLetter.U, "u"},
                {KoreanLetter.Wo, "wo"},
                {KoreanLetter.We, "we"},
                {KoreanLetter.Wi, "wi"},
                {KoreanLetter.Yu, "yu"},
                {KoreanLetter.Eu, "eu"},
                {KoreanLetter.Ui, "ui"},
                {KoreanLetter.I, "i"}
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
                {KoreanLetter.HieutBatchim, "t"}
            };

            var FinalPronunciationChangeRomanisationRulesList = new PronunciationChangeRomanisationRuleList(){
                {KoreanLetter.GiyeokBatchim, KoreanLetter.SsangGiyeok , ""},
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Ieung , "g"},
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Nieun , "ng"},
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul , "ng"},
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Mieum , "ng"},

                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.SsangGiyeok , ""},
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Nieun , "ng"},
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul , "ng"},
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Mieum , "ng"},
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Ieung , "kk"},

                {KoreanLetter.NieunBatchim, KoreanLetter.Rieul , "l"},

                {KoreanLetter.DigeutBatchim, KoreanLetter.Nieun , "n"},
                {KoreanLetter.DigeutBatchim, KoreanLetter.SsangDigeut , ""},
                {KoreanLetter.DigeutBatchim, KoreanLetter.Rieul , "n"},
                {KoreanLetter.DigeutBatchim, KoreanLetter.Mieum , "n"},
                {KoreanLetter.DigeutBatchim, KoreanLetter.Ieung , "d"},

                {KoreanLetter.RieulBatchim, KoreanLetter.Ieung , "r"},

                {KoreanLetter.BieupBatchim, KoreanLetter.Ieung , "b"},
                {KoreanLetter.BieupBatchim, KoreanLetter.Nieun , "m"},
                {KoreanLetter.BieupBatchim, KoreanLetter.Rieul , "m"},
                {KoreanLetter.BieupBatchim, KoreanLetter.Mieum , "m"},
                {KoreanLetter.BieupBatchim, KoreanLetter.SsangBieup , ""},

                {KoreanLetter.ShiotBatchim, KoreanLetter.SsangDigeut , ""},
                {KoreanLetter.ShiotBatchim, KoreanLetter.Ieung , "s"},
                {KoreanLetter.ShiotBatchim, KoreanLetter.Nieun , "n"},
                {KoreanLetter.ShiotBatchim, KoreanLetter.Rieul , "n"},
                {KoreanLetter.ShiotBatchim, KoreanLetter.Mieum , "n"},
                {KoreanLetter.ShiotBatchim, KoreanLetter.Shiot , "s"},

                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Nieun , "n"},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.SsangDigeut , ""},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul , "n"},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Mieum , "n"},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Shiot , "s"},
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Ieung , "ss"},

                {KoreanLetter.JieutBatchim, KoreanLetter.Ieung , "j"},
                {KoreanLetter.JieutBatchim, KoreanLetter.Nieun , "n"},
                {KoreanLetter.JieutBatchim, KoreanLetter.SsangDigeut , ""},
                {KoreanLetter.JieutBatchim, KoreanLetter.Rieul , "n"},
                {KoreanLetter.JieutBatchim, KoreanLetter.Mieum , "n"},

                {KoreanLetter.ChieutBatchim, KoreanLetter.Nieun , "n"},
                {KoreanLetter.ChieutBatchim, KoreanLetter.SsangDigeut , ""},
                {KoreanLetter.ChieutBatchim, KoreanLetter.Rieul , "n"},
                {KoreanLetter.ChieutBatchim, KoreanLetter.Mieum , "n"},
                {KoreanLetter.ChieutBatchim, KoreanLetter.Ieung , "ch"},

                {KoreanLetter.KieukBatchim, KoreanLetter.SsangGiyeok , ""},
                {KoreanLetter.KieukBatchim, KoreanLetter.Nieun , "ng"},
                {KoreanLetter.KieukBatchim, KoreanLetter.Rieul , "ng"},
                {KoreanLetter.KieukBatchim, KoreanLetter.Mieum , "ng"},

                {KoreanLetter.TieutBatchim, KoreanLetter.SsangDigeut , ""},
                {KoreanLetter.TieutBatchim, KoreanLetter.Nieun , "n"},
                {KoreanLetter.TieutBatchim, KoreanLetter.Rieul , "n"},
                {KoreanLetter.TieutBatchim, KoreanLetter.Mieum , "n"},
                {KoreanLetter.TieutBatchim, KoreanLetter.Ieung , "t"},

                {KoreanLetter.PieupBatchim, KoreanLetter.Nieun , "m"},
                {KoreanLetter.PieupBatchim, KoreanLetter.Rieul , "m"},
                {KoreanLetter.PieupBatchim, KoreanLetter.Mieum , "m"},
                {KoreanLetter.PieupBatchim, KoreanLetter.SsangBieup , ""},

                {KoreanLetter.HieutBatchim, KoreanLetter.Ieung , "h"},
                {KoreanLetter.HieutBatchim, KoreanLetter.Nieun , "n"},
                {KoreanLetter.HieutBatchim, KoreanLetter.SsangDigeut , ""},
                {KoreanLetter.HieutBatchim, KoreanLetter.Rieul , "n"},
                {KoreanLetter.HieutBatchim, KoreanLetter.Mieum , "n"}
            };

            InitialRomanisationRules = InitialRomanisationRulesList.ToInitialRomanisationRules();
            InitialPronunciationChangeRomanisationRules = InitialPronunciationChangeRomanisationRulesList.ToInitialPronunciationChangeRomanisationRules();

            MedialRomanisationRules = MedialRomanisationRulesList.ToMedialRomanisationRules();

            FinalRomanisationRules = FinalRomanisationRulesList.ToFinalRomanisationRules();
            FinalPronunciationChangeRomanisationRules = FinalPronunciationChangeRomanisationRulesList.ToFinalPronunciationChangeRomanisationRules();
        }

        public override string RomaniseSyllable(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            StringBuilder1.Append(RomaniseInitial(Syllable, PrecedingSyllable, SucceedingSyllable));
            StringBuilder1.Append(RomaniseMedial(Syllable, PrecedingSyllable, SucceedingSyllable));
            StringBuilder1.Append(RomaniseFinal(Syllable, PrecedingSyllable, SucceedingSyllable));

            return StringBuilder1.ToString();
        }

        private string RomaniseInitial(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable, KoreanSyllable? SucceedingSyllable)
        {
            if (PrecedingSyllable != null)
            {
                var PronunciationChangeRomanisationRule = InitialPronunciationChangeRomanisationRules.FirstOrDefault(r => r.PrecedingFinal == PrecedingSyllable.Value.Final && r.Initial == Syllable.Initial);

                if (PronunciationChangeRomanisationRule != null)
                {
                    return PronunciationChangeRomanisationRule.Romanisation;
                }
            }

            if (UseSh && Syllable.Initial == KoreanLetter.Shiot && IsIMedial(Syllable.Medial))
            {
                return "sh";
            }
            if (UseSh && Syllable.Initial == KoreanLetter.SsangShiot && IsIMedial(Syllable.Medial))
            {
                return "ssh";
            }

            return InitialRomanisationRules.First(r => r.Initial == Syllable.Initial).Romanisation;
        }

        private string RomaniseMedial(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable, KoreanSyllable? SucceedingSyllable)
        {
            return MedialRomanisationRules.First(r => r.Medial == Syllable.Medial).Romanisation;
        }

        private string RomaniseFinal(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable, KoreanSyllable? SucceedingSyllable)
        {
            if (Syllable.HasFinal)
            {
                if (SucceedingSyllable != null)
                {
                    var PronunciationChangeRomanisationRule = FinalPronunciationChangeRomanisationRules.FirstOrDefault(r => r.Final == Syllable.Final && r.SucceedingInitial == SucceedingSyllable.Value.Initial);

                    if (PronunciationChangeRomanisationRule != null)
                    {
                        return PronunciationChangeRomanisationRule.Romanisation;
                    }
                }

                return FinalRomanisationRules.First(r => r.Final == Syllable.Final).Romanisation;
            }

            return "";
        }

        public override string RomaniseLetter(KoreanLetter Letter)
        {
            throw new NotImplementedException();
        }
    }
}
