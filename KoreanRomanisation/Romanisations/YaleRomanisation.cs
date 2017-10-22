using System;
using System.Linq;
using System.Text;

namespace KoreanRomanisation
{
    /// <summary>
    /// A class for romanising text according to the Yale Romanisation of Korean.
    /// </summary>
    public sealed class YaleRomanisation : Romanisation
    {
        public YaleRomanisation()
        {
            SetRules();
        }

        protected override void SetRules()
        {
            var InitialRomanisationRulesList = new RomanisationRuleList() {
                { KoreanLetter.Giyeok, "k" },
                { KoreanLetter.SsangGiyeok, "kk" },
                { KoreanLetter.Nieun, "n" },
                { KoreanLetter.Digeut, "t" },
                { KoreanLetter.SsangDigeut, "tt" },
                { KoreanLetter.Rieul, "l" },
                { KoreanLetter.Mieum, "m" },
                { KoreanLetter.Bieup, "p" },
                { KoreanLetter.SsangBieup, "pp" },
                { KoreanLetter.Shiot, "s" },
                { KoreanLetter.SsangShiot, "ss" },
                { KoreanLetter.Ieung, "" },
                { KoreanLetter.Jieut, "c" },
                { KoreanLetter.SsangJieut, "cc" },
                { KoreanLetter.Chieut, "ch" },
                { KoreanLetter.Kieuk, "kh" },
                { KoreanLetter.Tieut, "th" },
                { KoreanLetter.Pieup, "ph" },
                { KoreanLetter.Hieut, "h" }
            };

            var MedialRomanisationRulesList = new RomanisationRuleList(){
                {KoreanLetter.A, "a"},
                {KoreanLetter.Ae, "ay"},
                {KoreanLetter.Ya, "ya"},
                {KoreanLetter.Yae, "yay"},
                {KoreanLetter.Eo, "e"},
                {KoreanLetter.E, "ey"},
                {KoreanLetter.Yeo, "ye"},
                {KoreanLetter.Ye, "yey"},
                {KoreanLetter.O, "o"},
                {KoreanLetter.Wa, "wa"},
                {KoreanLetter.Wae, "way"},
                {KoreanLetter.Oe, "oy"},
                {KoreanLetter.Yo, "yo"},
                {KoreanLetter.U, "u"},
                {KoreanLetter.Wo, "we"},
                {KoreanLetter.We, "wey"},
                {KoreanLetter.Wi, "wi"},
                {KoreanLetter.Yu, "yu"},
                {KoreanLetter.Eu, "u"},
                {KoreanLetter.Ui, "uy"},
                {KoreanLetter.I, "i" }
            };

            var FinalRomanisationRulesList = new RomanisationRuleList(){
                {KoreanLetter.GiyeokBatchim, "k"},
                {KoreanLetter.SsangGiyeokBatchim, "kk"},
                {KoreanLetter.GiyeokShiotBatchim, "ks"},
                {KoreanLetter.NieunBatchim, "n"},
                {KoreanLetter.NieunJieutBatchim, "nc"},
                {KoreanLetter.NieunHieutBatchim, "nh"},
                {KoreanLetter.DigeutBatchim, "t"},
                {KoreanLetter.RieulBatchim, "l"},
                {KoreanLetter.RieulGiyeokBatchim, "lk"},
                {KoreanLetter.RieulMieumBatchim, "lm"},
                {KoreanLetter.RieulBieupBatchim, "lp"},
                {KoreanLetter.RieulShiotBatchim, "ls"},
                {KoreanLetter.RieulTieutBatchim, "lth"},
                {KoreanLetter.RieulPieupBatchim, "lph"},
                {KoreanLetter.RieulHieutBatchim, "lh"},
                {KoreanLetter.MieumBatchim, "m"},
                {KoreanLetter.BieupBatchim, "p"},
                {KoreanLetter.BieupShiotBatchim, "ps"},
                {KoreanLetter.ShiotBatchim, "s"},
                {KoreanLetter.SsangShiotBatchim, "ss"},
                {KoreanLetter.IeungBatchim, "ng"},
                {KoreanLetter.JieutBatchim, "c"},
                {KoreanLetter.ChieutBatchim, "ch"},
                {KoreanLetter.KieukBatchim, "kh"},
                {KoreanLetter.TieutBatchim, "th"},
                {KoreanLetter.PieupBatchim, "ph"},
                {KoreanLetter.HieutBatchim, "h" }
            };

            InitialRomanisationRules = InitialRomanisationRulesList.ToInitialRomanisationRules();
            MedialRomanisationRules = MedialRomanisationRulesList.ToMedialRomanisationRules();
            FinalRomanisationRules = FinalRomanisationRulesList.ToFinalRomanisationRules();
        }

        public override string RomaniseSyllable(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            StringBuilder1.Append(RomaniseInitial(Syllable));
            StringBuilder1.Append(RomaniseMedial(Syllable));
            StringBuilder1.Append(RomaniseFinal(Syllable));

            return StringBuilder1.ToString();
        }

        private string RomaniseInitial(KoreanSyllable Syllable)
        {
            return InitialRomanisationRules.First(r => r.Initial == Syllable.Initial).Romanisation;
        }

        private string RomaniseMedial(KoreanSyllable Syllable)
        {
            return MedialRomanisationRules.First(r => r.Medial == Syllable.Medial).Romanisation;
        }

        private string RomaniseFinal(KoreanSyllable Syllable)
        {
            if (Syllable.HasFinal)
            {
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
