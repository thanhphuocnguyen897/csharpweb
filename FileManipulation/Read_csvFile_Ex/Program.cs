using System;
using System.Collections.Generic;
using System.IO;

namespace Read_csvFile_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"D:\C#\FileManipulation\Read_csvFile_Ex\filetoread.csv");
            string path = @"D:\C#\FileManipulation\Read_csvFile_Ex\filetoread.csv";
            ReadcsvFile(path);
            Console.ReadKey();
        }
        static void ReadcsvFile(string filePath)
        {
            List<string> ListA = new List<string>();
            List<string> ListB = new List<string>();
            try
            {
                FileInfo file = new FileInfo(filePath);
                if (!file.Exists)
                {
                    throw new FileNotFoundException();
                }

                StreamReader reader = new StreamReader(filePath);
                string line = "";
                while(!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] values = line.Split(',');
                    ListA.Add(values[4]);
                    ListB.Add(values[5]);
                    
                }
                reader.Close();
                //foreach(string items in ListA)
                //{
                //    Console.WriteLine(items);
                //}
                foreach (string items in ListB)
                {
                    Console.WriteLine(items);
                }
            }
            catch (System.Exception)
            {
                Console.Error.WriteLine("File not found or invalid content");
            }
        }
    }

}
