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

        //[TestMethod]
        //public void ConstantTestProperties()
        //{
        //    string input = "x = 5";
        //    ProcessInput PI = new ProcessInput(input);
        //    Constant constant = new Constant(PI.GetConstant(), PI.GetSecondInputNumber());
        //    char expectedConst = 'x';
        //    int expectedNum = 5;

        //    Assert.AreEqual(expectedConst, constant.Name);
        //    Assert.AreEqual(expectedNum, constant.Number);
        //}

        [TestMethod]
        public void ConstantTestAddToListMethod()
        {
            Constant constant = new Constant();
            char expectedConst = 'x';
            int expectedNum = 5;
            constant.AddToConstants(expectedConst, expectedNum);

            Assert.AreEqual(expectedNum, constant.Constants[expectedConst]);
        }

        [TestMethod]
        public void ConstantTestIfCanAddToDictionaryIfConstantAlreadyExists()
        {
            Constant constant = new Constant();
            constant.AddToConstants('x', 5);
            constant.AddToConstants('x', 10);

            Assert.AreEqual(5, constant.Constants['x']);
        }
    }
}
