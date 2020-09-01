using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            if(x/2 + y/2 >= int.MaxValue / 2)
            {
                throw new Exception("Out of range exception.");
            }
            else if(x/2 + y/2 <= int.MinValue / 2)
            {
                throw new Exception("Out of range exception.");
            }
            return x + y;
            //throw new Exception("not support operator");
        }
    }
}
