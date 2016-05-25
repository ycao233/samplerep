using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmallProject;
using SupportSampleProject;

namespace SmallProjectTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var appSettings = ConfigurationManager.AppSettings;
            Assert.AreEqual(appSettings["Name"], "Prawal");
            Assert.AreEqual(4, Class1.AddMethod(2, 2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            SupportClass cls = new SupportClass();

            Assert.AreEqual(cls.addTwo(2,2), Class1.AddMethod(2, 2));
        }

        [TestMethod]
        public void TestMethodWithChineseKeyboard开月在()
        {
            Assert.AreEqual(4, Class1.MultiplyMethod(2, 2));
        }

        [TestMethod]
        public void TestMethodWithChineseKeyboard2到后也()
        {
            Assert.AreEqual(4, Class1.MultiplyMethod(2, 2));
        }

        [TestMethod]
        public void TestMethodWithChineseCopyDoubleByte狜隣郎()
        {
            Assert.AreEqual(4, Class1.MultiplyMethod(2, 2));
        }

        [TestMethod]
        public void TestMethodWithChineseCopyFourByte䵯䵰䶴()
        {
            Assert.AreEqual(4, Class1.MultiplyMethod(2, 2));
        }

        [TestMethod]
        public void TestMethodWithTibetanCopyཉཪཱྋཇཉ()
        {
            Assert.AreEqual(4, Class1.MultiplyMethod(2, 2));
        }

        [TestMethod]
        public void TestMethodWithTibetanད༣མ༦ཡ༢()
        {
            Assert.AreEqual(4, Class1.MultiplyMethod(2, 2));
        }

        [TestMethod]
        public void TestMethodWithJPNKeyboardはぬぎ()
        {
            Assert.AreEqual(4, Class1.MultiplyMethod(2, 2));
        }

        [TestMethod]
        public void TestMethodWithArabicKeyboardلغبسعلا()
        {
            Assert.AreEqual(4, Class1.MultiplyMethod(2, 2));
        }

        [TestMethod]
        public void TestMethodWithGermanKeyboardÜßäö()
        {
            Assert.AreEqual(4, Class1.MultiplyMethod(2, 2));
        }

        [TestMethod]
        public void TestMethodWithChineseTaiwanKeyboard好你直()
        {
            Assert.AreEqual(4, Class1.MultiplyMethod(2, 2));
        }


    }
}
