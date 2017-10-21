using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KoreanRomanisation;

namespace KoreanRomanisation.TerminalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(args[1]))
            {
                throw new FileNotFoundException();
            }
            else
            {
                var FileText = File.ReadAllText(args[1]);

                var Romanisation1 = new RevisedRomanisation();

                var JamoCodes1 = new List<KoreanSyllable>();

                foreach (var Character in FileText)
                {
                    if (KoreanSyllable.IsAKoreanSyllable(Character))
                    {
                        JamoCodes1.Add(new KoreanSyllable(Character));
                    }
                }

                var NewFileText = string.Join(" ", JamoCodes1);

                File.WriteAllText(args[2], NewFileText);

                Console.WriteLine("File exists");
                Console.ReadLine();
            }
        }
    }
}
