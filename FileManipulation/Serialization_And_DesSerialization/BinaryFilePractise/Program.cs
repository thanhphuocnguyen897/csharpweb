using System;
using System.IO;

namespace BinaryFilePractise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Source File: ");
            string sourcePath = Console.ReadLine();
            Console.WriteLine("Enter destinate file: ");
            string destinationPath = Console.ReadLine();
            FileInfo source = new FileInfo(sourcePath);
            FileInfo destination = new FileInfo(destinationPath);
            //try
            //{
            //    CopyFileUsingFileInfo(source, destination);
            //    Console.WriteLine("Copy completed");
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Cannot copy");
            //    Console.Error.WriteLine(e.Message);
            //}
            try
            {
                CopyFileUsingStream(source, destination);
                Console.WriteLine("Copy completed");
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot copy");
                Console.Error.WriteLine(e.Message);
            }

        }
        private static void CopyFileUsingFileInfo(FileInfo source, FileInfo dest)
        {
                Console.WriteLine("Start Copy using FileInfo");
                source.CopyTo(dest.FullName, false);
        }

        private static void CopyFieUsingFile(string source, string target)
        {
            File.Copy(source, target, false);
        }
        private static void CopyFileUsingStream(FileInfo source, FileInfo dest)
        {
            Console.WriteLine("Start Copy using Stream");
            StreamWriter writer = null;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(source.FullName);
                writer = new StreamWriter(dest.FullName);
                char[] buffer = new char[1024];
                int length;
                while ((length = reader.Read(buffer)) > 0)
                {
                    writer.Write(buffer, 0, length);
                }
            }
            finally
            {
                reader.Close();
                reader.Dispose();
                writer.Close();
                writer.Dispose();
            }
        }
    }
    public class Main
    {
        
    }
}
