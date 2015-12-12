using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KoreanRomanisation.Tests
{
    [TestClass]
    public class SimplifiedRomanisationTests
    {
        private readonly SimplifiedRomanisation SimplifiedRomanisation1;

        public SimplifiedRomanisationTests()
        {
            SimplifiedRomanisation1 = new SimplifiedRomanisation();
        }

        [TestMethod]
        public void TestA()
        {
            Assert.AreEqual("a", SimplifiedRomanisation1.Romanise("아"));
        }

        [TestMethod]
        public void TestEo()
        {
            Assert.AreEqual("o", SimplifiedRomanisation1.Romanise("어"));
        }

        [TestMethod]
        public void TestI()
        {
            Assert.AreEqual("i", SimplifiedRomanisation1.Romanise("이"));
        }

        [TestMethod]
        public void TestAe()
        {
            Assert.AreEqual("e", SimplifiedRomanisation1.Romanise("애"));
        }

        [TestMethod]
        public void TestE()
        {
            Assert.AreEqual("ei", SimplifiedRomanisation1.Romanise("에"));
        }

        [TestMethod]
        public void TestO()
        {
            Assert.AreEqual("o", SimplifiedRomanisation1.Romanise("오"));
        }

        [TestMethod]
        public void TestU()
        {
            Assert.AreEqual("oo", SimplifiedRomanisation1.Romanise("우"));
        }

        [TestMethod]
        public void TestEu()
        {
            Assert.AreEqual("u", SimplifiedRomanisation1.Romanise("으"));
        }

        [TestMethod]
        public void TestYa()
        {
            Assert.AreEqual("ya", SimplifiedRomanisation1.Romanise("야"));
        }

        [TestMethod]
        public void TestYeo()
        {
            Assert.AreEqual("yo", SimplifiedRomanisation1.Romanise("여"));
        }

        [TestMethod]
        public void TestYae()
        {
            Assert.AreEqual("ye", SimplifiedRomanisation1.Romanise("얘"));
        }

        [TestMethod]
        public void TestYe()
        {
            Assert.AreEqual("yei", SimplifiedRomanisation1.Romanise("예"));
        }

        [TestMethod]
        public void TestYo()
        {
            Assert.AreEqual("yo", SimplifiedRomanisation1.Romanise("요"));
        }

        [TestMethod]
        public void TestYu()
        {
            Assert.AreEqual("yoo", SimplifiedRomanisation1.Romanise("유"));
        }

        [TestMethod]
        public void TestWa()
        {
            Assert.AreEqual("wa", SimplifiedRomanisation1.Romanise("와"));
        }

        [TestMethod]
        public void TestWo()
        {
            Assert.AreEqual("wo", SimplifiedRomanisation1.Romanise("워"));
        }

        [TestMethod]
        public void TestWae()
        {
            Assert.AreEqual("we", SimplifiedRomanisation1.Romanise("왜"));
        }

        [TestMethod]
        public void TestWe()
        {
            Assert.AreEqual("wei", SimplifiedRomanisation1.Romanise("웨"));
        }

        [TestMethod]
        public void TestOe()
        {
            Assert.AreEqual("we", SimplifiedRomanisation1.Romanise("외"));
        }

        [TestMethod]
        public void TestUi()
        {
            Assert.AreEqual("ui", SimplifiedRomanisation1.Romanise("의"));
        }

        [TestMethod]
        public void TestWi()
        {
            Assert.AreEqual("wi", SimplifiedRomanisation1.Romanise("위"));
        }

        [TestMethod]
        public void TestGa()
        {
            Assert.AreEqual("ka", SimplifiedRomanisation1.Romanise("가"));
        }

        [TestMethod]
        public void TestKka()
        {
            Assert.AreEqual("kka", SimplifiedRomanisation1.Romanise("까"));
        }

        [TestMethod]
        public void TestNa()
        {
            Assert.AreEqual("na", SimplifiedRomanisation1.Romanise("나"));
        }

        [TestMethod]
        public void TestDa()
        {
            Assert.AreEqual("ta", SimplifiedRomanisation1.Romanise("다"));
        }

        [TestMethod]
        public void TestTta()
        {
            Assert.AreEqual("tta", SimplifiedRomanisation1.Romanise("따"));
        }

        [TestMethod]
        public void TestRa()
        {
            Assert.AreEqual("ra", SimplifiedRomanisation1.Romanise("라"));
        }

        [TestMethod]
        public void TestMa()
        {
            Assert.AreEqual("ma", SimplifiedRomanisation1.Romanise("마"));
        }

        [TestMethod]
        public void TestBa()
        {
            Assert.AreEqual("pa", SimplifiedRomanisation1.Romanise("바"));
        }

        [TestMethod]
        public void TestPpa()
        {
            Assert.AreEqual("ppa", SimplifiedRomanisation1.Romanise("빠"));
        }

        [TestMethod]
        public void TestSa()
        {
            Assert.AreEqual("sa", SimplifiedRomanisation1.Romanise("사"));
        }

        [TestMethod]
        public void TestSsa()
        {
            Assert.AreEqual("tsa", SimplifiedRomanisation1.Romanise("싸"));
        }

        [TestMethod]
        public void TestJa()
        {
            Assert.AreEqual("cha", SimplifiedRomanisation1.Romanise("자"));
        }

        [TestMethod]
        public void TestJja()
        {
            Assert.AreEqual("tcha", SimplifiedRomanisation1.Romanise("짜"));
        }

        [TestMethod]
        public void TestCha()
        {
            Assert.AreEqual("cha", SimplifiedRomanisation1.Romanise("차"));
        }

        [TestMethod]
        public void TestKa()
        {
            Assert.AreEqual("ka", SimplifiedRomanisation1.Romanise("카"));
        }

        [TestMethod]
        public void TestTa()
        {
            Assert.AreEqual("ta", SimplifiedRomanisation1.Romanise("타"));
        }

        [TestMethod]
        public void TestPa()
        {
            Assert.AreEqual("pa", SimplifiedRomanisation1.Romanise("파"));
        }

        [TestMethod]
        public void TestHa()
        {
            Assert.AreEqual("ha", SimplifiedRomanisation1.Romanise("하"));
        }

        [TestMethod]
        public void TestGak1()
        {
            Assert.AreEqual("kak", SimplifiedRomanisation1.Romanise("각"));
        }

        [TestMethod]
        public void TestGakk()
        {
            Assert.AreEqual("kak", SimplifiedRomanisation1.Romanise("갂"));
        }

        [TestMethod]
        public void TestGan()
        {
            Assert.AreEqual("kan", SimplifiedRomanisation1.Romanise("간"));
        }

        [TestMethod]
        public void TestGat1()
        {
            Assert.AreEqual("kat", SimplifiedRomanisation1.Romanise("갇"));
        }

        [TestMethod]
        public void TestGal()
        {
            Assert.AreEqual("kal", SimplifiedRomanisation1.Romanise("갈"));
        }

        [TestMethod]
        public void TestGam()
        {
            Assert.AreEqual("kam", SimplifiedRomanisation1.Romanise("감"));
        }

        [TestMethod]
        public void TestGap1()
        {
            Assert.AreEqual("kap", SimplifiedRomanisation1.Romanise("갑"));
        }

        [TestMethod]
        public void TestGat2()
        {
            Assert.AreEqual("kat", SimplifiedRomanisation1.Romanise("갓"));
        }

        [TestMethod]
        public void TestGat3()
        {
            Assert.AreEqual("kat", SimplifiedRomanisation1.Romanise("갔"));
        }

        [TestMethod]
        public void TestGang()
        {
            Assert.AreEqual("kang", SimplifiedRomanisation1.Romanise("강"));
        }

        [TestMethod]
        public void TestGat4()
        {
            Assert.AreEqual("kat", SimplifiedRomanisation1.Romanise("갖"));
        }

        [TestMethod]
        public void TestGat5()
        {
            Assert.AreEqual("kat", SimplifiedRomanisation1.Romanise("갗"));
        }

        [TestMethod]
        public void TestGak2()
        {
            Assert.AreEqual("kak", SimplifiedRomanisation1.Romanise("갘"));
        }

        [TestMethod]
        public void TestGat6()
        {
            Assert.AreEqual("kat", SimplifiedRomanisation1.Romanise("같"));
        }

        [TestMethod]
        public void TestGap2()
        {
            Assert.AreEqual("kap", SimplifiedRomanisation1.Romanise("갚"));
        }

        [TestMethod]
        public void TestGat7()
        {
            Assert.AreEqual("kat", SimplifiedRomanisation1.Romanise("갛"));
        }
    }
}
