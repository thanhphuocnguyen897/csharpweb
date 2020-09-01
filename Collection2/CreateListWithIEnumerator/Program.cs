using System;

namespace CreateListWithIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new AllColors();
            foreach(Color thecolor in colors)
            {
                Console.Write(thecolor.Name + " ");
            }
            Console.WriteLine();
        }
    }
}
