using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KoreanRomanisation.Tests
{
    [TestClass]
   public  class YaleRomanisationTests
    {
        private readonly YaleRomanisation YaleRomanisation1;

        public YaleRomanisationTests()
        {
            YaleRomanisation1 = new YaleRomanisation();
        }

        [TestMethod]
        public void TestA()
        {
            Assert.AreEqual("a", YaleRomanisation1.Romanise("아"));
        }

        [TestMethod]
        public void TestEo()
        {
            Assert.AreEqual("e", YaleRomanisation1.Romanise("어"));
        }

        [TestMethod]
        public void TestI()
        {
            Assert.AreEqual("i", YaleRomanisation1.Romanise("이"));
        }

        [TestMethod]
        public void TestAe()
        {
            Assert.AreEqual("ay", YaleRomanisation1.Romanise("애"));
        }

        [TestMethod]
        public void TestE()
        {
            Assert.AreEqual("ey", YaleRomanisation1.Romanise("에"));
        }

        [TestMethod]
        public void TestO()
        {
            Assert.AreEqual("o", YaleRomanisation1.Romanise("오"));
        }

        [TestMethod]
        public void TestU()
        {
            Assert.AreEqual("u", YaleRomanisation1.Romanise("우"));
        }

        [TestMethod]
        public void TestEu()
        {
            Assert.AreEqual("u", YaleRomanisation1.Romanise("으"));
        }

        [TestMethod]
        public void TestYa()
        {
            Assert.AreEqual("ya", YaleRomanisation1.Romanise("야"));
        }

        [TestMethod]
        public void TestYeo()
        {
            Assert.AreEqual("ye", YaleRomanisation1.Romanise("여"));
        }

        [TestMethod]
        public void TestYae()
        {
            Assert.AreEqual("yay", YaleRomanisation1.Romanise("얘"));
        }

        [TestMethod]
        public void TestYe()
        {
            Assert.AreEqual("yey", YaleRomanisation1.Romanise("예"));
        }

        [TestMethod]
        public void TestYo()
        {
            Assert.AreEqual("yo", YaleRomanisation1.Romanise("요"));
        }

        [TestMethod]
        public void TestYu()
        {
            Assert.AreEqual("yu", YaleRomanisation1.Romanise("유"));
        }

        [TestMethod]
        public void TestWa()
        {
            Assert.AreEqual("wa", YaleRomanisation1.Romanise("와"));
        }

        [TestMethod]
        public void TestWo()
        {
            Assert.AreEqual("we", YaleRomanisation1.Romanise("워"));
        }

        [TestMethod]
        public void TestWae()
        {
            Assert.AreEqual("way", YaleRomanisation1.Romanise("왜"));
        }

        [TestMethod]
        public void TestWe()
        {
            Assert.AreEqual("wey", YaleRomanisation1.Romanise("웨"));
        }

        [TestMethod]
        public void TestOe()
        {
            Assert.AreEqual("oy", YaleRomanisation1.Romanise("외"));
        }

        [TestMethod]
        public void TestUi()
        {
            Assert.AreEqual("uy", YaleRomanisation1.Romanise("의"));
        }

        [TestMethod]
        public void TestWi()
        {
            Assert.AreEqual("wi", YaleRomanisation1.Romanise("위"));
        }

        [TestMethod]
        public void TestGa()
        {
            Assert.AreEqual("ka", YaleRomanisation1.Romanise("가"));
        }

        [TestMethod]
        public void TestKka()
        {
            Assert.AreEqual("kka", YaleRomanisation1.Romanise("까"));
        }

        [TestMethod]
        public void TestNa()
        {
            Assert.AreEqual("na", YaleRomanisation1.Romanise("나"));
        }

        [TestMethod]
        public void TestDa()
        {
            Assert.AreEqual("ta", YaleRomanisation1.Romanise("다"));
        }

        [TestMethod]
        public void TestTta()
        {
            Assert.AreEqual("tta", YaleRomanisation1.Romanise("따"));
        }

        [TestMethod]
        public void TestRa()
        {
            Assert.AreEqual("la", YaleRomanisation1.Romanise("라"));
        }

        [TestMethod]
        public void TestMa()
        {
            Assert.AreEqual("ma", YaleRomanisation1.Romanise("마"));
        }

        [TestMethod]
        public void TestBa()
        {
            Assert.AreEqual("pa", YaleRomanisation1.Romanise("바"));
        }

        [TestMethod]
        public void TestPpa()
        {
            Assert.AreEqual("ppa", YaleRomanisation1.Romanise("빠"));
        }

        [TestMethod]
        public void TestSa()
        {
            Assert.AreEqual("sa", YaleRomanisation1.Romanise("사"));
        }

        [TestMethod]
        public void TestSsa()
        {
            Assert.AreEqual("ssa", YaleRomanisation1.Romanise("싸"));
        }

        [TestMethod]
        public void TestJa()
        {
            Assert.AreEqual("ca", YaleRomanisation1.Romanise("자"));
        }

        [TestMethod]
        public void TestJja()
        {
            Assert.AreEqual("cca", YaleRomanisation1.Romanise("짜"));
        }

        [TestMethod]
        public void TestCha()
        {
            Assert.AreEqual("cha", YaleRomanisation1.Romanise("차"));
        }

        [TestMethod]
        public void TestKa()
        {
            Assert.AreEqual("kha", YaleRomanisation1.Romanise("카"));
        }

        [TestMethod]
        public void TestTa()
        {
            Assert.AreEqual("tha", YaleRomanisation1.Romanise("타"));
        }

        [TestMethod]
        public void TestPa()
        {
            Assert.AreEqual("pha", YaleRomanisation1.Romanise("파"));
        }

        [TestMethod]
        public void TestHa()
        {
            Assert.AreEqual("ha", YaleRomanisation1.Romanise("하"));
        }

        [TestMethod]
        public void TestGak1()
        {
            Assert.AreEqual("kak", YaleRomanisation1.Romanise("각"));
        }

        [TestMethod]
        public void TestGakk()
        {
            Assert.AreEqual("kakk", YaleRomanisation1.Romanise("갂"));
        }

        [TestMethod]
        public void TestGan()
        {
            Assert.AreEqual("kan", YaleRomanisation1.Romanise("간"));
        }

        [TestMethod]
        public void TestGat1()
        {
            Assert.AreEqual("kat", YaleRomanisation1.Romanise("갇"));
        }

        [TestMethod]
        public void TestGal()
        {
            Assert.AreEqual("kal", YaleRomanisation1.Romanise("갈"));
        }

        [TestMethod]
        public void TestGam()
        {
            Assert.AreEqual("kam", YaleRomanisation1.Romanise("감"));
        }

        [TestMethod]
        public void TestGap1()
        {
            Assert.AreEqual("kap", YaleRomanisation1.Romanise("갑"));
        }

        [TestMethod]
        public void TestGat2()
        {
            Assert.AreEqual("kas", YaleRomanisation1.Romanise("갓"));
        }

        [TestMethod]
        public void TestGat3()
        {
            Assert.AreEqual("kass", YaleRomanisation1.Romanise("갔"));
        }

        [TestMethod]
        public void TestGang()
        {
            Assert.AreEqual("kang", YaleRomanisation1.Romanise("강"));
        }

        [TestMethod]
        public void TestGat4()
        {
            Assert.AreEqual("kac", YaleRomanisation1.Romanise("갖"));
        }

        [TestMethod]
        public void TestGat5()
        {
            Assert.AreEqual("kach", YaleRomanisation1.Romanise("갗"));
        }

        [TestMethod]
        public void TestGak2()
        {
            Assert.AreEqual("kakh", YaleRomanisation1.Romanise("갘"));
        }

        [TestMethod]
        public void TestGat6()
        {
            Assert.AreEqual("kath", YaleRomanisation1.Romanise("같"));
        }

        [TestMethod]
        public void TestGap2()
        {
            Assert.AreEqual("kaph", YaleRomanisation1.Romanise("갚"));
        }

        [TestMethod]
        public void TestGat7()
        {
            Assert.AreEqual("kah", YaleRomanisation1.Romanise("갛"));
        }
    }
}
