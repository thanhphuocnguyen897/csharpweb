using System;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập trọng lượng: ");
            double weight = float.Parse(Console.ReadLine());
            Console.Write("Nhập chiều cao: ");
            double height = float.Parse(Console.ReadLine());
            double bmi = weight / Math.Pow(height,2);
            bmi = Math.Round(bmi, 1);
            if(bmi >= 30.0)
            {
                Console.WriteLine("Obese");
            }
            else 
            {
                if (bmi >= 25.0)
                {
                    Console.WriteLine("Over weight! " + bmi);
                }
                else
                {
                    if(bmi >= 18.5)
                    {
                        Console.WriteLine("Normal! " +  bmi);
                    }
                    else
                    {
                        Console.WriteLine("Under weight! " + bmi);
                    }
                }
                    
            }

        }
    }
}
