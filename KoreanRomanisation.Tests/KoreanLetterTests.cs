using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KoreanRomanisation.Tests
{
    /// <summary>
    /// A set of tests for the KoreanLetter structure.
    /// </summary>
    [TestClass]
    public class KoreanLetterTests
    {
        #region IsAKoreanLetter() Tests

        [TestMethod]
        public void Is0AKoreanLetterTest()
        {
            Assert.IsFalse(KoreanLetter.IsAKoreanLetter(0));
        }

        [TestMethod]
        public void Is1AKoreanLetterTest()
        {
            Assert.IsFalse(KoreanLetter.IsAKoreanLetter(1));
        }

        [TestMethod]
        public void Is100AKoreanLetterTest()
        {
            Assert.IsFalse(KoreanLetter.IsAKoreanLetter(100));
        }

        [TestMethod]
        public void Is45000AKoreanLetterTest()
        {
            Assert.IsFalse(KoreanLetter.IsAKoreanLetter(45000));
        }

        #endregion

        #region GetKoreanLetterFromInitialCharacterCode() Tests

        [TestMethod]
        public void GetKoreanLetterFromInitialCharacterCode0Test()
        {
            Assert.AreEqual(KoreanLetter.Giyeok, KoreanLetter.GetKoreanLetterFromInitialCharacterCode(0));
        }

        [TestMethod]
        public void GetKoreanLetterFromInitialCharacterCode1Test()
        {
            Assert.AreEqual(KoreanLetter.SsangGiyeok, KoreanLetter.GetKoreanLetterFromInitialCharacterCode(1));
        }

        [TestMethod]
        public void GetKoreanLetterFromInitialCharacterCode2Test()
        {
            Assert.AreEqual(KoreanLetter.Nieun, KoreanLetter.GetKoreanLetterFromInitialCharacterCode(2));
        }

        [TestMethod]
        public void GetKoreanLetterFromInitialCharacterCode18Test()
        {
            Assert.AreEqual(KoreanLetter.Hieut, KoreanLetter.GetKoreanLetterFromInitialCharacterCode(18));
        }

        #endregion

        #region GetKoreanLetterFromFinalCharacterCode() Tests

        [TestMethod]
        public void GetKoreanLetterFromFinalCharacterCode1Test()
        {
            Assert.AreEqual(KoreanLetter.GiyeokBatchim, KoreanLetter.GetKoreanLetterFromFinalCharacterCode(1));
        }

        [TestMethod]
        public void GetKoreanLetterFromFinalCharacterCode2Test()
        {
            Assert.AreEqual(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.GetKoreanLetterFromFinalCharacterCode(2));
        }

        [TestMethod]
        public void GetKoreanLetterFromFinalCharacterCode3Test()
        {
            Assert.AreEqual(KoreanLetter.GiyeokShiotBatchim, KoreanLetter.GetKoreanLetterFromFinalCharacterCode(3));
        }

        [TestMethod]
        public void GetKoreanLetterFromFinalCharacterCode27Test()
        {
            Assert.AreEqual(KoreanLetter.HieutBatchim, KoreanLetter.GetKoreanLetterFromFinalCharacterCode(27));
        }

        #endregion
    }
}
