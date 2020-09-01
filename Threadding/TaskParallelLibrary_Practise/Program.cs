using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TaskParallelLibrary_Practise
{
    class Program
    {
        private static string ROOTFOLDER = @"D:\temp\fromfolder";
        private static string DESTINATIONFOLDER = @"D:\temp\tofolder";
        static void Main()
        {
            string[] folders = new string[]{
                "A", "B", "C" };
            Console.WriteLine("Starting Copy");
            List<Task> tasks = new List<Task>();
            foreach (var folder in folders)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    var files = Directory.EnumerateFiles(Path.Combine(ROOTFOLDER, folder),"*");
                    foreach (var file in files)
                    {
                        Console.WriteLine(file);
                        File.Copy(file, Path.Combine(DESTINATIONFOLDER, Path.GetFileName(file)));
                        Console.WriteLine(file + " is copied successfully.");
                    }
                }));
            }
            Task.WhenAll(tasks.ToArray());
            Console.ReadLine();
        }
    }
}
