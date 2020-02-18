using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int b = 5;
            int result1 = ConsoleApp2.Program.Square(b);
            int result2 = ConsoleApp2.Program.Plo(b);
            Assert.AreEqual(125, result1);
            Assert.AreEqual(25, result2);
        }
    }
}
