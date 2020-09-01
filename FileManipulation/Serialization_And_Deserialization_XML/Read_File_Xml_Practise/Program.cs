using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Xml;
using System.Xml.Linq;

namespace Read_File_Xml_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWriten = WriteToFile();
            if (isWriten)
            {
                ReadFromFile();
            }
            else
            {
                System.Console.WriteLine("Write data to file occur an error. Please try again!");
            }
        }
        static void ReadFromFile()
        {
            string path = @"D:\C#\FileManipulation\Serialization_And_Deserialization_XML\Read_File_Xml_Practise\books.xml";
            XmlTextReader reader = new XmlTextReader(path);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.WriteLine("");
                        break;
                }
            }
        }
        static bool WriteToFile()
        {
            Book book = new Book();
            book.Title = "Đắc Nhân Tâm";
            book.Price = 123.5f;
            string path = @"D:\C#\FileManipulation\Serialization_And_Deserialization_XML\Read_File_Xml_Practise\books.xml";
            try
            {
                XDocument xDoc = XDocument.Load(path);
                XElement newBook = new XElement("book", 
                    new XElement("title", book.Title), 
                    new XElement("price", book.Price.ToString()));
                xDoc.Element("bookstore").Add(newBook);
                xDoc.Save(path);
                return true;
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex);
                return false;
            }
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }
}
