using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KoreanRomanisation.Tests
{
    [TestClass]
    public class RevisedRomanisationTests
    {
        private readonly RevisedRomanisation RevisedRomanisation1;

        public RevisedRomanisationTests()
        {
            RevisedRomanisation1 = new RevisedRomanisation();
        }

        [TestMethod]
        public void TestA()
        {
            Assert.AreEqual("a", RevisedRomanisation1.Romanise("아"));
        }

        [TestMethod]
        public void TestEo()
        {
            Assert.AreEqual("eo", RevisedRomanisation1.Romanise("어"));
        }

        [TestMethod]
        public void TestI()
        {
            Assert.AreEqual("i", RevisedRomanisation1.Romanise("이"));
        }

        [TestMethod]
        public void TestAe()
        {
            Assert.AreEqual("ae", RevisedRomanisation1.Romanise("애"));
        }

        [TestMethod]
        public void TestE()
        {
            Assert.AreEqual("e", RevisedRomanisation1.Romanise("에"));
        }

        [TestMethod]
        public void TestO()
        {
            Assert.AreEqual("o", RevisedRomanisation1.Romanise("오"));
        }

        [TestMethod]
        public void TestU()
        {
            Assert.AreEqual("u", RevisedRomanisation1.Romanise("우"));
        }

        [TestMethod]
        public void TestEu()
        {
            Assert.AreEqual("eu", RevisedRomanisation1.Romanise("으"));
        }

        [TestMethod]
        public void TestYa()
        {
            Assert.AreEqual("ya", RevisedRomanisation1.Romanise("야"));
        }

        [TestMethod]
        public void TestYeo()
        {
            Assert.AreEqual("yeo", RevisedRomanisation1.Romanise("여"));
        }

        [TestMethod]
        public void TestYae()
        {
            Assert.AreEqual("yae", RevisedRomanisation1.Romanise("얘"));
        }

        [TestMethod]
        public void TestYe()
        {
            Assert.AreEqual("ye", RevisedRomanisation1.Romanise("예"));
        }

        [TestMethod]
        public void TestYo()
        {
            Assert.AreEqual("yo", RevisedRomanisation1.Romanise("요"));
        }

        [TestMethod]
        public void TestYu()
        {
            Assert.AreEqual("yu", RevisedRomanisation1.Romanise("유"));
        }

        [TestMethod]
        public void TestWa()
        {
            Assert.AreEqual("wa", RevisedRomanisation1.Romanise("와"));
        }

        [TestMethod]
        public void TestWo()
        {
            Assert.AreEqual("wo", RevisedRomanisation1.Romanise("워"));
        }

        [TestMethod]
        public void TestWae()
        {
            Assert.AreEqual("wae", RevisedRomanisation1.Romanise("왜"));
        }

        [TestMethod]
        public void TestWe()
        {
            Assert.AreEqual("we", RevisedRomanisation1.Romanise("웨"));
        }

        [TestMethod]
        public void TestOe()
        {
            Assert.AreEqual("oe", RevisedRomanisation1.Romanise("외"));
        }

        [TestMethod]
        public void TestUi()
        {
            Assert.AreEqual("ui", RevisedRomanisation1.Romanise("의"));
        }

        [TestMethod]
        public void TestWi()
        {
            Assert.AreEqual("wi", RevisedRomanisation1.Romanise("위"));
        }

        [TestMethod]
        public void TestGa()
        {
            Assert.AreEqual("ga", RevisedRomanisation1.Romanise("가"));
        }

        [TestMethod]
        public void TestKka()
        {
            Assert.AreEqual("kka", RevisedRomanisation1.Romanise("까"));
        }

        [TestMethod]
        public void TestNa()
        {
            Assert.AreEqual("na", RevisedRomanisation1.Romanise("나"));
        }

        [TestMethod]
        public void TestDa()
        {
            Assert.AreEqual("da", RevisedRomanisation1.Romanise("다"));
        }

        [TestMethod]
        public void TestTta()
        {
            Assert.AreEqual("tta", RevisedRomanisation1.Romanise("따"));
        }

        [TestMethod]
        public void TestRa()
        {
            Assert.AreEqual("ra", RevisedRomanisation1.Romanise("라"));
        }

        [TestMethod]
        public void TestMa()
        {
            Assert.AreEqual("ma", RevisedRomanisation1.Romanise("마"));
        }

        [TestMethod]
        public void TestBa()
        {
            Assert.AreEqual("ba", RevisedRomanisation1.Romanise("바"));
        }

        [TestMethod]
        public void TestPpa()
        {
            Assert.AreEqual("ppa", RevisedRomanisation1.Romanise("빠"));
        }

        [TestMethod]
        public void TestSa()
        {
            Assert.AreEqual("sa", RevisedRomanisation1.Romanise("사"));
        }

        [TestMethod]
        public void TestSsa()
        {
            Assert.AreEqual("ssa", RevisedRomanisation1.Romanise("싸"));
        }

        [TestMethod]
        public void TestJa()
        {
            Assert.AreEqual("ja", RevisedRomanisation1.Romanise("자"));
        }

        [TestMethod]
        public void TestJja()
        {
            Assert.AreEqual("jja", RevisedRomanisation1.Romanise("짜"));
        }

        [TestMethod]
        public void TestCha()
        {
            Assert.AreEqual("cha", RevisedRomanisation1.Romanise("차"));
        }

        [TestMethod]
        public void TestKa()
        {
            Assert.AreEqual("ka", RevisedRomanisation1.Romanise("카"));
        }

        [TestMethod]
        public void TestTa()
        {
            Assert.AreEqual("ta", RevisedRomanisation1.Romanise("타"));
        }

        [TestMethod]
        public void TestPa()
        {
            Assert.AreEqual("pa", RevisedRomanisation1.Romanise("파"));
        }

        [TestMethod]
        public void TestHa()
        {
            Assert.AreEqual("ha", RevisedRomanisation1.Romanise("하"));
        }

        [TestMethod]
        public void TestGak1()
        {
            Assert.AreEqual("gak", RevisedRomanisation1.Romanise("각"));
        }

        [TestMethod]
        public void TestGakk()
        {
            Assert.AreEqual("gak", RevisedRomanisation1.Romanise("갂"));
        }

        [TestMethod]
        public void TestGan()
        {
            Assert.AreEqual("gan", RevisedRomanisation1.Romanise("간"));
        }

        [TestMethod]
        public void TestGat1()
        {
            Assert.AreEqual("gat", RevisedRomanisation1.Romanise("갇"));
        }

        [TestMethod]
        public void TestGal()
        {
            Assert.AreEqual("gal", RevisedRomanisation1.Romanise("갈"));
        }

        [TestMethod]
        public void TestGam()
        {
            Assert.AreEqual("gam", RevisedRomanisation1.Romanise("감"));
        }

        [TestMethod]
        public void TestGap1()
        {
            Assert.AreEqual("gap", RevisedRomanisation1.Romanise("갑"));
        }

        [TestMethod]
        public void TestGat2()
        {
            Assert.AreEqual("gat", RevisedRomanisation1.Romanise("갓"));
        }

        [TestMethod]
        public void TestGat3()
        {
            Assert.AreEqual("gat", RevisedRomanisation1.Romanise("갔"));
        }

        [TestMethod]
        public void TestGang()
        {
            Assert.AreEqual("gang", RevisedRomanisation1.Romanise("강"));
        }

        [TestMethod]
        public void TestGat4()
        {
            Assert.AreEqual("gat", RevisedRomanisation1.Romanise("갖"));
        }

        [TestMethod]
        public void TestGat5()
        {
            Assert.AreEqual("gat", RevisedRomanisation1.Romanise("갗"));
        }

        [TestMethod]
        public void TestGak2()
        {
            Assert.AreEqual("gak", RevisedRomanisation1.Romanise("갘"));
        }

        [TestMethod]
        public void TestGat6()
        {
            Assert.AreEqual("gat", RevisedRomanisation1.Romanise("같"));
        }

        [TestMethod]
        public void TestGap2()
        {
            Assert.AreEqual("gap", RevisedRomanisation1.Romanise("갚"));
        }

        [TestMethod]
        public void TestGat7()
        {
            Assert.AreEqual("gat", RevisedRomanisation1.Romanise("갛"));
        }

        [TestMethod]
        public void TestShi()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("si", RevisedRomanisation1.Romanise("시"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("shi", RevisedRomanisation1.Romanise("시"));
        }

        [TestMethod]
        public void TestShya()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("sya", RevisedRomanisation1.Romanise("샤"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("shya", RevisedRomanisation1.Romanise("샤"));
        }

        [TestMethod]
        public void TestShyeo()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("syeo", RevisedRomanisation1.Romanise("셔"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("shyeo", RevisedRomanisation1.Romanise("셔"));
        }

        [TestMethod]
        public void TestShyo()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("syo", RevisedRomanisation1.Romanise("쇼"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("shyo", RevisedRomanisation1.Romanise("쇼"));
        }

        [TestMethod]
        public void TestShyu()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("syu", RevisedRomanisation1.Romanise("슈"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("shyu", RevisedRomanisation1.Romanise("슈"));
        }

        [TestMethod]
        public void TestShyae()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("syae", RevisedRomanisation1.Romanise("섀"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("shyae", RevisedRomanisation1.Romanise("섀"));
        }

        [TestMethod]
        public void TestShye()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("sye", RevisedRomanisation1.Romanise("셰"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("shye", RevisedRomanisation1.Romanise("셰"));
        }

        [TestMethod]
        public void TestSshi()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("ssi", RevisedRomanisation1.Romanise("씨"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("sshi", RevisedRomanisation1.Romanise("씨"));
        }

        [TestMethod]
        public void TestSshya()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("ssya", RevisedRomanisation1.Romanise("쌰"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("sshya", RevisedRomanisation1.Romanise("쌰"));
        }

        [TestMethod]
        public void TestSshyeo()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("ssyeo", RevisedRomanisation1.Romanise("쎠"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("sshyeo", RevisedRomanisation1.Romanise("쎠"));
        }

        [TestMethod]
        public void TestSshyo()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("ssyo", RevisedRomanisation1.Romanise("쑈"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("sshyo", RevisedRomanisation1.Romanise("쑈"));
        }

        [TestMethod]
        public void TestSshyu()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("ssyu", RevisedRomanisation1.Romanise("쓔"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("sshyu", RevisedRomanisation1.Romanise("쓔"));
        }

        [TestMethod]
        public void TestSshyae()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("ssyae", RevisedRomanisation1.Romanise("썌"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("sshyae", RevisedRomanisation1.Romanise("썌"));
        }

        [TestMethod]
        public void TestSshye()
        {
            RevisedRomanisation1.UseSh = false;
            Assert.AreEqual("ssye", RevisedRomanisation1.Romanise("쎼"));
            RevisedRomanisation1.UseSh = true;
            Assert.AreEqual("sshye", RevisedRomanisation1.Romanise("쎼"));
        }
    }
}
