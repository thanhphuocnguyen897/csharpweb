using System;
using System.IO;

namespace FileNotFounda_Exception
{
    class Program
    {
        

        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader("not-there.txt"))
                {
                    reader.ReadToEnd();
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }               
        }
    }
}
