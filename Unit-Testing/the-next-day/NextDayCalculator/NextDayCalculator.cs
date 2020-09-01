using System;

namespace NextDayCalculator
{
    public class NextDayCalculator
    {
        private int day;
        private int month;
        private int year;

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public void IncreaseElement(int day, int month, int year, bool isLeap)
        {
            this.Day = day;
            this.Year = year;
            this.Month = month;
            switch (month)
            {
                case 2:
                    if (this.Day == 29 && isLeap)
                    {
                        this.Day = 1;
                        this.Month++;
                    }
                    else if (this.Day < 29 && isLeap)
                    {
                      this.Day++;
                    }
                    else if (this.Day == 28)
                    {
                        this.Day = 1;
                        this.Month++;
                    }
                    else if(this.Day < 28)
                    {
                        this.Day++;
                    }
                        break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if(this.Day == 31)
                    {
                        this.Day = 1;
                        if(this.Month == 12)
                        {
                            this.Month = 1;
                            this.Year++;
                        }
                        else
                        {
                            this.Month++;
                        }
                    }
                    else
                    {
                        this.Day++;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (this.Day == 30)
                    {
                        this.Day = 1;
                        this.Month++;
                    }
                    else
                    {
                        this.Day++;
                    }
                    break;
                default:
                    throw new NotImplementedException("Please enter date time first.");
            }
        }
        public bool CheckYear(int year)
        {
            bool isLeap = false;
            bool isDivisibleBy4 = year % 4 == 0;
            if (isDivisibleBy4)
            {
                bool isDivisibleBy100 = year % 100 == 0;
                if (isDivisibleBy100)
                {
                    bool isDivisibleBy400 = year % 400 == 0;
                    if (isDivisibleBy400)
                    {
                        isLeap = true;
                    };
                }
                else
                {
                    isLeap = true;
                }
            }
            if (isLeap)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
