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

                var JamoCodes1 = new List< Syllable>();

                foreach (var Character in FileText)
                {
                    var JamoCodes2 = Romanisation1.JamoCodes(Character);

                    if (JamoCodes2 != null)
                    {
                        JamoCodes1.Add(JamoCodes2);
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
