using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KoreanRomanisation.Tests
{
    [TestClass]
    public class JamoTests
    {
        [TestMethod]
        public void IsJamo0Test()
        {
            Assert.IsFalse(KoreanLetter.IsAKoreanLetter(0));
        }

        [TestMethod]
        public void IsJamo1Test()
        {
            Assert.IsFalse(KoreanLetter.IsAKoreanLetter(1));
        }

        [TestMethod]
        public void IsJamo100Test()
        {
            Assert.IsFalse(KoreanLetter.IsAKoreanLetter(100));
        }

        [TestMethod]
        public void IsJamo45000Test()
        {
            Assert.IsFalse(KoreanLetter.IsAKoreanLetter(45000));
        }

        [TestMethod]
        public void FromInitialCode0()
        {
            Assert.AreEqual(KoreanLetter.Giyeok, KoreanLetter.GetKoreanLetterFromInitialCharacterCode(0));
        }

        [TestMethod]
        public void FromInitialCode1()
        {
            Assert.AreEqual(KoreanLetter.SsangGiyeok, KoreanLetter.GetKoreanLetterFromInitialCharacterCode(1));
        }

        [TestMethod]
        public void FromInitialCode2()
        {
            Assert.AreEqual(KoreanLetter.Nieun, KoreanLetter.GetKoreanLetterFromInitialCharacterCode(2));
        }

        [TestMethod]
        public void FromInitialCode18()
        {
            Assert.AreEqual(KoreanLetter.Hieut, KoreanLetter.GetKoreanLetterFromInitialCharacterCode(18));
        }

        [TestMethod]
        public void FromFinalCode1()
        {
            Assert.AreEqual(KoreanLetter.GiyeokBatchim, KoreanLetter.GetKoreanLetterFromFinalCharacterCode(1));
        }

        [TestMethod]
        public void FromFinalCode2()
        {
            Assert.AreEqual(KoreanLetter.SsangGiyeokBatchim, KoreanLetter.GetKoreanLetterFromFinalCharacterCode(2));
        }

        [TestMethod]
        public void FromFinalCode3()
        {
            Assert.AreEqual(KoreanLetter.GiyeokShiotBatchim, KoreanLetter.GetKoreanLetterFromFinalCharacterCode(3));
        }

        [TestMethod]
        public void FromFinalCode27()
        {
            Assert.AreEqual(KoreanLetter.HieutBatchim, KoreanLetter.GetKoreanLetterFromFinalCharacterCode(27));
        }
    }
}
