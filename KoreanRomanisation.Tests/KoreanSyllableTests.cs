using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KoreanRomanisation.Tests
{
    /// <summary>
    /// A set of tests for the KoreanSyllable structure.
    /// </summary>
    [TestClass]
    public class KoreanSyllableTests
    {
        #region Initial Character Codes Tests

        [TestMethod]
        public void CharacterCodesGaTest()
        {
            var Syllable1 = new KoreanSyllable('가');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesNaTest()
        {
            var Syllable1 = new KoreanSyllable('나');

            Assert.AreEqual(KoreanLetter.Nieun, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesDaTest()
        {
            var Syllable1 = new KoreanSyllable('다');

            Assert.AreEqual(KoreanLetter.Digeut, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesMaTest()
        {
            var Syllable1 = new KoreanSyllable('마');

            Assert.AreEqual(KoreanLetter.Mieum, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesBaTest()
        {
            var Syllable1 = new KoreanSyllable('바');

            Assert.AreEqual(KoreanLetter.Bieup, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesSaTest()
        {
            var Syllable1 = new KoreanSyllable('사');

            Assert.AreEqual(KoreanLetter.Shiot, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesATest()
        {
            var Syllable1 = new KoreanSyllable('아');

            Assert.AreEqual(KoreanLetter.Ieung, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesJaTest()
        {
            var Syllable1 = new KoreanSyllable('자');

            Assert.AreEqual(KoreanLetter.Jieut, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesHaTest()
        {
            var Syllable1 = new KoreanSyllable('하');

            Assert.AreEqual(KoreanLetter.Hieut, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        #endregion

        #region Medial Character Codes Tests

        [TestMethod]
        public void CharacterCodesGeoTest()
        {
            var Syllable1 = new KoreanSyllable('거');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.Eo, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGoTest()
        {
            var Syllable1 = new KoreanSyllable('고');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.O, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGuTest()
        {
            var Syllable1 = new KoreanSyllable('구');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.U, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGeuTest()
        {
            var Syllable1 = new KoreanSyllable('그');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.Eu, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGiTest()
        {
            var Syllable1 = new KoreanSyllable('기');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.I, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.None, Syllable1.Final);
        }

        #endregion

        #region Final Character Codes Tests

        [TestMethod]
        public void CharacterCodesGakTest()
        {
            var Syllable1 = new KoreanSyllable('각');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.GiyeokBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGanTest()
        {
            var Syllable1 = new KoreanSyllable('간');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.NieunBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGat1Test()
        {
            var Syllable1 = new KoreanSyllable('갇');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.DigeutBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGamTest()
        {
            var Syllable1 = new KoreanSyllable('감');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.MieumBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGapTest()
        {
            var Syllable1 = new KoreanSyllable('갑');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.BieupBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGat2Test()
        {
            var Syllable1 = new KoreanSyllable('갓');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.ShiotBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGangTest()
        {
            var Syllable1 = new KoreanSyllable('강');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.IeungBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGat3Test()
        {
            var Syllable1 = new KoreanSyllable('갖');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.JieutBatchim, Syllable1.Final);
        }

        [TestMethod]
        public void CharacterCodesGat4Test()
        {
            var Syllable1 = new KoreanSyllable('갛');

            Assert.AreEqual(KoreanLetter.Giyeok, Syllable1.Initial);
            Assert.AreEqual(KoreanLetter.A, Syllable1.Medial);
            Assert.AreEqual(KoreanLetter.HieutBatchim, Syllable1.Final);
        }

        #endregion
    }
}
