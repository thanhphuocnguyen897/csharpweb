using System;
using System.IO;

namespace FileClass
{
    class Program
    {
        static void Main()
        {
            string sourceFilePath = @"D:\Pictures\log.txt"; //File nguồn.
            string destinationFilePath = @"D:\TOEIC\Data.txt"; //File đích.
            bool overWrite = true; //Có ghi đè không.
            File.Copy(sourceFilePath, destinationFilePath, overWrite);
            //File.Delete(destinationFilePath);
            bool doesFileExist = File.Exists(destinationFilePath);
            Console.WriteLine(doesFileExist);
            DateTime fileCreateOn = File.GetCreationTime(sourceFilePath);
            Console.WriteLine(fileCreateOn);
        }
    }
}
