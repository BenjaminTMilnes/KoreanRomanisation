using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KoreanRomanisation.Tests.McCuneReischauerRomanisation
{

    [TestClass]
    public class OneSyllableTests
    {
        private readonly KoreanRomanisation.McCuneReischauerRomanisation McCuneReischauerRomanisation1;

        public OneSyllableTests()
        {
            McCuneReischauerRomanisation1 = new KoreanRomanisation.McCuneReischauerRomanisation();
        }

        [TestMethod]
        public void TestA()
        {
            Assert.AreEqual("a", McCuneReischauerRomanisation1.Romanise("아"));
        }

        [TestMethod]
        public void TestEo()
        {
            Assert.AreEqual("ŏ", McCuneReischauerRomanisation1.Romanise("어"));
        }

        [TestMethod]
        public void TestI()
        {
            Assert.AreEqual("i", McCuneReischauerRomanisation1.Romanise("이"));
        }

        [TestMethod]
        public void TestAe()
        {
            Assert.AreEqual("ae", McCuneReischauerRomanisation1.Romanise("애"));
        }

        [TestMethod]
        public void TestE()
        {
            Assert.AreEqual("e", McCuneReischauerRomanisation1.Romanise("에"));
        }

        [TestMethod]
        public void TestO()
        {
            Assert.AreEqual("o", McCuneReischauerRomanisation1.Romanise("오"));
        }

        [TestMethod]
        public void TestU()
        {
            Assert.AreEqual("u", McCuneReischauerRomanisation1.Romanise("우"));
        }

        [TestMethod]
        public void TestEu()
        {
            Assert.AreEqual("ŭ", McCuneReischauerRomanisation1.Romanise("으"));
        }

        [TestMethod]
        public void TestYa()
        {
            Assert.AreEqual("ya", McCuneReischauerRomanisation1.Romanise("야"));
        }

        [TestMethod]
        public void TestYeo()
        {
            Assert.AreEqual("yŏ", McCuneReischauerRomanisation1.Romanise("여"));
        }

        [TestMethod]
        public void TestYae()
        {
            Assert.AreEqual("yae", McCuneReischauerRomanisation1.Romanise("얘"));
        }

        [TestMethod]
        public void TestYe()
        {
            Assert.AreEqual("ye", McCuneReischauerRomanisation1.Romanise("예"));
        }

        [TestMethod]
        public void TestYo()
        {
            Assert.AreEqual("yo", McCuneReischauerRomanisation1.Romanise("요"));
        }

        [TestMethod]
        public void TestYu()
        {
            Assert.AreEqual("yu", McCuneReischauerRomanisation1.Romanise("유"));
        }

        [TestMethod]
        public void TestWa()
        {
            Assert.AreEqual("wa", McCuneReischauerRomanisation1.Romanise("와"));
        }

        [TestMethod]
        public void TestWo()
        {
            Assert.AreEqual("wŏ", McCuneReischauerRomanisation1.Romanise("워"));
        }

        [TestMethod]
        public void TestWae()
        {
            Assert.AreEqual("wae", McCuneReischauerRomanisation1.Romanise("왜"));
        }

        [TestMethod]
        public void TestWe()
        {
            Assert.AreEqual("we", McCuneReischauerRomanisation1.Romanise("웨"));
        }

        [TestMethod]
        public void TestOe()
        {
            Assert.AreEqual("oe", McCuneReischauerRomanisation1.Romanise("외"));
        }

        [TestMethod]
        public void TestUi()
        {
            Assert.AreEqual("ŭi", McCuneReischauerRomanisation1.Romanise("의"));
        }

        [TestMethod]
        public void TestWi()
        {
            Assert.AreEqual("wi", McCuneReischauerRomanisation1.Romanise("위"));
        }

        [TestMethod]
        public void TestGa()
        {
            Assert.AreEqual("ka", McCuneReischauerRomanisation1.Romanise("가"));
        }

        [TestMethod]
        public void TestKka()
        {
            Assert.AreEqual("kka", McCuneReischauerRomanisation1.Romanise("까"));
        }

        [TestMethod]
        public void TestNa()
        {
            Assert.AreEqual("na", McCuneReischauerRomanisation1.Romanise("나"));
        }

        [TestMethod]
        public void TestDa()
        {
            Assert.AreEqual("ta", McCuneReischauerRomanisation1.Romanise("다"));
        }

        [TestMethod]
        public void TestTta()
        {
            Assert.AreEqual("tta", McCuneReischauerRomanisation1.Romanise("따"));
        }

        [TestMethod]
        public void TestRa()
        {
            Assert.AreEqual("ra", McCuneReischauerRomanisation1.Romanise("라"));
        }

        [TestMethod]
        public void TestMa()
        {
            Assert.AreEqual("ma", McCuneReischauerRomanisation1.Romanise("마"));
        }

        [TestMethod]
        public void TestBa()
        {
            Assert.AreEqual("pa", McCuneReischauerRomanisation1.Romanise("바"));
        }

        [TestMethod]
        public void TestPpa()
        {
            Assert.AreEqual("ppa", McCuneReischauerRomanisation1.Romanise("빠"));
        }

        [TestMethod]
        public void TestSa()
        {
            Assert.AreEqual("sa", McCuneReischauerRomanisation1.Romanise("사"));
        }

        [TestMethod]
        public void TestSsa()
        {
            Assert.AreEqual("ssa", McCuneReischauerRomanisation1.Romanise("싸"));
        }

        [TestMethod]
        public void TestJa()
        {
            Assert.AreEqual("cha", McCuneReischauerRomanisation1.Romanise("자"));
        }

        [TestMethod]
        public void TestJja()
        {
            Assert.AreEqual("tcha", McCuneReischauerRomanisation1.Romanise("짜"));
        }

        [TestMethod]
        public void TestCha()
        {
            Assert.AreEqual("ch'a", McCuneReischauerRomanisation1.Romanise("차"));
        }

        [TestMethod]
        public void TestKa()
        {
            Assert.AreEqual("k'a", McCuneReischauerRomanisation1.Romanise("카"));
        }

        [TestMethod]
        public void TestTa()
        {
            Assert.AreEqual("t'a", McCuneReischauerRomanisation1.Romanise("타"));
        }

        [TestMethod]
        public void TestPa()
        {
            Assert.AreEqual("p'a", McCuneReischauerRomanisation1.Romanise("파"));
        }

        [TestMethod]
        public void TestHa()
        {
            Assert.AreEqual("ha", McCuneReischauerRomanisation1.Romanise("하"));
        }

        [TestMethod]
        public void TestGak1()
        {
            Assert.AreEqual("kak", McCuneReischauerRomanisation1.Romanise("각"));
        }

        [TestMethod]
        public void TestGakk()
        {
            Assert.AreEqual("kak", McCuneReischauerRomanisation1.Romanise("갂"));
        }

        [TestMethod]
        public void TestGan()
        {
            Assert.AreEqual("kan", McCuneReischauerRomanisation1.Romanise("간"));
        }

        [TestMethod]
        public void TestGat1()
        {
            Assert.AreEqual("kat", McCuneReischauerRomanisation1.Romanise("갇"));
        }

        [TestMethod]
        public void TestGal()
        {
            Assert.AreEqual("kal", McCuneReischauerRomanisation1.Romanise("갈"));
        }

        [TestMethod]
        public void TestGam()
        {
            Assert.AreEqual("kam", McCuneReischauerRomanisation1.Romanise("감"));
        }

        [TestMethod]
        public void TestGap1()
        {
            Assert.AreEqual("kap", McCuneReischauerRomanisation1.Romanise("갑"));
        }

        [TestMethod]
        public void TestGat2()
        {
            Assert.AreEqual("kat", McCuneReischauerRomanisation1.Romanise("갓"));
        }

        [TestMethod]
        public void TestGat3()
        {
            Assert.AreEqual("kat", McCuneReischauerRomanisation1.Romanise("갔"));
        }

        [TestMethod]
        public void TestGang()
        {
            Assert.AreEqual("kang", McCuneReischauerRomanisation1.Romanise("강"));
        }

        [TestMethod]
        public void TestGat4()
        {
            Assert.AreEqual("kat", McCuneReischauerRomanisation1.Romanise("갖"));
        }

        [TestMethod]
        public void TestGat5()
        {
            Assert.AreEqual("kat", McCuneReischauerRomanisation1.Romanise("갗"));
        }

        [TestMethod]
        public void TestGak2()
        {
            Assert.AreEqual("kak", McCuneReischauerRomanisation1.Romanise("갘"));
        }

        [TestMethod]
        public void TestGat6()
        {
            Assert.AreEqual("kat", McCuneReischauerRomanisation1.Romanise("같"));
        }

        [TestMethod]
        public void TestGap2()
        {
            Assert.AreEqual("kap", McCuneReischauerRomanisation1.Romanise("갚"));
        }

        [TestMethod]
        public void TestGat7()
        {
            Assert.AreEqual("kat", McCuneReischauerRomanisation1.Romanise("갛"));
        }

        [TestMethod]
        public void TestShi()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("si", McCuneReischauerRomanisation1.Romanise("시"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("shi", McCuneReischauerRomanisation1.Romanise("시"));
        }

        [TestMethod]
        public void TestShya()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("sya", McCuneReischauerRomanisation1.Romanise("샤"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("shya", McCuneReischauerRomanisation1.Romanise("샤"));
        }

        [TestMethod]
        public void TestShyeo()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("syŏ", McCuneReischauerRomanisation1.Romanise("셔"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("shyŏ", McCuneReischauerRomanisation1.Romanise("셔"));
        }

        [TestMethod]
        public void TestShyo()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("syo", McCuneReischauerRomanisation1.Romanise("쇼"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("shyo", McCuneReischauerRomanisation1.Romanise("쇼"));
        }

        [TestMethod]
        public void TestShyu()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("syu", McCuneReischauerRomanisation1.Romanise("슈"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("shyu", McCuneReischauerRomanisation1.Romanise("슈"));
        }

        [TestMethod]
        public void TestShyae()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("syae", McCuneReischauerRomanisation1.Romanise("섀"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("shyae", McCuneReischauerRomanisation1.Romanise("섀"));
        }

        [TestMethod]
        public void TestShye()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("sye", McCuneReischauerRomanisation1.Romanise("셰"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("shye", McCuneReischauerRomanisation1.Romanise("셰"));
        }

        [TestMethod]
        public void TestSshi()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("ssi", McCuneReischauerRomanisation1.Romanise("씨"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("sshi", McCuneReischauerRomanisation1.Romanise("씨"));
        }

        [TestMethod]
        public void TestSshya()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("ssya", McCuneReischauerRomanisation1.Romanise("쌰"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("sshya", McCuneReischauerRomanisation1.Romanise("쌰"));
        }

        [TestMethod]
        public void TestSshyeo()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("ssyŏ", McCuneReischauerRomanisation1.Romanise("쎠"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("sshyŏ", McCuneReischauerRomanisation1.Romanise("쎠"));
        }

        [TestMethod]
        public void TestSshyo()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("ssyo", McCuneReischauerRomanisation1.Romanise("쑈"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("sshyo", McCuneReischauerRomanisation1.Romanise("쑈"));
        }

        [TestMethod]
        public void TestSshyu()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("ssyu", McCuneReischauerRomanisation1.Romanise("쓔"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("sshyu", McCuneReischauerRomanisation1.Romanise("쓔"));
        }

        [TestMethod]
        public void TestSshyae()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("ssyae", McCuneReischauerRomanisation1.Romanise("썌"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("sshyae", McCuneReischauerRomanisation1.Romanise("썌"));
        }

        [TestMethod]
        public void TestSshye()
        {
            McCuneReischauerRomanisation1.UseSh = false;
            Assert.AreEqual("ssye", McCuneReischauerRomanisation1.Romanise("쎼"));
            McCuneReischauerRomanisation1.UseSh = true;
            Assert.AreEqual("sshye", McCuneReischauerRomanisation1.Romanise("쎼"));
        }

    }
}
