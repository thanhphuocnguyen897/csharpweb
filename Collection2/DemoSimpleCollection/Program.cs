using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DemoSimpleCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //set and get all element with foreach
            /*var salmons = new List<String>();
            salmons.Add("Chinok");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }*/

            //set collection initializer and get:
            //var salmons = new List<String> { "chinook", "coho", "pink", "sockeye" };
            //foreach (var salmon in salmons)
            //{
            //    Console.Write(salmon + " ");
            //}

            //use for instead foreach to get element
            /*var salmons = new List<String> { "chinook", "coho", "pink", "sockeye" };
            for(int index = 0; index<salmons.Count; index++)
            {
                Console.Write(salmons[index] + " ");
            }*/

            //Remove a element from list
            /*var salmons = new List<String> { "chinook", "coho", "pink", "sockeye" };
            salmons.Remove("coho");
            foreach(var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }*/

            //Remove a element with index:
            /*var salmons = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (var index = salmons.Count-1; index >= 0; index--)
            {
                if(salmons[index]%2 == 1)
                {
                    salmons.RemoveAt(index);
                }
            }
            salmons.ForEach(
                salmon => Console.WriteLine(salmon + " "));*/

            //You can define a class with List<T>
            var theGalaxies = new List<Galaxy>
            {
                new Galaxy() { Name = "Tadpole", MegaLightYears = 400 },
                new Galaxy() { Name = "Pinwheel", MegaLightYears = 25 },
                new Galaxy() { Name = "Milky Way", MegaLightYears = 0 },
                new Galaxy() { Name = "Andromeda", MegaLightYears = 3 },
            };
            foreach(Galaxy galaxy in theGalaxies)
            {
                Console.WriteLine(galaxy.Name + " " + galaxy.MegaLightYears);
            }
        }
        public class Galaxy
        {
            public string Name { get; set; }
            public int MegaLightYears { get; set; }
        }
    }
}
