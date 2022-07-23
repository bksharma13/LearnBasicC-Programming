using IsDivisibleCheck;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectforLibrary
{
    [TestClass]
    public class UnitTestDivisionValidator
    {
        [TestMethod]
        public void TestDivisionWithoutRemainder()
        {
            int expectedValue = 1;
            DivisionValidator divisionValidator = new DivisionValidator();
            int output = divisionValidator.IsXDivisibleByY(20, 10);

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestDivisionWithRemainder()
        {
            int expectedValue = 0;
            DivisionValidator divisionValidator = new DivisionValidator();
            int output = divisionValidator.IsXDivisibleByY(88, 7);

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestDivisionFractionalNumbers()
        {
            int expectedValue = 0;
            DivisionValidator divisionValidator = new DivisionValidator();
            int output = divisionValidator.IsXDivisibleByY(2, 8);

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestDivision_ZeroNumerator()
        {
            int expectedValue = 1;
            DivisionValidator divisionValidator = new DivisionValidator();
            int output = divisionValidator.IsXDivisibleByY(0, 7);

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestDivision_ZeroDenominator()
        {
            int expectedValue = 0;
            DivisionValidator divisionValidator = new DivisionValidator();
            int output = divisionValidator.IsXDivisibleByY(234, 0);

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestDivision_ZeroByZero()
        {
            int expectedValue = 0;
            DivisionValidator divisionValidator = new DivisionValidator();
            int output = divisionValidator.IsXDivisibleByY(0, 0);

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestDivision_MaxRangeNumerator()
        {
            int expectedValue = 1;
            DivisionValidator divisionValidator = new DivisionValidator();
            int output = divisionValidator.IsXDivisibleByY(int.MaxValue, 1);

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestDivision_MinRangeDenominator()
        {
            int expectedValue = 0;
            DivisionValidator divisionValidator = new DivisionValidator();
            int output = divisionValidator.IsXDivisibleByY(214412, int.MinValue);

            Assert.AreEqual(expectedValue, output);
        }
    }
}
