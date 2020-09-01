using NUnit.Framework;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace Calculator.Test
{
    [TestFixture]
    public class Calculator_Add
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void TestAdd()
        {
            int x = 1;
            int y = 1;
            int expResult = 2;
            int result = _calculator.Add(x, y);
            Assert.AreEqual(expResult, result);
        }
        [Test]
        public void TestAdd2()
        {
            int x = int.MaxValue;
            int y = 1;
            try
            {
                int result = _calculator.Add(x, y);
                Assert.False(true);
            }
            catch (Exception e)
            {
                Assert.True(true);  
            }
        }
        [Test]
        public void TestAdd3()
        {
            int x = int.MinValue;
            int y = -1;
            try
            {
                int result = _calculator.Add(x, y);
                Assert.False(true);
            }
            catch(Exception e)
            {
                Assert.True(true);
            }
        }
    }
}