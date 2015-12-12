using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public abstract class Romanisation
    {
        protected int FirstCode = 44032;
        protected int LastCode = 55203;

        protected int NumberOfInitialJamo = 19;
        protected int NumberOfMedialJamo = 21;
        protected int NumberOfFinalJamo = 28;

        public bool PreserveNonKoreanCharacters { get; set; }

        public Syllable JamoCodes(int CharacterCode)
        {
            if (CharacterCode >= FirstCode && CharacterCode <= LastCode)
            {
                int InitialJamoCode = 0;
                int MedialJamoCode = 0;
                int FinalJamoCode = 0;

                int CodeOffset = CharacterCode - FirstCode;

                InitialJamoCode = CodeOffset / (NumberOfMedialJamo * NumberOfFinalJamo);
                CodeOffset = CodeOffset % (NumberOfMedialJamo * NumberOfFinalJamo);

                MedialJamoCode = CodeOffset / NumberOfFinalJamo;
                CodeOffset = CodeOffset % NumberOfFinalJamo;

                FinalJamoCode = CodeOffset;

                return new Syllable(InitialJamoCode, MedialJamoCode, FinalJamoCode);
            }

            return null;
        }

        public Document GetDocument( string Text)
        {
            var Document1 = new Document();
            var KoreanText1 = new KoreanText();
            var NonKoreanText1 = new NonKoreanText();

            foreach(var Character in Text)
            {
                var Syllable = JamoCodes(Character);

                if (Syllable != null)
                {
                    if (NonKoreanText1.Content != "")
                    {
                        Document1.Text.Add(NonKoreanText1);
                        NonKoreanText1 = new NonKoreanText();
                    }

                    KoreanText1.Syllables.Add(Syllable);
                }
                else
                {
                    if (KoreanText1.Syllables.Any())
                    {
                        Document1.Text.Add(KoreanText1);
                        KoreanText1 = new KoreanText();
                    }

                    NonKoreanText1.Content += Character;
                }
            }

            if (NonKoreanText1.Content != "")
            {
                Document1.Text.Add(NonKoreanText1);
                NonKoreanText1 = new NonKoreanText();
            }

            if (KoreanText1.Syllables.Any())
            {
                Document1.Text.Add(KoreanText1);
                KoreanText1 = new KoreanText();
            }

            return Document1;
        }
    }
}
