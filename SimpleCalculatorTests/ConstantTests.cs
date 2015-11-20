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
        public void ConstantTestIsInList()
        {
            Constant constant = new Constant();
            constant.AddToConstants('x', 12);

            Assert.AreEqual(true, constant.IsInList('x'));
            Assert.AreEqual(false, constant.IsInList('y'));
        }

        [TestMethod]
        public void ConstantTestGetExpression()
        {
            string input = "x = 12 + 12";
            Constant constant = new Constant();
            constant.ChangeExpression(input);
            int expected = 24;

            Assert.AreEqual(expected, constant.GetExpression());
        }

        [TestMethod]
        public void ConstantTestGetExpressionWithOtherConstants()
        {
            Constant constant = new Constant();
            string input = "x = 12 + 12";
            constant.ChangeExpression(input);
            constant.GetExpression();
            constant.ChangeExpression("y = x + 2");
            int expected = 26;

            Assert.AreEqual(expected, constant.GetExpression());
        }
    }
}
