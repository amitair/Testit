using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;

namespace Consoletest3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("hello world",ConsoleApplication3.Program.CreateMessage());

        }
    }
}
