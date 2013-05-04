using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickFractionTest.Winform;

namespace QuickFractionTest.Specs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            Fraction f = new Fraction();
            bool result = (f.Numerator == 1) && (f.Denominator == 1);
            Assert.AreEqual(true,result);
        }
    }
}
