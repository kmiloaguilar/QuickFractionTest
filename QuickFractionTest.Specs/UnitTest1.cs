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
            var f = new Fraction();
            bool result = (f.Numerator == 1) && (f.Denominator == 1);
            Assert.AreEqual(true,result);
        }

        [TestMethod]
        public void TestSumMethodFromCalc()
        {
            var c = new Calc();
            int val1 = 10;
            int val2 = 10;
            int result = c.Sum(val1, val2);
            Assert.AreEqual(20,result);
        }

        [TestMethod]
        public void TestSumFractions()
        {
            var fraction1 = new Fraction(2, 3);
            var fraction2 = new Fraction(1, 3);

            var expectedFraction = new Fraction(3, 3);

            var result = fraction1 + fraction2;

            var comparisonResult = result.Denominator == expectedFraction.Denominator &&
                                   result.Numerator == expectedFraction.Numerator;

            Assert.AreEqual(comparisonResult,true);

        }
    }
}
