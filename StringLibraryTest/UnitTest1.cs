using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            myClass.TryThis("Test");
            Assert.AreEqual(myClass.s, "Test");
        }
    }
}
