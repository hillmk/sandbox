using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(1 < 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(1 < 3);
        }

        [TestMethod]
        public void FailingTest()
        {
            Assert.IsTrue(1 > );
        }


    }
}
