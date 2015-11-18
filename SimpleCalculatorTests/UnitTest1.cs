using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProcessInputEnsureParameterIsCorrect()
        {
            string expected = "hello";
            ProcessInput PI = new ProcessInput(expected);

            Assert.AreEqual(expected, PI.Input);
        }
    }
}
