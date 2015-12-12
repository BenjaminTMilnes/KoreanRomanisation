using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class Document
    {
        public IList<IText> Text { get; set; }

        public Document()
        {
            Text = new List<IText>();
        }
    }
}
