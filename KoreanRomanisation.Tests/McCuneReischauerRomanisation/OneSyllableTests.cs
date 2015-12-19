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
