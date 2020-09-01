using System;

namespace spellNumbertoWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập vào số cầm spell: ");
            int number = Convert.ToInt32(Console.ReadLine());
            String ones = "";
            String tens = "";
            String hundred = "";
            String name = hundred + tens + ones;
            if(number < 0)
            {
                Console.Write("Out of ability!");
            }
            else if (number < 10)
            {
                switch (number)
                {
                    case 1:
                        ones = "One";
                        break;
                    case 2:
                        ones = "Two";
                        break;
                    case 3:
                        ones = "Three";
                        break;
                    case 4:
                        ones = "Four";
                        break;
                    case 5:
                        ones = "Five";
                        break;
                    case 6:
                        ones = "Six";
                        break;
                    case 7:
                        ones = "Seven";
                        break;
                    case 8:
                        ones = "Eight";
                        break;
                    default:
                        ones = "Nine";
                        break;
                }
                if (number < 20)
                {
                    int one = number % 10;
                    switch (one)
                    {
                        case 1:
                            tens = "eleven";
                            break;
                        case 2:
                            tens = "twelve";
                            break;
                        case 3:
                            tens = "thirteen";
                            break;
                        case 5:
                            tens = "fifteen";
                            break;
                        case 4:
                        case 6:
                        case 7:
                        case 8:
                        default:
                            tens = ones + "teen";
                            break;
                    }
                }
                Console.WriteLine("Spell: " + name);
            }

        }
    }
}
