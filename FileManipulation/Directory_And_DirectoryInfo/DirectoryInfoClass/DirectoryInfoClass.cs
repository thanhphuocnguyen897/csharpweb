using System;
using System.IO;

namespace DirectoryInfoClass
{
    class DirectoryInfoClass
    {
        static void Main()
        {
            string sourceDirPath = @"D:\MyData\Data";
            DirectoryInfo directory = new DirectoryInfo(sourceDirPath);

            //Create a directory
            directory.Create();

            //Delete a directory
            //bool deleteRecursive = true;
            //directory.Delete(deleteRecursive);

            //Check exist
            bool directoryExists = directory.Exists;
            Console.WriteLine(directoryExists);

            //Get full path
            string fullPath = directory.FullName;
            Console.WriteLine(fullPath);

            //Get directories
            string directoryPath = @"D:\C#";
            DirectoryInfo path = new DirectoryInfo(directoryPath);
            DirectoryInfo[] subDirectories = path.GetDirectories();
            foreach(DirectoryInfo info in subDirectories)
            {
                Console.WriteLine(info);
            }
            Console.WriteLine();

            //Get files
            string filesPath = @"D:\Pictures\Saved Pictures";
            DirectoryInfo pathFile = new DirectoryInfo(filesPath);
            FileInfo[] subFiles = pathFile.GetFiles();
            foreach(FileInfo file in subFiles)
            {
                Console.WriteLine(file);
            }
        }
    }
}
