using System;
using System.Collections.Generic;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Book> bookList = new Dictionary<string, Book>();


            bookList.Add("9780321344755", new Book { ISBM = "9780321344755", Name = "Don't Make Me Think (Beta)", Author = "Steve Krug" });
            bookList.Add("1491904909", new Book { ISBM = "1491904909", Name = "User Story Mapping", Author = "Jeff Patton" });
            bookList.Add("9780465050659", new Book { ISBM = "9780465050659", Name = "The Design of Everyday Things", Author = "Don Norman" });
            Console.WriteLine("Add book to Dictionary");


            PrintValue(bookList);

            bookList["9780321344755"] = new Book { ISBM = "9780321344755", Name = "Don't Make Me Think", Author = "Steve Krug" };
            Console.WriteLine("Edit book with ISBN");
            PrintValue(bookList);

            Console.WriteLine("Search for a specific book with ISBN");
            if(bookList.ContainsKey("9780321344755") == false)
            {
                Console.WriteLine("Key not found.");
            }
            else
            {
                Book book = bookList["9780321344755"];
                Console.WriteLine("Found this book: " + book.Name);
            }


            Console.WriteLine("/n Remove first book.");
            bookList.Remove("9780321344755");
            Console.WriteLine("Remove book with ISBN");
            PrintValue(bookList);
        }
        public static void PrintValue(Dictionary<string, Book> books)
        {
            foreach(KeyValuePair<string, Book> kvp in books)
            {
                Book book = kvp.Value;
                Console.WriteLine("ISBM: " + book.ISBM + "-" + book.Name + "-" + book.Author);
            }
            Console.WriteLine();
        }
    }
    public class Book
    {
        public string ISBM { get; set; }
        public String Name { get; set; }
        public String Author { get; set; }
    }
}
