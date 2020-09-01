using System;
using System.IO;

namespace DirectorClass
{
    class DirectoryClass
    {
        static void Main()
        {
            string sourceDirPath = @"D:\MyData\Data";
            //Create a directory with sourceDirPath.
            Directory.CreateDirectory(sourceDirPath);

            //Delect directory:
            bool deleteRecursively = true; //Delete directory content;
            Directory.Delete(sourceDirPath, deleteRecursively);

            //Check exist?
            bool tempDatatDirectoryExists = Directory.Exists(sourceDirPath);
            Console.WriteLine(tempDatatDirectoryExists);

            //Get array Directories Folder: 
            string directoryPath = @"D:\C#";
            string[] subDirectories = Directory.GetDirectories(directoryPath);
            foreach (string directories in subDirectories)
            {
                Console.WriteLine(directories); ;
            }

            //Get files in a directory
            string filesPath = @"D:\Pictures\Saved Pictures";
            string[] files = Directory.GetFiles(filesPath);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
