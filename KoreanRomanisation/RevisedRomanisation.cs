using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml;

namespace KoreanRomanisation
{
    public class RevisedRomanisation : Romanisation, IRomanisation
    {
        public string Romanise(string Document)
        {
            throw new NotImplementedException();
        }

        public string Romanise(Syllable Syllable1, Syllable PrecedingSyllable = null, Syllable SucceedingSyllable = null)
        {
            throw new NotImplementedException();
        }
    }
}
