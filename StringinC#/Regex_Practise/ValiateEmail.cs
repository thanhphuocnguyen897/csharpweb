using System;
using System.Text.RegularExpressions;

namespace Regex_Practise
{
    class ValiateEmail
    {
        static RegexEmail regexEmail;
        readonly static string[] validEmail = new string[] { "a@gmail.com", "ab@yahoo.com", "abc@hotmail.com" };
        readonly static string[] invalidEmail = new string[] { "@gmail.com", "ab@gmail.", "@#abc@gmail.com" };
        static void Main()
        {
            regexEmail = new RegexEmail();
            foreach(var email in validEmail)
            {
                bool isValid = regexEmail.Validate(email);
                Console.WriteLine("Email is " + email + " is valid: " + isValid);
            }
            foreach(var email in invalidEmail)
            {
                bool isInvalid = regexEmail.Validate(email);
                Console.WriteLine("Email is " + email + " is valid: " + isInvalid);
            }
            
        }
    }
    public class RegexEmail
    {
        readonly private static string EMAIL_REGEX = "^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)$";
        public bool Validate(string regex)
        {
            bool matcher = Regex.IsMatch(regex,EMAIL_REGEX);
            return matcher;
        }
    }
}
