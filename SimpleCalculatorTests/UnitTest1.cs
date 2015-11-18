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

        [TestMethod]
        public void ProcessInputTestGetFirstInputNumber()
        {
            int expected = 12345;
            string input = "12345 ";
            ProcessInput PI = new ProcessInput(input);

            Assert.AreEqual(expected, PI.GetFirstInputNumber());
        }

        [TestMethod]
        public void ProcessInputTestGetSecondInputNumber()
        {
            int expected = 54321;
            string input = "12345 + 54321";
            ProcessInput PI = new ProcessInput(input);

            Assert.AreEqual(expected, PI.GetSecondInputNumber());
        }

        [TestMethod]
        public void ProcessInputTestGetOperator()
        {
            char expected = '+';
            string input = "12345 + 54321";
            ProcessInput PI = new ProcessInput(input);

            Assert.AreEqual(expected, PI.GetOperator());

        }

        [TestMethod]
        public void ProcessInputTestValidInputTrue()
        {
            bool expected = true;
            string input = "12345 + 54321";
            ProcessInput PI = new ProcessInput(input);

            Assert.AreEqual(expected, PI.ValidInput());
        }

        [TestMethod]
        public void ProcessInputTestValidInputFalse()
        {
            bool expected = false;
            string input = "12345 +";
            ProcessInput PI = new ProcessInput(input);

            Assert.AreEqual(expected, PI.ValidInput());
        }
    }
}
