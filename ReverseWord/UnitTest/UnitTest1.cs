using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseWord;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "good am I";
            ReverseWordLogic obj = new ReverseWordLogic();
            string outStr = obj.Reverse("I am good");
            Assert.IsTrue(expected.Equals(outStr, System.StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void TestMethod_2LeftRotation()
        {
            int[] expected = new int[] { 2, 3, 1 };
            ReverseWordLogic obj = new ReverseWordLogic();
            int[] output = obj.LeftRotate(new int[] { 1, 2, 3 }, 10);
            Assert.AreEqual(expected.Length, output.Length);
            Assert.AreEqual(expected[1], output[1]);
        }
    }
}
