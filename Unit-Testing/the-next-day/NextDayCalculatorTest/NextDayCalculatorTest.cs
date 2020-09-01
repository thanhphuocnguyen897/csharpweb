using NUnit.Framework;

namespace NextDayCalculator.Test
{
    public class NextDayCalculatorTest
    {
        private NextDayCalculator _nextDayCalculator;
        [SetUp]
        public void Setup()
        {
            _nextDayCalculator = new NextDayCalculator();
        }

        [Test]
        public void TestCalculateDay29()
        {
            int day = 29;
            int month = 2;
            int year = 2020;
            int expectday = 1;
            int expectmonth = 3;
            _nextDayCalculator.IncreaseElement(day, month, year, _nextDayCalculator.CheckYear(year));
            int resultday = _nextDayCalculator.Day;
            int resultmonth = _nextDayCalculator.Month;
            int resultyear = _nextDayCalculator.Year;
            Assert.AreEqual(resultday, expectday);
            Assert.AreEqual(resultmonth, expectmonth);
        }
        [Test]
        public void TestCalculateDay28()
        {
            int day = 28;
            int month = 2;
            int year = 2018;
            int expectday = 1;
            int expectmonth = 3;
            _nextDayCalculator.IncreaseElement(day, month, year, _nextDayCalculator.CheckYear(year));
            int resultday = _nextDayCalculator.Day;
            int resultmonth = _nextDayCalculator.Month;
            int resultyear = _nextDayCalculator.Year;
            Assert.AreEqual(resultday, expectday);
            Assert.AreEqual(resultmonth, expectmonth);
        }
        [Test]
        public void TestCalculateDay3112()
        {
            int day = 31;
            int month = 12;
            int year = 2018;
            int expectday = 1;
            int expectmonth = 1;
            int expectyear = 2019;
            _nextDayCalculator.IncreaseElement(day, month, year, _nextDayCalculator.CheckYear(year));
            int resultday = _nextDayCalculator.Day;
            int resultmonth = _nextDayCalculator.Month;
            int resultyear = _nextDayCalculator.Year;
            Assert.AreEqual(resultday, expectday);
            Assert.AreEqual(resultmonth, expectmonth);
            Assert.AreEqual(resultyear, expectyear);
        }
    }
}