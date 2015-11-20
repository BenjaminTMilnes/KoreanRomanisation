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
        public List<RomanisationRule> Rules { get; set; }

        public RevisedRomanisation()
        {

            var assembly = Assembly.GetExecutingAssembly();
            var document = new XmlDocument();
            var stream = assembly.GetManifestResourceStream("KoreanRomanisation.RevisedRomanisation.xml");

            document.Load(stream);

            Rules = new List<RomanisationRule>();

            foreach (XmlNode element in document.SelectNodes("//rule"))
            {

                var Rule1 = new RomanisationRule(element.Attributes["jamo"].Value, element.Attributes["romanisation"].Value);

                Rules.Add(Rule1);

            }

        }

        public string Romanise(string Korean)
        {
            throw new NotImplementedException();
        }
    }
}
