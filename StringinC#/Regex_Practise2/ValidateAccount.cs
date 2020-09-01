using System;
using System.Text.RegularExpressions;

namespace Regex_Practise2
{
    class ValidateAccount
    {
        private static AccountRegex accountRegex;
        readonly static string[] validAccount = new string[] { "123abc_", "_abc123", "______", "123456", "abcdefgh" };
        readonly static string[] invalidAccount = new string[] { ".@", "12345", "1234_", "abcde" };
        static void Main()
        {
            accountRegex = new AccountRegex();
            foreach(var account in validAccount)
            {
                bool isValid = accountRegex.Validate(account);
                Console.WriteLine("Account is " + account + " is valid: " + isValid);
            }
            foreach (var account in invalidAccount)
            {
                bool isInvalid = accountRegex.Validate(account);
                Console.WriteLine("Account is " + account + " is valid: " + isInvalid);
            }
        }
    }
    public class AccountRegex
    {
        /*Không chứa các ký tự đặc biệt 
          Phải dài hơn 6 ký tự 
          Không chứa các ký tự viết hoa 
          Cho phép dấu gạch dưới (_) 
        */
        readonly static String ACCOUNT_REGEX = "^[_a-z0-9]{6,}$";
        public bool Validate(string regex)
        {
            bool isMatch = Regex.IsMatch(regex, ACCOUNT_REGEX);
            return isMatch;
        }
    }
}
