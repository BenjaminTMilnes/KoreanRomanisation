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

        public int[] JamoCodes(int CharacterCode)
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

                return new int[] { InitialJamoCode, MedialJamoCode, FinalJamoCode };
            }

            return null;
        }
    }
}
