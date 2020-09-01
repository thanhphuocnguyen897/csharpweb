using System;

namespace AbsoluteCalculator.Service
{
    public class AbsoluteNumberCalculator
    {
        public int FindAbsolute(int number)
        {
            //throw new Exception();
            if (number < 0) number = -number;
            return number;
        }

    }
}
