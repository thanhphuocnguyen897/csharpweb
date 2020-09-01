using System;
using System.IO;

namespace FileInfoClass
{
    class Program
    {
        static void Main()
        {
            string sourceFilePath = @"D:\Pictures\log.txt"; //File nguồn.
            string destinationFilePath = @"D:\TOEIC\Data.txt"; //File đích.
            bool overwrite = true;
            FileInfo fileInfo = new FileInfo(sourceFilePath);
            //Copy file.
            fileInfo.CopyTo(destinationFilePath, overwrite);
            FileInfo fileInfo1 = new FileInfo(destinationFilePath);

            //Delete file.
            //fileInfo.Delete();

            //Get directory path.
            string directoryPath = fileInfo1.DirectoryName;
            Console.WriteLine(directoryPath);

            //Check Exist.
            bool fileExists = fileInfo1.Exists;
            Console.WriteLine(fileExists);

            //Get Extension of file.
            string fileExtension = fileInfo.Extension;
            Console.WriteLine(fileExtension);

            //Get length
            long length = fileInfo1.Length;
            Console.WriteLine(length);
        }
    }
}
