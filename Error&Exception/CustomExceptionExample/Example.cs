using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

namespace CustomExceptionExample
{
    class Example
    {
        static void Main()
        {
            int limit = 10000000;
            PrimeNumberGenerator primes = new PrimeNumberGenerator(limit);
            int start = 1000001;
            try
            {
                int[] values = primes.GetPrimeFrom(start);
                Console.WriteLine("There are {0} prime numbers from {1} to {2}", start, limit);
            }
            catch(NotPrimeException e)
            {
                Console.WriteLine("{0} is not prime", e.NonPrime);
                Console.WriteLine(e);
                Console.WriteLine("----------------------");
            }

            AppDomain domain = AppDomain.CreateDomain("Domain2");
            PrimeNumberGenerator gen =
                (PrimeNumberGenerator)domain.CreateInstanceAndUnwrap(typeof(Example).Assembly.FullName, "PrimeNumberGenerator",
                true, BindingFlags.Default, null, new object[] { 1000000 }, null, null);
            try
            {
                start = 100;
                Console.WriteLine(gen.GetPrimeFrom(start));
            }
            catch(NotPrimeException e)
            {
                Console.WriteLine("{0} is not prime", e.NonPrime);
                Console.WriteLine(e);
                Console.WriteLine("---------------------------------------");
            }
        }
    }
    [Serializable()]
    public class NotPrimeException : Exception
    {
        private int notAPrime;
        protected NotPrimeException() : base()
        { }
        public NotPrimeException(int value) :
            base(String.Format("{0} is not a prime number.", value))
        {
            notAPrime = value;
        }
        public NotPrimeException(int value, string message): base(message)
        {
            notAPrime = value;
        }
        public NotPrimeException(int value, string message, Exception innerException):
            base(message, innerException)
        {
            notAPrime = value;
        }
        protected NotPrimeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
        public int NonPrime { get { return notAPrime; } }
    }

    [Serializable]
    public class PrimeNumberGenerator
    {
        private const int START = 2;
        private int maxUpperBound = 10000000;
        private int upperBound;
        private bool[] primeTable;
        private List primes = new List();
        public PrimeNumberGenerator(int upperBound)
        {
            if (upperBound > maxUpperBound)
            {
                string message = String.Format("{0} exceeds the maximum upper bound of {1}.", upperBound, maxUpperBound);
                throw new ArgumentOutOfRangeException(message);
            }
            this.upperBound = upperBound;
            //Create array and mark 0, 1 as not prime (True).
            primeTable = new bool[upperBound + 1];
            primeTable[0] = true;
            primeTable[1] = true;
            //Use Sieve of Eratosthenes to determine prime numbers.
            for (int ctr = START; ctr <= (int)Math.Ceiling(Math.Sqrt(upperBound)); ctr++)
            {
                if (primeTable[ctr]) continue;
                for (int multiplier = ctr; multiplier <= upperBound / ctr; multiplier++)
                    if (ctr * multiplier <= upperBound) primeTable[ctr * multiplier] = true;
            }
            //populate array with prime number information.
            int index = START;
            while (index != -1)
            {
                index = Array.FindIndex(primeTable, index, (flag) => !flag);
                if (index >= 1)
                {
                    primes.Add(index);
                    index++;
                }
            }
        }
        public int[] GetAllPrimes()
        {
            return primes.ToArray();
        }
        public int GetPrimeFrom(int prime)
        {
            int start = primes.FindIndex((value) => value == prime);
            if (start < 0)
                throw new NotPrimeException(prime, String.Format("{0} is not a prime number.", prime));
            else
                return primes.FindAll((value) => value >= prime).ToArray();
        }
    }
}
