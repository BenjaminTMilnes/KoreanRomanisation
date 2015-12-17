using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KoreanRomanisation.Tests
{
    [TestClass]
    public class McCuneReischauerRomanisationTests
    {
        private readonly McCuneReischauerRomanisation McCuneReischauerRomanisation1;
      
        public McCuneReischauerRomanisationTests()
        {
            McCuneReischauerRomanisation1 = new McCuneReischauerRomanisation();
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

        [TestMethod]
        public void RomaniseGakga1()
        {
            Assert.AreEqual("kakka", McCuneReischauerRomanisation1.Romanise("각가"));
        }

        [TestMethod]
        public void RomaniseGakga2()
        {
            Assert.AreEqual("kakka", McCuneReischauerRomanisation1.Romanise("갂가"));
        }

        [TestMethod]
        public void RomaniseGanga1()
        {
            Assert.AreEqual("kan'ga", McCuneReischauerRomanisation1.Romanise("간가"));
        }

        [TestMethod]
        public void RomaniseGatga1()
        {
            Assert.AreEqual("katka", McCuneReischauerRomanisation1.Romanise("갇가"));
        }

        [TestMethod]
        public void RomaniseGalga1()
        {
            Assert.AreEqual("kalga", McCuneReischauerRomanisation1.Romanise("갈가"));
        }

        [TestMethod]
        public void RomaniseGamga()
        {
            Assert.AreEqual("kamga", McCuneReischauerRomanisation1.Romanise("감가"));
        }

        [TestMethod]
        public void RomaniseGapga()
        {
            Assert.AreEqual("kapka", McCuneReischauerRomanisation1.Romanise("갑가"));
        }

        [TestMethod]
        public void RomaniseGatga2()
        {
            Assert.AreEqual("katka", McCuneReischauerRomanisation1.Romanise("갓가"));
        }

        [TestMethod]
        public void RomaniseGatga3()
        {
            Assert.AreEqual("katka", McCuneReischauerRomanisation1.Romanise("갔가"));
        }

        [TestMethod]
        public void RomaniseGangga1()
        {
            Assert.AreEqual("kangga", McCuneReischauerRomanisation1.Romanise("강가"));
        }

        [TestMethod]
        public void RomaniseGatga4()
        {
            Assert.AreEqual("katka", McCuneReischauerRomanisation1.Romanise("갖가"));
        }

        [TestMethod]
        public void RomaniseGatga5()
        {
            Assert.AreEqual("katka", McCuneReischauerRomanisation1.Romanise("갗가"));
        }

        [TestMethod]
        public void RomaniseGakga3()
        {
            Assert.AreEqual("kakka", McCuneReischauerRomanisation1.Romanise("갘가"));
        }

        [TestMethod]
        public void RomaniseGatga6()
        {
            Assert.AreEqual("katka", McCuneReischauerRomanisation1.Romanise("같가"));
        }

        [TestMethod]
        public void RomaniseGapga1()
        {
            Assert.AreEqual("kapka", McCuneReischauerRomanisation1.Romanise("갚가"));
        }

        [TestMethod]
        public void RomaniseGatga7()
        {
            Assert.AreEqual("katka", McCuneReischauerRomanisation1.Romanise("갛가"));
        }

        [TestMethod]
        public void Gakka1()
        {
            Assert.AreEqual("kakka", McCuneReischauerRomanisation1.Romanise("각까"));
        }

        [TestMethod]
        public void Gakka2()
        {
            Assert.AreEqual("kakka", McCuneReischauerRomanisation1.Romanise("갂까"));
        }

        [TestMethod]
        public void Gankka1()
        {
            Assert.AreEqual("kankka", McCuneReischauerRomanisation1.Romanise("간까"));
        }

        [TestMethod]
        public void Gatkka1()
        {
            Assert.AreEqual("katkka", McCuneReischauerRomanisation1.Romanise("갇까"));
        }
        
        [TestMethod]
        public void Galkka1()
        {
            Assert.AreEqual("kalkka", McCuneReischauerRomanisation1.Romanise("갈까"));
        }

        [TestMethod]
        public void Gamkka1()
        {
            Assert.AreEqual("kamkka", McCuneReischauerRomanisation1.Romanise("감까"));
        }

        [TestMethod]
        public void Gapkka1()
        {
            Assert.AreEqual("kapkka", McCuneReischauerRomanisation1.Romanise("갑까"));
        }

        [TestMethod]
        public void Gatkka2()
        {
            Assert.AreEqual("katkka", McCuneReischauerRomanisation1.Romanise("갓까"));
        }

        [TestMethod]
        public void Gatkka3()
        {
            Assert.AreEqual("katkka", McCuneReischauerRomanisation1.Romanise("갔까"));
        }

        [TestMethod]
        public void Gangkka1()
        {
            Assert.AreEqual("kangkka", McCuneReischauerRomanisation1.Romanise("강까"));
        }

        [TestMethod]
        public void Gatkka4()
        {
            Assert.AreEqual("katkka", McCuneReischauerRomanisation1.Romanise("갖까"));
        }

        [TestMethod]
        public void Gatkka5()
        {
            Assert.AreEqual("katkka", McCuneReischauerRomanisation1.Romanise("갗까"));
        }

        [TestMethod]
        public void Gakka3()
        {
            Assert.AreEqual("kakka", McCuneReischauerRomanisation1.Romanise("갘까"));
        }

        [TestMethod]
        public void Gatkka6()
        {
            Assert.AreEqual("katkka", McCuneReischauerRomanisation1.Romanise("같까"));
        }

        [TestMethod]
        public void Gapkka2()
        {
            Assert.AreEqual("kapkka", McCuneReischauerRomanisation1.Romanise("갚까"));
        }

        [TestMethod]
        public void Gatkka7()
        {
            Assert.AreEqual("katkka", McCuneReischauerRomanisation1.Romanise("갛까"));
        }

        [TestMethod]
        public void Gangna1()
        {
            Assert.AreEqual("kangna", McCuneReischauerRomanisation1.Romanise("각나"));
        }

        [TestMethod]
        public void Gakna1()
        {
            Assert.AreEqual("kakna", McCuneReischauerRomanisation1.Romanise("갂나"));
        }

        [TestMethod]
        public void Ganna1()
        {
            Assert.AreEqual("kanna", McCuneReischauerRomanisation1.Romanise("간나"));
        }

        [TestMethod]
        public void Ganna2()
        {
            Assert.AreEqual("kanna", McCuneReischauerRomanisation1.Romanise("갇나"));
        }

        [TestMethod]
        public void Galla1()
        {
            Assert.AreEqual("kalla", McCuneReischauerRomanisation1.Romanise("갈나"));
        }

        [TestMethod]
        public void Gamna1()
        {
            Assert.AreEqual("kamna", McCuneReischauerRomanisation1.Romanise("감나"));
        }

        [TestMethod]
        public void Gamna2()
        {
            Assert.AreEqual("kamna", McCuneReischauerRomanisation1.Romanise("갑나"));
        }

        [TestMethod]
        public void Gatna1()
        {
            Assert.AreEqual("katna", McCuneReischauerRomanisation1.Romanise("갓나"));
        }

        [TestMethod]
        public void Gatna2()
        {
            Assert.AreEqual("katna", McCuneReischauerRomanisation1.Romanise("갔나"));
        }

        [TestMethod]
        public void Gangna2()
        {
            Assert.AreEqual("kangna", McCuneReischauerRomanisation1.Romanise("강나"));
        }

        [TestMethod]
        public void Gatna3()
        {
            Assert.AreEqual("katna", McCuneReischauerRomanisation1.Romanise("갖나"));
        }

        [TestMethod]
        public void Gatna4()
        {
            Assert.AreEqual("katna",  McCuneReischauerRomanisation1.Romanise("갗나"));
        }

        [TestMethod]
        public void Gakna2()
        {
            Assert.AreEqual("kakna", McCuneReischauerRomanisation1.Romanise("갘나"));
        }

        [TestMethod]
        public void Gatna5()
        {
            Assert.AreEqual("katna", McCuneReischauerRomanisation1.Romanise("같나"));
        }

        [TestMethod]
        public void Gapna1()
        {
            Assert.AreEqual("kapna", McCuneReischauerRomanisation1.Romanise("갚나"));
        }

        [TestMethod]
        public void Gatna6()
        {
            Assert.AreEqual("katna", McCuneReischauerRomanisation1.Romanise("갛나"));
        }

        [TestMethod]
        public void Gakda1()
        {
            Assert.AreEqual("kakta", McCuneReischauerRomanisation1.Romanise("각다"));
        }

        [TestMethod]
        public void Gakda2()
        {
            Assert.AreEqual("kakta", McCuneReischauerRomanisation1.Romanise("갂다"));
        }

        [TestMethod]
        public void Ganda1()
        {
            Assert.AreEqual("kanda", McCuneReischauerRomanisation1.Romanise("간다"));
        }

        [TestMethod]
        public void Gatda1()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("갇다"));
        }

        [TestMethod]
        public void Galda1()
        {
            Assert.AreEqual("kalda", McCuneReischauerRomanisation1.Romanise("갈다"));
        }

        [TestMethod]
        public void Gamda1()
        {
            Assert.AreEqual("kamda", McCuneReischauerRomanisation1.Romanise("감다"));
        }

        [TestMethod]
        public void Gapda1()
        {
            Assert.AreEqual("kapta", McCuneReischauerRomanisation1.Romanise("갑다"));
        }

        [TestMethod]
        public void Gatda2()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("갓다"));
        }

        [TestMethod]
        public void Gatda3()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("갔다"));
        }

        [TestMethod]
        public void Gangda1()
        {
            Assert.AreEqual("kangda", McCuneReischauerRomanisation1.Romanise("강다"));
        }

        [TestMethod]
        public void Gatda4()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("갖다"));
        }

        [TestMethod]
        public void Gatda5()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("갗다"));
        }

        [TestMethod]
        public void Gakda3()
        {
            Assert.AreEqual("kakta", McCuneReischauerRomanisation1.Romanise("갘다"));
        }

        [TestMethod]
        public void Gatda6()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("같다"));
        }

        [TestMethod]
        public void Gapda2()
        {
            Assert.AreEqual("kapta", McCuneReischauerRomanisation1.Romanise("갚다"));
        }

        [TestMethod]
        public void Gaktta1()
        {
            Assert.AreEqual("kaktta", McCuneReischauerRomanisation1.Romanise("각따"));
        }

        [TestMethod]
        public void Gaktta2()
        {
            Assert.AreEqual("kaktta", McCuneReischauerRomanisation1.Romanise("갂따"));
        }

        [TestMethod]
        public void Gantta1()
        {
            Assert.AreEqual("kantta", McCuneReischauerRomanisation1.Romanise("간따"));
        }

        [TestMethod]
        public void Gatta1()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("갇따"));
        }

        [TestMethod]
        public void Galtta1()
        {
            Assert.AreEqual("kaltta", McCuneReischauerRomanisation1.Romanise("갈따"));
        }

        [TestMethod]
        public void Gamtta1()
        {
            Assert.AreEqual("kamtta", McCuneReischauerRomanisation1.Romanise("감따"));
        }

        [TestMethod]
        public void Gaptta1()
        {
            Assert.AreEqual("kaptta", McCuneReischauerRomanisation1.Romanise("갑따"));
        }

        [TestMethod]
        public void Gatta2()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("갓따"));
        }

        [TestMethod]
        public void Gatta3()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("갔따"));
        }

        [TestMethod]
        public void Gangtta1()
        {
            Assert.AreEqual("kangtta", McCuneReischauerRomanisation1.Romanise("강따"));
        }

        [TestMethod]
        public void Gatta4()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("갖따"));
        }

        [TestMethod]
        public void Gatta5()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("갗따"));
        }

        [TestMethod]
        public void Gaktta3()
        {
            Assert.AreEqual("kaktta", McCuneReischauerRomanisation1.Romanise("갘따"));
        }

        [TestMethod]
        public void Gatta6()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("같따"));
        }

        [TestMethod]
        public void Gaptta2()
        {
            Assert.AreEqual("kaptta", McCuneReischauerRomanisation1.Romanise("갚따"));
        }

        [TestMethod]
        public void Gatta7()
        {
            Assert.AreEqual("katta", McCuneReischauerRomanisation1.Romanise("갛따"));
        }

        [TestMethod]
        public void Gangna3()
        {
            Assert.AreEqual("kangna", McCuneReischauerRomanisation1.Romanise("각라"));
        }

        [TestMethod]
        public void Gakna3()
        {
            Assert.AreEqual("kakna", McCuneReischauerRomanisation1.Romanise("갂라"));
        }

        [TestMethod]
        public void Galla2()
        {
            Assert.AreEqual("kalla", McCuneReischauerRomanisation1.Romanise("간라"));
        }

        [TestMethod]
        public void Ganna3()
        {
            Assert.AreEqual("kanna", McCuneReischauerRomanisation1.Romanise("갇라"));
        }

        [TestMethod]
        public void Galla3()
        {
            Assert.AreEqual("kalla", McCuneReischauerRomanisation1.Romanise("갈라"));
        }

        [TestMethod]
        public void Gamna3()
        {
            Assert.AreEqual("kamna", McCuneReischauerRomanisation1.Romanise("감라"));
        }

        [TestMethod]
        public void Gamna4()
        {
            Assert.AreEqual("kamna", McCuneReischauerRomanisation1.Romanise("갑라"));
        }

        [TestMethod]
        public void Ganna4()
        {
            Assert.AreEqual("kanna", McCuneReischauerRomanisation1.Romanise("갓라"));
        }

        [TestMethod]
        public void Ganna5()
        {
            Assert.AreEqual("kanna", McCuneReischauerRomanisation1.Romanise("갔라"));
        }

        [TestMethod]
        public void Gangna4()
        {
            Assert.AreEqual("kangna", McCuneReischauerRomanisation1.Romanise("강라"));
        }

        [TestMethod]
        public void Ganna6()
        {
            Assert.AreEqual("kanna", McCuneReischauerRomanisation1.Romanise("갖라"));
        }

        [TestMethod]
        public void Ganna7()
        {
            Assert.AreEqual("kanna", McCuneReischauerRomanisation1.Romanise("갗라"));
        }

        [TestMethod]
        public void Gangna5()
        {
            Assert.AreEqual("kangna", McCuneReischauerRomanisation1.Romanise("갘라"));
        }

        [TestMethod]
        public void Ganna8()
        {
            Assert.AreEqual("kanna", McCuneReischauerRomanisation1.Romanise("같라"));
        }

        [TestMethod]
        public void Gamna5()
        {
            Assert.AreEqual("kamna", McCuneReischauerRomanisation1.Romanise("갚라"));
        }

        [TestMethod]
        public void Ganna9()
        {
            Assert.AreEqual("kanna", McCuneReischauerRomanisation1.Romanise("갛라"));
        }

        [TestMethod]
        public void Gangma1()
        {
            Assert.AreEqual("kangma", McCuneReischauerRomanisation1.Romanise("각마"));
        }

        [TestMethod]
        public void Gangma2()
        {
            Assert.AreEqual("kangma", McCuneReischauerRomanisation1.Romanise("갂마"));
        }

        [TestMethod]
        public void Ganma1()
        {
            Assert.AreEqual("kanma", McCuneReischauerRomanisation1.Romanise("간마"));
        }

        [TestMethod]
        public void Ganma2()
        {
            Assert.AreEqual("kanma", McCuneReischauerRomanisation1.Romanise("갇마"));
        }

        [TestMethod]
        public void Ganma3()
        {
            Assert.AreEqual("kanma", McCuneReischauerRomanisation1.Romanise("갈마"));
        }

        [TestMethod]
        public void Gamma1()
        {
            Assert.AreEqual("kamma", McCuneReischauerRomanisation1.Romanise("감마"));
        }

        [TestMethod]
        public void Gamma2()
        {
            Assert.AreEqual("kamma", McCuneReischauerRomanisation1.Romanise("갑마"));
        }

        [TestMethod]
        public void Ganma4()
        {
            Assert.AreEqual("kanma", McCuneReischauerRomanisation1.Romanise("갓마"));
        }

        [TestMethod]
        public void Ganma5()
        {
            Assert.AreEqual("kanma", McCuneReischauerRomanisation1.Romanise("갔마"));
        }

        [TestMethod]
        public void Gangma3()
        {
            Assert.AreEqual("kangma", McCuneReischauerRomanisation1.Romanise("강마"));
        }

        [TestMethod]
        public void Ganma6()
        {
            Assert.AreEqual("kanma", McCuneReischauerRomanisation1.Romanise("갓마"));
        }

        [TestMethod]
        public void Ganma7()
        {
            Assert.AreEqual("kanma", McCuneReischauerRomanisation1.Romanise("갔마"));
        }

        [TestMethod]
        public void Ganma8()
        {
            Assert.AreEqual("kanma", McCuneReischauerRomanisation1.Romanise("갖마"));
        }

        [TestMethod]
        public void Gatma1()
        {
            Assert.AreEqual("katma", McCuneReischauerRomanisation1.Romanise("갗마"));
        }

        [TestMethod]
        public void Gakma1()
        {
            Assert.AreEqual("kakma", McCuneReischauerRomanisation1.Romanise("갘마"));
        }

        [TestMethod]
        public void Gatma2()
        {
            Assert.AreEqual("katma", McCuneReischauerRomanisation1.Romanise("같마"));
        }

        [TestMethod]
        public void Gapma1()
        {
            Assert.AreEqual("kapma", McCuneReischauerRomanisation1.Romanise("갚마"));
        }

        [TestMethod]
        public void Ganma9()
        {
            Assert.AreEqual("kanma", McCuneReischauerRomanisation1.Romanise("갛마"));
        }        
    }
}
