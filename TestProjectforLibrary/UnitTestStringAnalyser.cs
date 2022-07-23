using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceAnalysis;

namespace TestProjectforLibrary
{
    [TestClass]
    public class UnitTestStringAnalyser
    {
        [TestMethod]
        public void TestAnalyseString_Valid()
        {
            string expectedValue = "GIINRSST";
            AnalyseTheString analyseTheString = new AnalyseTheString();
            string output = analyseTheString.FindUpperCaseChar("This IS a StRING");

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestAnalyseString_NoUpperCharacter()
        {
            string expectedValue = string.Empty;
            AnalyseTheString analyseTheString = new AnalyseTheString();
            string output = analyseTheString.FindUpperCaseChar("no upper case string");

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestAnalyseString_Null()
        {
            string expectedValue = string.Empty;
            AnalyseTheString analyseTheString = new AnalyseTheString();
            string output = analyseTheString.FindUpperCaseChar(null);

            Assert.AreEqual(expectedValue, output);
        }

        [TestMethod]
        public void TestAnalyseString_AllUpper()
        {
            string expectedValue = "ABCDE";
            AnalyseTheString analyseTheString = new AnalyseTheString();
            string output = analyseTheString.FindUpperCaseChar("EDCBA");

            Assert.AreEqual(expectedValue, output);
        }
    }
}
