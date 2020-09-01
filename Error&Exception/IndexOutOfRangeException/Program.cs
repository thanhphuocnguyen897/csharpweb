using System;
using System.Collections.Generic;

namespace IndexOutOfRange_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> character = new List<char>();
                character.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = character[6];
            }
            catch(IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex);
            }
            
        }
    }
}
