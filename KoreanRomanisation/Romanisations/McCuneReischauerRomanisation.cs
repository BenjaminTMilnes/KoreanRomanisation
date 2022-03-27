using System;
using System.Linq;
using System.Text;

namespace KoreanRomanisation
{
    /// <summary>
    /// A class for romanising text according to the McCune-Reischauer Romanisation of Korean.
    /// </summary>
    public sealed class McCuneReischauerRomanisation : Romanisation
    {
        public McCuneReischauerRomanisation()
        {
            SetRules();
        }

        protected override void SetRules()
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
                {KoreanLetter.SsangShiot, "ss"},
                {KoreanLetter.Ieung, ""},
                {KoreanLetter.Jieut, "ch"},
                {KoreanLetter.SsangJieut, "tch"},
                {KoreanLetter.Chieut, "ch'"},
                {KoreanLetter.Kieuk, "k'"},
                {KoreanLetter.Tieut, "t'"},
                {KoreanLetter.Pieup, "p'"},
                {KoreanLetter.Hieut, "h"}
            };

            var InitialPronunciationChangeRomanisationRulesList = new PronunciationChangeRomanisationRuleList(){
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.GiyeokBatchim, KoreanLetter.SsangGiyeok, "k" },

                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.SsangGiyeok, "k" },
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul, "n" },

                {KoreanLetter.NieunBatchim, KoreanLetter.Giyeok, "'g" },
                {KoreanLetter.NieunBatchim, KoreanLetter.Digeut, "d" },
                {KoreanLetter.NieunBatchim, KoreanLetter.Rieul, "l" },
                {KoreanLetter.NieunBatchim, KoreanLetter.Bieup, "b" },
                {KoreanLetter.NieunBatchim, KoreanLetter.Jieut, "j" },

                {KoreanLetter.DigeutBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.DigeutBatchim, KoreanLetter.SsangDigeut, "t" },

                {KoreanLetter.RieulBatchim, KoreanLetter.Giyeok, "g" },
                {KoreanLetter.RieulBatchim, KoreanLetter.Nieun, "l" },
                {KoreanLetter.RieulBatchim, KoreanLetter.Digeut, "d" },
                {KoreanLetter.RieulBatchim, KoreanLetter.Rieul, "l" },
                {KoreanLetter.RieulBatchim, KoreanLetter.Bieup, "b" },
                {KoreanLetter.RieulBatchim, KoreanLetter.Jieut, "j" },

                {KoreanLetter.MieumBatchim, KoreanLetter.Giyeok, "g" },
                {KoreanLetter.MieumBatchim, KoreanLetter.Digeut, "d" },
                {KoreanLetter.MieumBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.MieumBatchim, KoreanLetter.Bieup, "b" },
                {KoreanLetter.MieumBatchim, KoreanLetter.Jieut, "j" },

                {KoreanLetter.BieupBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.BieupBatchim, KoreanLetter.SsangBieup, "p" },

                {KoreanLetter.ShiotBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.ShiotBatchim, KoreanLetter.SsangDigeut, "t" },

                {KoreanLetter.SsangShiotBatchim, KoreanLetter.SsangDigeut, "t" },
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul, "n" },

                {KoreanLetter.IeungBatchim, KoreanLetter.Giyeok, "g" },
                {KoreanLetter.IeungBatchim, KoreanLetter.Digeut, "d" },
                {KoreanLetter.IeungBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.IeungBatchim, KoreanLetter.Bieup, "b" },
                {KoreanLetter.IeungBatchim, KoreanLetter.Ieung, "'" },
                {KoreanLetter.IeungBatchim, KoreanLetter.Jieut, "j" },

                {KoreanLetter.JieutBatchim, KoreanLetter.SsangDigeut, "t" } ,
                {KoreanLetter.JieutBatchim, KoreanLetter.Rieul, "n" } ,
                {KoreanLetter.JieutBatchim, KoreanLetter.SsangJieut, "ch" } ,

                {KoreanLetter.ChieutBatchim, KoreanLetter.SsangDigeut, "t" } ,
                {KoreanLetter.ChieutBatchim, KoreanLetter.Rieul, "n" } ,

                {KoreanLetter.TieutBatchim, KoreanLetter.SsangDigeut, "t" } ,
                {KoreanLetter.TieutBatchim, KoreanLetter.Rieul, "n" } ,

                {KoreanLetter.KieukBatchim, KoreanLetter.SsangGiyeok, "k" } ,
                {KoreanLetter.KieukBatchim, KoreanLetter.Rieul, "n" } ,

                {KoreanLetter.PieupBatchim, KoreanLetter.Rieul, "n" } ,

                {KoreanLetter.HieutBatchim, KoreanLetter.SsangDigeut, "t" } ,
                {KoreanLetter.HieutBatchim, KoreanLetter.Rieul, "n" }  };

            var MedialRomanisationRulesList = new RomanisationRuleList(){
                {KoreanLetter.A, "a"},
                {KoreanLetter.Ae, "ae"},
                {KoreanLetter.Ya, "ya"},
                {KoreanLetter.Yae, "yae"},
                {KoreanLetter.Eo, "ŏ"},
                {KoreanLetter.E, "e"},
                {KoreanLetter.Yeo, "yŏ"},
                {KoreanLetter.Ye, "ye"},
                {KoreanLetter.O, "o"},
                {KoreanLetter.Wa, "wa"},
                {KoreanLetter.Wae, "wae"},
                {KoreanLetter.Oe, "oe"},
                {KoreanLetter.Yo, "yo"},
                {KoreanLetter.U, "u"},
                {KoreanLetter.Wo, "wŏ"},
                {KoreanLetter.We, "we"},
                {KoreanLetter.Wi, "wi"},
                {KoreanLetter.Yu, "yu"},
                {KoreanLetter.Eu, "ŭ"},
                {KoreanLetter.Ui, "ŭi"},
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

            var FinalPronunciationChangeRomanisationRulesList = new PronunciationChangeRomanisationRuleList() {

                {KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul, "ng" },
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Ieung, "g" },
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Nieun, "ng" },
                {KoreanLetter.GiyeokBatchim, KoreanLetter.Mieum, "ng" },

                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Nieun, "ng" },
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul, "ng" },
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Mieum, "ng" },
                {KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Ieung, "kk" },

                {KoreanLetter.NieunBatchim, KoreanLetter.Rieul, "l" },

                {KoreanLetter.DigeutBatchim, KoreanLetter.Nieun, "n" },
                {KoreanLetter.DigeutBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.DigeutBatchim, KoreanLetter.Mieum, "n" },
                {KoreanLetter.DigeutBatchim, KoreanLetter.Ieung, "d" },
                {KoreanLetter.DigeutBatchim, KoreanLetter.SsangJieut, "" },

                {KoreanLetter.RieulBatchim, KoreanLetter.Ieung, "r" },
                {KoreanLetter.RieulBatchim, KoreanLetter.Hieut, "r" },

                {KoreanLetter.BieupBatchim, KoreanLetter.Ieung, "b" },
                {KoreanLetter.BieupBatchim, KoreanLetter.Nieun, "m" },
                {KoreanLetter.BieupBatchim, KoreanLetter.Rieul, "m" },
                {KoreanLetter.BieupBatchim, KoreanLetter.Mieum, "m" },

                {KoreanLetter.ShiotBatchim, KoreanLetter.Nieun, "n" },
                {KoreanLetter.ShiotBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.ShiotBatchim, KoreanLetter.Mieum, "n" },
                {KoreanLetter.ShiotBatchim, KoreanLetter.Shiot, "s" },
                {KoreanLetter.ShiotBatchim, KoreanLetter.SsangShiot, "" },
                {KoreanLetter.ShiotBatchim, KoreanLetter.Ieung, "s" },
                {KoreanLetter.ShiotBatchim, KoreanLetter.SsangJieut, "" },

                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Nieun, "n" },
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Mieum, "n" },
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Shiot, "s" },
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.SsangShiot, "" },
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.Ieung, "ss" },
                {KoreanLetter.SsangShiotBatchim, KoreanLetter.SsangJieut, "" },

                {KoreanLetter.JieutBatchim, KoreanLetter.Nieun, "n" },
                {KoreanLetter.JieutBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.JieutBatchim, KoreanLetter.Mieum, "n" },
                {KoreanLetter.JieutBatchim, KoreanLetter.Ieung, "j" },

                {KoreanLetter.ChieutBatchim, KoreanLetter.Nieun, "n" },
                {KoreanLetter.ChieutBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.ChieutBatchim, KoreanLetter.Mieum, "n" },
                {KoreanLetter.ChieutBatchim, KoreanLetter.Ieung, "ch'" },
                {KoreanLetter.ChieutBatchim, KoreanLetter.SsangJieut, "" },

                {KoreanLetter.KieukBatchim, KoreanLetter.Nieun, "ng" },
                {KoreanLetter.KieukBatchim, KoreanLetter.Rieul, "ng" },
                {KoreanLetter.KieukBatchim, KoreanLetter.Mieum, "ng" },
                {KoreanLetter.KieukBatchim, KoreanLetter.Ieung, "k'" },

                {KoreanLetter.TieutBatchim, KoreanLetter.Nieun, "n" },
                {KoreanLetter.TieutBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.TieutBatchim, KoreanLetter.Mieum, "n" },
                {KoreanLetter.TieutBatchim, KoreanLetter.Ieung, "t'" },
                {KoreanLetter.TieutBatchim, KoreanLetter.SsangJieut, "" },

                {KoreanLetter.PieupBatchim, KoreanLetter.Nieun, "m" },
                {KoreanLetter.PieupBatchim, KoreanLetter.Rieul, "m" },
                {KoreanLetter.PieupBatchim, KoreanLetter.Mieum, "m" },
                {KoreanLetter.PieupBatchim, KoreanLetter.SsangBieup, "" },
                {KoreanLetter.PieupBatchim, KoreanLetter.Ieung, "p'" },

                {KoreanLetter.HieutBatchim, KoreanLetter.Nieun, "n" },
                {KoreanLetter.HieutBatchim, KoreanLetter.Rieul, "n" },
                {KoreanLetter.HieutBatchim, KoreanLetter.Mieum, "n" },
                {KoreanLetter.HieutBatchim, KoreanLetter.Ieung, "h" },
                {KoreanLetter.HieutBatchim, KoreanLetter.SsangJieut, "" }
            };

            InitialRomanisationRules = InitialRomanisationRulesList.ToInitialRomanisationRules();
            InitialPronunciationChangeRomanisationRules = InitialPronunciationChangeRomanisationRulesList.ToInitialPronunciationChangeRomanisationRules();

            MedialRomanisationRules = MedialRomanisationRulesList.ToMedialRomanisationRules();

            FinalRomanisationRules = FinalRomanisationRulesList.ToFinalRomanisationRules();
            FinalPronunciationChangeRomanisationRules = FinalPronunciationChangeRomanisationRulesList.ToFinalPronunciationChangeRomanisationRules();
        }

        public override string RomaniseSyllable(KoreanSyllable syllable, KoreanSyllable? precedingSyllable = null, KoreanSyllable? succeedingSyllable = null)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(RomaniseInitial(syllable, precedingSyllable, succeedingSyllable));
            stringBuilder.Append(RomaniseMedial(syllable, precedingSyllable, succeedingSyllable));
            stringBuilder.Append(RomaniseFinal(syllable, precedingSyllable, succeedingSyllable));

            return stringBuilder.ToString();
        }

        private string RomaniseInitial(KoreanSyllable syllable, KoreanSyllable? precedingSyllable, KoreanSyllable? succeedingSyllable)
        {
            // First check if the romanisation must change based on the preceding syllable. 

            if (precedingSyllable != null)
            {
                var pronunciationChangeRomanisationRule = InitialPronunciationChangeRomanisationRules.FirstOrDefault(r => r.PrecedingFinal == precedingSyllable.Value.Final && r.Initial == syllable.Initial);

                if (pronunciationChangeRomanisationRule != null)
                {
                    return pronunciationChangeRomanisationRule.Romanisation;
                }
            }

            // Then check if the initial should be romanised as sh or ssh, if the UseSh property is set to true, and the following medial is i.

            if (UseSh && syllable.Initial == KoreanLetter.Shiot && IsIMedial(syllable.Medial))
            {
                return "sh";
            }
            if (UseSh && syllable.Initial == KoreanLetter.SsangShiot && IsIMedial(syllable.Medial))
            {
                return "ssh";
            }

            // Otherwise use the default initial romanisation.

            return InitialRomanisationRules.First(r => r.Initial == syllable.Initial).Romanisation;
        }

        private string RomaniseMedial(KoreanSyllable syllable, KoreanSyllable? precedingSyllable, KoreanSyllable? succeedingSyllable)
        {
            // In the McCune-Reischauer system of romanisation, if an 에 (e) follows a syllable that ends in ㅏ (a) or ㅗ (o), it's romanised as ë, so as to distinguish it from syllables that end with ㅐ (ae) or ㅚ (oe).

            if (precedingSyllable != null && (precedingSyllable.Value.Medial == KoreanLetter.A || precedingSyllable.Value.Medial == KoreanLetter.O) && !precedingSyllable.Value.HasFinal && syllable.Initial == KoreanLetter.Ieung && syllable.Medial == KoreanLetter.E)
            {
                return "ë";
            }

            return MedialRomanisationRules.First(r => r.Medial == syllable.Medial).Romanisation;
        }

        private string RomaniseFinal(KoreanSyllable syllable, KoreanSyllable? precedingSyllable, KoreanSyllable? succeedingSyllable)
        {
            if (syllable.HasFinal)
            {
                // First check if the romanisation must change based on the succeeding syllable.

                if (succeedingSyllable != null)
                {
                    var pronunciationChangeRomanisationRule = FinalPronunciationChangeRomanisationRules.FirstOrDefault(r => r.Final == syllable.Final && r.SucceedingInitial == succeedingSyllable.Value.Initial);

                    if (pronunciationChangeRomanisationRule != null)
                    {
                        return pronunciationChangeRomanisationRule.Romanisation;
                    }
                }

                // Otherwise use the default final romanisation.

                return FinalRomanisationRules.First(r => r.Final == syllable.Final).Romanisation;
            }

            return "";
        }

        public override string RomaniseLetter(KoreanLetter letter)
        {
            throw new NotImplementedException();
        }
    }
}
