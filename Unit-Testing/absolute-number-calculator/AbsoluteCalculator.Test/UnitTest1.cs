using AbsoluteCalculator.Service;
using NUnit.Framework;

namespace AbsoluteCalculator.Test
{
    public class AbsoluteNumberCalculatorTest
    {
        private AbsoluteNumberCalculator _absoluteNumberCalculator;

        [SetUp]
        public void Setup()
        {
            _absoluteNumberCalculator = new AbsoluteNumberCalculator();
        }

        [Test]
        public void TestFindAbsolute0()
        {
            int number = 0;
            int expect = 0;
            int result = _absoluteNumberCalculator.FindAbsolute(number);
            Assert.AreEqual(expect, result);
        }
        [Test]
        public void TestFindAbsolute1()
        {
            int number = 1;
            int expected = 1;

            int result = _absoluteNumberCalculator.FindAbsolute(number);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestFindAbsoluteNegative1()
        {
            int number = -1;
            int expected = 1;

            int result = _absoluteNumberCalculator.FindAbsolute(number);
            Assert.AreEqual(expected, result);
        }
    }
}