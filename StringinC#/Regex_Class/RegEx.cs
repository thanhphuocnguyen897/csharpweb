using System;
using System.Text.RegularExpressions;

namespace Regex_Class
{
    class RegExg
    {
        static void Main(string[] args)
        {
            //Create a pattern for a word that starts with letter "M".
            string pattern = @"\b[M]\w+";
            Regex rg = new Regex(pattern, RegexOptions.IgnoreCase);
            //Long string.
            string authors = "Mahesh Chand, Raj Kumar, Mike Gold, Allen O'Neill, Marshal Troll";
            //Get all matches
            MatchCollection matches = rg.Matches(authors);
            //Print all matches authors
            for (int count = 0; count < matches.Count; count++)
                Console.WriteLine(matches[count].Value);
            /*Trong ví dụ trên, mã tìm kiếm kí tự 'M'. Nhưng chuyện gì sẽ xảy ra nếu từ bắt đầu bằng ‘m'. 
             * Đoạn mã sau sử dụng tham số
             * RegexOptions.IgnoreCase để đảm bảo rằng Regex không tìm kiếm chữ hoa hoặc chữ thường.*/
        }
    }
}
