using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ConstantTests
    {
        [TestMethod]
        public void ProcessInputCheckVariableForConstant()
        {
            string input = "x = 5";
            ProcessInput PI = new ProcessInput(input);
            char expected = 'x';

            Assert.AreEqual(expected, PI.GetConstant());
        }
    }
}
