using System;
using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UT
{
    [TestClass]
    public class PowMatch
    {
        [TestMethod]
        public void Test_1()
        {
            Pow pow = new Pow(2, 3);
            double expectedResult = 8.0;
            double actualResult = pow.Math();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Test_2()
        {
            Pow pow = new Pow(0, 0);
            double expectedResult = 1.0;
            double actualResult = pow.Math();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Test_3()
        {
            Pow pow = new Pow(-10, -2);
            double expectedResult = 0.01;
            double actualResult = pow.Math();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Test_4()
        {
            Pow pow = new Pow(-10, 0.5);
            double expectedResult = Double.NaN;
            double actualResult = pow.Math();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
