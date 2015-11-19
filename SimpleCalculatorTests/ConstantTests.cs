using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System.Collections.Generic;

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

        [TestMethod]
        public void ConstantTestIfCanGetValueOfConstant()
        {
            Constant constant = new Constant();
            constant.AddToConstants('x', 5);

            Assert.AreEqual(5, constant.GetValueOf('x'));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstantTestToMakeSureExceptionThrown()
        {
            Constant constant = new Constant();
            Assert.AreEqual(5, constant.GetValueOf('x'));
        }

        [TestMethod]
        public void ProcessInputTestIfItIsOneConstant()
        {
            string input = "    x      ";
            ProcessInput PI = new ProcessInput(input);
            char expected = 'x';

            Assert.AreEqual(expected, PI.GetConstant());
        }

        [TestMethod]
        public void ProcessInputTestGetConstantInEquation()
        {
            string input = "x = y + z";
            ProcessInput PI = new ProcessInput(input);
            List<char> expected = new List<char>() { 'x', 'y', 'z' };

            CollectionAssert.AreEqual(expected, PI.GetAllConstantsInEquation());
        }

        [TestMethod]
        public void ConstantTestIsInList()
        {
            Constant constant = new Constant();
            constant.AddToConstants('x', 12);

            Assert.AreEqual(true, constant.IsInList('x'));
            Assert.AreEqual(false, constant.IsInList('y'));
        }

        [TestMethod]
        public void ConstantTestGetValuesOfAllConstants()
        {
            List<int> expected = new List<int>() { 12, 13, 14 };
            Constant constant = new Constant();
            constant.AddToConstants('x', 12);
            constant.AddToConstants('y', 13);
            constant.AddToConstants('z', 14);



            CollectionAssert.AreEqual(expected, constant.GetValuesOfAllConstants(new List<char>() { 'x', 'y', 'z'}));
        }
    }
}
