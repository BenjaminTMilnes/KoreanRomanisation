using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KoreanRomanisation.Tests
{
    [TestClass]
    public class SyllableTests
    {
        [TestMethod]
        public void JamoCodesGaTest()
        {
            var Syllable1 = new Syllable('가');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesNaTest()
        {
            var Syllable1 = new Syllable('나');

            Assert.AreEqual(KoreanLetter.Nieun, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesDaTest()
        {
            var Syllable1 = new Syllable('다');

            Assert.AreEqual(KoreanLetter.Digeut, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesMaTest()
        {
            var Syllable1 = new Syllable('마');

            Assert.AreEqual(KoreanLetter.Mieum, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesBaTest()
        {
            var Syllable1 = new Syllable('바');

            Assert.AreEqual(KoreanLetter.Bieup, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesSaTest()
        {
            var Syllable1 = new Syllable('사');

            Assert.AreEqual(KoreanLetter.Shiot, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesATest()
        {
            var Syllable1 = new Syllable('아');

            Assert.AreEqual(KoreanLetter.Ieung, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesJaTest()
        {
            var Syllable1 = new Syllable('자');

            Assert.AreEqual(KoreanLetter.Jieut, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesHaTest()
        {
            var Syllable1 = new Syllable('하');

            Assert.AreEqual(KoreanLetter.Hieut, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGeoTest()
        {
            var Syllable1 = new Syllable('거');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.Eo, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGoTest()
        {
            var Syllable1 = new Syllable('고');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.O, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGuTest()
        {
            var Syllable1 = new Syllable('구');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.U, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGeuTest()
        {
            var Syllable1 = new Syllable('그');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.Eu, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGiTest()
        {
            var Syllable1 = new Syllable('기');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.I, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGakTest()
        {
            var Syllable1 = new Syllable('각');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.GiyeokBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGanTest()
        {
            var Syllable1 = new Syllable('간');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.NieunBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGat1Test()
        {
            var Syllable1 = new Syllable('갇');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.DigeutBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGamTest()
        {
            var Syllable1 = new Syllable('감');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.MieumBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGapTest()
        {
            var Syllable1 = new Syllable('갑');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.BieupBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGat2Test()
        {
            var Syllable1 = new Syllable('갓');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.ShiotBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGangTest()
        {
            var Syllable1 = new Syllable('강');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.IeungBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGat3Test()
        {
            var Syllable1 = new Syllable('갖');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.JieutBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGat4Test()
        {
            var Syllable1 = new Syllable('갛');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.HieutBatchim, Syllable1.Final);
        }
    }
}
