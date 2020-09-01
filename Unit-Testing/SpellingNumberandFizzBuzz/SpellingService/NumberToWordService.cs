using System;

namespace SpellingService
{
    public class NumberToWordService
    {
        public String SpellUnit(int number)
        {
            String name = "";
            switch (number)
            {
                case 1:
                    name = "one";
                    break;
                case 2:
                    name = "two";
                    break;
                case 3:
                    name = "three";
                    break;
                case 4:
                    name = "four";
                    break;
                case 5:
                    name = "five";
                    break;
                case 6:
                    name = "six";
                    break;
                case 7:
                    name = "seven";
                    break;
                case 8:
                    name = "eight";
                    break;
                case 9:
                    name = "nine";
                    break;
            }
            return name;
        }
        public String SpellTen(int number)
        {
            String name = null;
            switch (number)
            {
                case 10:
                    name = "ten";
                    break;
                case 11:
                    name = "eleven";
                    break;
                case 12:
                    name = "twelve";
                    break;
                case 13:
                    name = "thirteen";
                    break;
                case 15:
                    name = "fifteen";
                    break;
                case 14:
                case 16:
                case 17:
                case 19:
                    name = SpellUnit(number % 10) + "teen";
                    break;
                case 20:
                    name = "twenty";
                    break;
                case 30:
                    name = "thirty";
                    break;
                case 50:
                    name = "fifty";
                    break;
                case 40:
                case 60:
                case 70:
                case 80:
                case 90:
                    name = SpellUnit(number / 10) + "ty";
                    break;
                default:
                    if (number > 0)
                    {
                        name = SpellTen(number - (number % 10)) + " " + SpellUnit(number % 10);
                    }
                    break;
            }
            return name;
        }
        public String SpellHundred(int number)
        {
            String name = null;
            return name = SpellUnit(number / 100) + " hundred and " + SpellTen(number % 100);
        }
    }
}
