using consoleApp;

namespace TestProject1
{
    [TestClass]
    public class Test_getMultiOfNotEvenIndexesFromArray
    {
        [TestMethod]
        public void test1_getMultiOfNotEvenIndexesFromArray()
        {
            float[] arr = { 1f, 2.2f, 3f, 4f, 5f };
            float expected = 8.8f;
            Assert.AreEqual(expected, App.getMultiOfNotEvenIndexesFromArray(arr));
        }
        [TestMethod]
        public void test2_getMultiOfNotEvenIndexesFromArray()
        {
            float[] arr = { 1.5f, 2.1f, 3.7f, 4.3f };
            float expected = 9.03f;
            Assert.AreEqual(expected, App.getMultiOfNotEvenIndexesFromArray(arr));
        }
        [TestMethod]
        public void test3_getMultiOfNotEvenIndexesFromArray()
        {
            float[] arr = { 1f, 2f, 3f, 4f, 5f, 6f};
            float expected = 48f;
            Assert.AreEqual(expected, App.getMultiOfNotEvenIndexesFromArray(arr));
        }
    }
    [TestClass]
    public class Test_shiftArray
    {
        [TestMethod]
        public void test1_shiftArray()
        {
            float[] arr = { 1f, 2.2f, 3f, 4f, 5f };
            int h = 2;
            float[] expected = { 4f, 5f, 1f, 2.2f, 3f };
            App.shiftArray(arr, h);
            CollectionAssert.AreEqual(expected, arr);
        }
        [TestMethod]
        public void test2_shiftArray()
        {
            float[] arr = { 1.2f, 3.4f, 5.6f, 7.8f, 9.1f };
            int h = 3;
            float[] expected = { 5.6f, 7.8f, 9.1f, 1.2f, 3.4f };
            App.shiftArray(arr, h);
            CollectionAssert.AreEqual(expected, arr);
        }
        [TestMethod]
        public void test3_shiftArray()
        {
            float[] arr = { 1f };
            int h = 4;
            float[] expected = { 1f };
            App.shiftArray(arr, h);
            CollectionAssert.AreEqual(expected, arr);
        }
    }
    [TestClass]
    public class Test_fromBase
    {
        [TestMethod]
        public void test1_fromBase()
        {
            int b = 2;
            string s = "10100";
            int expected = 20;
            Assert.AreEqual(expected, App.fromBase(b, s));
        }
        [TestMethod]
        public void test2_fromBase()
        {
            int b = 16;
            string s = "FF";
            int expected = 255;
            Assert.AreEqual(expected, App.fromBase(b, s));
        }
        [TestMethod]
        public void test3_fromBase()
        {
            int b = 8;
            string s = "777";
            int expected = 511;
            Assert.AreEqual(expected, App.fromBase(b, s));
        }
    }
}