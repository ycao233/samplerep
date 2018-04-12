
using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmallProject;
using SupportSampleProject;

namespace SmallProjectTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethodNew1()
        {
            //adfa
        }

        [TestMethod]
        public void TestMethodNew2()
        {
            SupportClass cls = new SupportClass();

            Assert.AreEqual(cls.addTwo(2,2), Class1.AddMethod(2, 2));
        }

    }
}
