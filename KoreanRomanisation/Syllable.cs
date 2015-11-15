﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public class Syllable
    {
        public int Initial { get; set; }
        public int Medial { get; set; }
        public int Final { get; set; }

        public Syllable(int Initial1, int Medial1, int Final1)
        {
            Initial = Initial1;
            Medial = Medial1;
            Final = Final1;
        }
    }
}
