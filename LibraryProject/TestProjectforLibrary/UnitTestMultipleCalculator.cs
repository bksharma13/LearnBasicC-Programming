using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfMultiple;

namespace TestProjectforLibrary
{
    [TestClass]
    public class UnitTestMultipleCalculator
    {
        [TestMethod]
        public void TestSumMultiple_Valid()
        {
            int expectedValue = 33;
            FindMultipleOf3and5 findMultipleOf3And5obj = new FindMultipleOf3and5();
            int output = findMultipleOf3And5obj.GetSum(10);

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestSumMultiple_Zero()
        {
            int expectedValue = 0;
            FindMultipleOf3and5 findMultipleOf3And5obj = new FindMultipleOf3and5();
            int output = findMultipleOf3And5obj.GetSum(0);

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestSumMultiple_InValid()
        {
            int expectedValue = 0;
            FindMultipleOf3and5 findMultipleOf3And5obj = new FindMultipleOf3and5();
            // Pass a negative range
            int output = findMultipleOf3And5obj.GetSum(-10);

            Assert.AreEqual(expectedValue, output);
        }
    }
}
