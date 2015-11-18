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
            string input = "12345 + 54321";
            ProcessInput PI = new ProcessInput(input);

            Assert.AreEqual(expected, PI.GetFirstInputNumber());
        }

        [TestMethod]
        public void ProcessInputTestGetFirstInputNumber2()
        {
            int expected = 12345;
            string input = "12345+ 54321";
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
        public void ProcessInputTestGetSecondInputNumber2()
        {
            int expected = 54321;
            string input = "12345+    54321";
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
        public void ProcessInputTestGetOperator2()
        {
            char expected = '+';
            string input = "12345   +54321";
            ProcessInput PI = new ProcessInput(input);

            Assert.AreEqual(expected, PI.GetOperator());
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ProcessInputTestGetOperatorWithInvalidInput()
        {
            char expected = '+';
            string input = "12345 = 54321";
            ProcessInput PI = new ProcessInput(input);

            Assert.AreEqual(expected, PI.GetOperator());
        }

        [TestMethod]
        public void EvaluateTestOperateWithAdd()
        {
            string input = "1 + 1";
            ProcessInput PI = new ProcessInput(input);
            Evaluate ev = new Evaluate(PI.GetFirstInputNumber(), PI.GetOperator(), PI.GetSecondInputNumber());
            int expected = 2;

            Assert.AreEqual(expected, ev.Operate());
        }

        [TestMethod]
        public void EvaluateTestOperateWithSubtract()
        {
            string input = "2 - 1";
            ProcessInput PI = new ProcessInput(input);
            Evaluate ev = new Evaluate(PI.GetFirstInputNumber(), PI.GetOperator(), PI.GetSecondInputNumber());
            int expected = 1;

            Assert.AreEqual(expected, ev.Operate());
        }

        [TestMethod]
        public void EvaluateTestOperateWithMultiply()
        {
            string input = "2 * 3";
            ProcessInput PI = new ProcessInput(input);
            Evaluate ev = new Evaluate(PI.GetFirstInputNumber(), PI.GetOperator(), PI.GetSecondInputNumber());
            int expected = 6;

            Assert.AreEqual(expected, ev.Operate());
        }

        [TestMethod]
        public void EvaluateTestOperateWithDivide()
        {
            string input = "9 / 3";
            ProcessInput PI = new ProcessInput(input);
            Evaluate ev = new Evaluate(PI.GetFirstInputNumber(), PI.GetOperator(), PI.GetSecondInputNumber());
            int expected = 3;

            Assert.AreEqual(expected, ev.Operate());
        }

        [TestMethod]
        public void EvaluateTestOperateWithModulus()
        {
            string input = "9 % 3";
            ProcessInput PI = new ProcessInput(input);
            Evaluate ev = new Evaluate(PI.GetFirstInputNumber(), PI.GetOperator(), PI.GetSecondInputNumber());
            int expected = 0;

            Assert.AreEqual(expected, ev.Operate());
        }
    }
}