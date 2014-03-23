using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingAlgorithms;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VanillaTestCase()
        {
            PowerOfANumber test = new PowerOfANumber();
            double result = test.Pow(2, 10);
            Assert.AreEqual(Math.Pow(2, 10), result);
        }


        [TestMethod]
        public void NegativeExponentTestCase()
        {
            PowerOfANumber test = new PowerOfANumber();
            double result = test.Pow(2, -10);
            Assert.AreEqual(Math.Pow(2, -10), result);
        }

        [TestMethod]
        public void EdgeExponentTestCase()
        {
            PowerOfANumber test = new PowerOfANumber();
            double result = test.Pow(2000, -32000);
            Assert.AreEqual(Math.Pow(2000, -32000), result);
        }
    }
}
