using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private string Exp = "Hello World! on Jenkins";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw=new StringWriter())
            {
                Console.SetOut(sw);
                TEST_VS_Jenkins.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Exp, result);
            }
        }
    }
}
