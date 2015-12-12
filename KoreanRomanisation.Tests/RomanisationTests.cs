using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KoreanRomanisation.Tests
{
    [TestClass]
   public  class RomanisationTests
    {
        private readonly Romanisation Romanisation1;

        public RomanisationTests() {
            Romanisation1 = new RevisedRomanisation();
        }

        [TestMethod]
        public void JamoCodesGaTest() {

            var Syllable1 = Romanisation1.JamoCodes('가');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesNaTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('나');

            Assert.AreEqual(2, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesDaTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('다');

            Assert.AreEqual(3, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesMaTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('마');

            Assert.AreEqual(6, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesBaTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('바');

            Assert.AreEqual(7, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesSaTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('사');

            Assert.AreEqual(9, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesATest()
        {

            var Syllable1 = Romanisation1.JamoCodes('아');

            Assert.AreEqual(11, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesJaTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('자');

            Assert.AreEqual(12, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesHaTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('하');

            Assert.AreEqual(18, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGeoTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('거');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(4, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGoTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('고');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(8, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGuTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('구');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(13, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGeuTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('그');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(18, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGiTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('기');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(20, Syllable1.Medial);
            Assert.AreEqual(0, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGakTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('각');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(1, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGanTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('간');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(4, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGat1Test()
        {

            var Syllable1 = Romanisation1.JamoCodes('갇');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(7, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGamTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('감');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(16, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGapTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('갑');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(17, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGat2Test()
        {

            var Syllable1 = Romanisation1.JamoCodes('갓');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(19, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGangTest()
        {

            var Syllable1 = Romanisation1.JamoCodes('강');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(21, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGat3Test()
        {

            var Syllable1 = Romanisation1.JamoCodes('갖');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(22, Syllable1.Final);
        }

        [TestMethod]
        public void JamoCodesGat4Test()
        {

            var Syllable1 = Romanisation1.JamoCodes('갛');

            Assert.AreEqual(0, Syllable1.Initial);
            Assert.AreEqual(0, Syllable1.Medial);
            Assert.AreEqual(27, Syllable1.Final);
        }
    }
}
