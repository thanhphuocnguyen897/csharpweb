using System;
using System.Collections.Generic;

namespace ListGenericSample
{
    public class Example
    {
        static void Main(string[] args)
        {
            // Create a list of parts. 
            List<Part> parts = new List<Part>();
            // Add parts to the list.
            parts.Add(new Part() { PartName = "crank arm", PartID = 1234 });
            parts.Add(new Part() { PartName = "chain ring", PartID = 1334 });
            parts.Add(new Part() { PartName = "regular seat", PartID = 14430 });
            parts.Add(new Part() { PartName = "banana seat", PartID = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartID = 1534 });
            parts.Add(new Part() { PartName = "shift lever", PartID = 1634 });
            // Write out the parts in the list. This will call the overridden ToString method 
            // in the Part class.
            Console.WriteLine();
            foreach(Part apart in parts)
            {
                Console.WriteLine(apart);
            }

            // Check the list for part #1734. This calls the IEquatable.Equals method 
            // of the Part class, which checks the PartId for equality. 
            Console.WriteLine("\nContains(\"1734\"): {0}", parts.Contains(new Part { PartID = 1734, PartName = "" }));

            // Insert a new item at position 2. 
            Console.WriteLine("\n Insert(2, \"1834\")");
            parts.Insert(2, new Part() { PartName = "brake lever", PartID = 1834 });
            Console.WriteLine();
            foreach(Part apart in parts)
            {
                Console.WriteLine(apart);
            }

            Console.WriteLine("\nPart[3]: {0}", parts[3]);
            Console.WriteLine("\nRemove(\"1534\")");
            // This will remove part 1534 even though the PartName is different, 
            // because the Equals method only checks PartId for equality.
            parts.Remove(new Part() { PartID = 1534, PartName = "cogs" });

            Console.WriteLine();
            foreach(Part apart in parts)
            {
                Console.WriteLine(apart);
            }
            Console.WriteLine("\nRemoveAt(3)");
            // This will remove the part at index 3. 
            parts.RemoveAt(3);
            Console.WriteLine();
            foreach(Part apart in parts)
            {
                Console.WriteLine(apart);
            }
            /* 
   
             ID: 1234   Name: crank arm 
             ID: 1334   Name: chain ring 
             ID: 1434   Name: regular seat 
             ID: 1444   Name: banana seat 
             ID: 1534   Name: cassette 
             ID: 1634   Name: shift lever 
 
             Contains("1734"): False 
 
             Insert(2, "1834") 
             ID: 1234   Name: crank arm 
             ID: 1334   Name: chain ring 
             ID: 1834   Name: brake lever 
             ID: 1434   Name: regular seat 
             ID: 1444   Name: banana seat 
             ID: 1534   Name: cassette 
             ID: 1634   Name: shift lever 
 
             Parts[3]: ID: 1434   Name: regular seat 
 
             Remove("1534") 
 
             ID: 1234   Name: crank arm 
             ID: 1334   Name: chain ring 
             ID: 1834   Name: brake lever 
             ID: 1434   Name: regular seat 
             ID: 1444   Name: banana seat 
             ID: 1634   Name: shift lever 
 
             RemoveAt(3) 
 
             ID: 1234   Name: crank arm 
             ID: 1334   Name: chain ring 
             ID: 1834   Name: brake lever 
             ID: 1444   Name: banana seat 
             ID: 1634   Name: shift lever 
 
 
         */
        }
    }
    public class Part : IEquatable<Part>
    {
        public String PartName { get; set; }    
        public int PartID { get; set; }
        public override string ToString()
        {
            return "ID: " + PartID + " Name: " +PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return PartID;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartID.Equals(other.PartID));
        }
        // Should also override == and != operators. 
    }
}
