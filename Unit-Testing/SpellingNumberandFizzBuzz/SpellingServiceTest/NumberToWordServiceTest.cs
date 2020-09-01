using NUnit.Framework;
using SpellingService;
using System;

namespace SpellingServiceTest
{
    public class NumberToWordServiceTest
    {
        private NumberToWordService _numberToWordService;
        [SetUp]
        public void Setup()
        {
            _numberToWordService = new NumberToWordService();
        }

        [Test]
        public void TestSpelling999()
        {
            int number = 999;
            string expected = "nine hundred and ninety nine";
            String result = _numberToWordService.SpellHundred(number);
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestSpelling88()
        {
            int number = 88;
            String expected = "eightty eight";
            String result = _numberToWordService.SpellTen(number);
            Assert.AreEqual(result, expected);
        }
    }
}