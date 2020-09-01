using System;
using System.IO;
using System.Text;

namespace ManageProductsExcercise
{
    class Products
    {
        static void Main()
        {
            string choice;
            string path = @"D:\C#\FileManipulation\Serialization_And_DesSerialization\ManageProductsExcercise\products1.txt";
            FileInfo file = new FileInfo(path);
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 Add Products: ");
                Console.WriteLine("2 Find Products: ");
                Console.WriteLine("0 Exit: ");
                Console.WriteLine("Enter your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        try
                        {
                            AddProducts(file);
                            Console.WriteLine("Add Completed");
                        }
                        catch(IOException e)
                        {
                            Console.WriteLine("Cannot Add");
                            Console.Error.WriteLine(e.Message);
                        }
                        break;
                    case "2":
                        try
                        {
                            FindProducts(file);
                            Console.WriteLine("Find Completed");
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("Cannot Find");
                            Console.Error.WriteLine(e.Message);
                        }
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }
            }
            while (choice != "0");
        }
        static void FindProducts(FileInfo filePath)
        {
                StreamReader reader = new StreamReader(filePath.FullName);
                try
                {
                    //Console.WriteLine("Enter code   ");
                    string line = "";
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadToEnd();
                        Console.WriteLine(line);
                    }                    
                }
                finally
                {
                    reader.Close();
                    reader.Dispose();
                }
        }
        static void AddProducts(FileInfo filePath)
        {
            StreamWriter writer = new StreamWriter(filePath.FullName);
            StreamReader reader = new StreamReader(filePath.FullName);
            try
            {
                Char[] buffer = new Char[1024];
                int length;
                Console.WriteLine("Enter Products number: ");
                int code = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Products name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Products brand: ");
                string brand = Console.ReadLine();
                Console.WriteLine("Enter Products price: ");
                int price = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Describes...");
                string describ = Console.ReadLine();
                while((length = reader.Read(buffer)) > 0)
                {
                    writer.WriteLine(buffer, 0, length);
                    writer.WriteLine("{0} {1} {2} {3} {4}", code, name, brand, price, describ);
                }
            }
            finally
            {
                writer.Close();
                writer.Dispose();
            }
        }
    }
}        
