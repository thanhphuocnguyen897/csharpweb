using System;

namespace CountAppearance
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "nguyen Thanh Phuoc";
            char c = 'n';
            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if( c == str[i])
                {
                    count++;
                }
            }
            Console.WriteLine("Number chars in string: " + count);
        }
    }
}
