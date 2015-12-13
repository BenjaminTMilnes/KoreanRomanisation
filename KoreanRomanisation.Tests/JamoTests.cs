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
            Assert.IsFalse(Jamo.IsJamo(0));
        }

        [TestMethod]
        public void IsJamo1Test()
        {
            Assert.IsFalse(Jamo.IsJamo(1));
        }

        [TestMethod]
        public void IsJamo100Test()
        {
            Assert.IsFalse(Jamo.IsJamo(100));
        }

        [TestMethod]
        public void IsJamo45000Test()
        {
            Assert.IsFalse(Jamo.IsJamo(45000));
        }

        [TestMethod]
        public void FromInitialCode0()
        {
            Assert.AreEqual(Jamo.Giyeok, Jamo.FromInitialCode(0));
        }

        [TestMethod]
        public void FromInitialCode1()
        {
            Assert.AreEqual(Jamo.SsangGiyeok, Jamo.FromInitialCode(1));
        }

        [TestMethod]
        public void FromInitialCode2()
        {
            Assert.AreEqual(Jamo.Nieun, Jamo.FromInitialCode(2));
        }

        [TestMethod]
        public void FromInitialCode18()
        {
            Assert.AreEqual(Jamo.Hieut, Jamo.FromInitialCode(18));
        }

        [TestMethod]
        public void FromFinalCode1()
        {
            Assert.AreEqual(Jamo.GiyeokBatchim, Jamo.FromFinalCode(1));
        }

        [TestMethod]
        public void FromFinalCode2()
        {
            Assert.AreEqual(Jamo.SsangGiyeokBatchim, Jamo.FromFinalCode(2));
        }

        [TestMethod]
        public void FromFinalCode3()
        {
            Assert.AreEqual(Jamo.GiyeokShiotBatchim, Jamo.FromFinalCode(3));
        }

        [TestMethod]
        public void FromFinalCode27()
        {
            Assert.AreEqual(Jamo.HieutBatchim, Jamo.FromFinalCode(27));
        }
    }
}
