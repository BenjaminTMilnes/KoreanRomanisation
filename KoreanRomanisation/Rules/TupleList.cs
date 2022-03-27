using System;
using System.Collections.Generic;
using System.Linq;

namespace KoreanRomanisation
{
    /// <summary>
    /// Represents a list of two-item tuples. Makes it easier to hard-code romanisation rules.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public class TupleList<T1, T2> : List<Tuple<T1, T2>>
    {
        public void Add(T1 Item1, T2 Item2)
        {
            Add(new Tuple<T1, T2>(Item1, Item2));
        }
    }

    /// <summary>
    /// Represents a list of three-item tuples. Makes it easier to hard-code romanisation rules.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    public class TupleList<T1, T2, T3> : List<Tuple<T1, T2, T3>>
    {
        public void Add(T1 Item1, T2 Item2, T3 Item3)
        {
            Add(new Tuple<T1, T2, T3>(Item1, Item2, Item3));
        }
    }

    public class RomanisationRuleList : TupleList<KoreanLetter, string>
    {
        public IEnumerable<InitialRomanisationRule> ToInitialRomanisationRules()
        {
            return this.Select(r => new InitialRomanisationRule(r.Item1, r.Item2));
        }

        public IEnumerable<MedialRomanisationRule> ToMedialRomanisationRules()
        {
            return this.Select(r => new MedialRomanisationRule(r.Item1, r.Item2));
        }

        public IEnumerable<FinalRomanisationRule> ToFinalRomanisationRules()
        {
            return this.Select(r => new FinalRomanisationRule(r.Item1, r.Item2));
        }
    }

    public class PronunciationChangeRomanisationRuleList : TupleList<KoreanLetter, KoreanLetter, string>
    {
        public IEnumerable<InitialPronunciationChangeRomanisationRule> ToInitialPronunciationChangeRomanisationRules()
        {
            return this.Select(r => new InitialPronunciationChangeRomanisationRule(r.Item1, r.Item2, r.Item3));
        }

        public IEnumerable<FinalPronunciationChangeRomanisationRule> ToFinalPronunciationChangeRomanisationRules()
        {
            return this.Select(r => new FinalPronunciationChangeRomanisationRule(r.Item1, r.Item2, r.Item3));
        }
    }
}
