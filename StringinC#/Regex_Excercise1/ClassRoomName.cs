using System;
using System.Text.RegularExpressions;

namespace Regex_Excercise1
{
    class ClassRoomName
    {
        static ValidateName validateName;
        readonly static string[] validName = new string[] { "C0318G" };
        readonly static string[] invalidName = new string[] { "M0318G", "P0323A" };
        static void Main()
        {
            validateName = new ValidateName();
            foreach(var name in validName)
            {
                bool isvalid = validateName.Validate(name);
                Console.WriteLine("Name is " + name + " is valid: " + isvalid);
            }
            foreach(var name in invalidName)
            {
                bool isInvalid = validateName.Validate(name);
                Console.WriteLine("Name is " + name + " is valid: " + isInvalid);
            }
        }
    }
    public class ValidateName
    {
        /*Bắt đầu bằng một ký tự chữ hoa C hoặc A hoặc P
         * Không chứa các ký tự đặc biệt
         * Theo sau ký tự bắt đầu là 4 ký tự số 
         * Kết thúc phải là 1 trong những ký tự chữ hoa sau: G, H, I, K, L, M */
        readonly static String NAME_REGEX = "^[ACP]{1}[0-9]{4}[GHIKLM]{1}";
        public bool Validate(string regex)
        {
            bool matcher = Regex.IsMatch(regex, NAME_REGEX);
            return matcher;
        }
    }
}
