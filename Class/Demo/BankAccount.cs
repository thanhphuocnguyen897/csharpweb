using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
        private static int accountNumberSeed = 546512654;
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = name;
            Balance = initialBalance;
        }
        ~BankAccount()
        {
            Console.WriteLine("Finalizing Object!");
        }
    }
}
