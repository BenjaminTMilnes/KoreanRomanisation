using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class TupleList<T1, T2> : List<Tuple<T1, T2>>
    {
        public void Add(T1 Item1, T2 Item2)
        {
            Add(new Tuple<T1, T2>(Item1, Item2));
        }
    }

    public class RomanisationRuleList : TupleList<KoreanLetter, string>
    {
    }

    public class YaleRomanisation : Romanisation
    {
        private InitialRomanisationRule[] InitialRomanisationRules;
        private MedialRomanisationRule[] MedialRomanisationRules;
        private FinalRomanisationRule[] FinalRomanisationRules;

        public YaleRomanisation()
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

            InitialRomanisationRules = InitialRomanisationRulesList.Select(t => new InitialRomanisationRule(t.Item1, t.Item2)).ToArray();
            MedialRomanisationRules = MedialRomanisationRulesList.Select(t => new MedialRomanisationRule(t.Item1, t.Item2)).ToArray();
            FinalRomanisationRules = FinalRomanisationRulesList.Select(t => new FinalRomanisationRule(t.Item1, t.Item2)).ToArray();
        }

        public override string Romanise(KoreanSyllable Syllable1, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            StringBuilder1.Append(RomaniseInitial(Syllable1));
            StringBuilder1.Append(RomaniseMedial(Syllable1));
            StringBuilder1.Append(RomaniseFinal(Syllable1));

            return StringBuilder1.ToString();
        }

        private string RomaniseInitial(KoreanSyllable Syllable1)
        {
            return InitialRomanisationRules.First(r => r.Initial == Syllable1.Initial).Romanisation;
        }

        private string RomaniseMedial(KoreanSyllable Syllable1)
        {
            return MedialRomanisationRules.First(m => m.Jamo == Syllable1.Medial).Romanisation;
        }

        private string RomaniseFinal(KoreanSyllable Syllable1)
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
