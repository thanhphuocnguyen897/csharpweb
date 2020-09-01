using System;

namespace TryandFinally
{
    class ThrowTestA
    {
        static void Main(string[] args)
        {
            int i = 123;
            string s = "something";
            object obj = s;

            try
            {
                // Invalid conversion; obj contains a string, not a numeric type.
                i = (int)obj;

                //The following statement is not fun.
                Console.WriteLine("Writelien at the end of try block.");
            }
            finally
            {
                // To run the program in Visual Studio, type CTRL+F5. Then  
                // click Cancel in the error dialog. 
                Console.WriteLine("\nExecution of the finally block after an unhandled\n" +
                    "error depends on how the exception unwind operation is triggered.");
                Console.WriteLine("i = {0}", i);
            }
        }
    }
}
