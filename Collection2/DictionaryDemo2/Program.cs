using System;
using System.Collections.Generic;

namespace DictionaryDemo2
{
    public class Program
    {
        private static void AddToDictionary(Dictionary<String, Element> elements, string symbol, string name, int atomicNumber)
        {
            Element theElement = new Element();

            theElement.Symbol = symbol;
            theElement.Name = name;
            theElement.AtomicNumber = atomicNumber;
            elements.Add(key: theElement.Symbol, value: theElement);
        }

        //Normal method to build Dictionary.
        public static Dictionary<string, Element> BuildDictionary()
        {
            var elements = new Dictionary<String, Element>();

            AddToDictionary(elements, "K", "Potassium", 19);
            AddToDictionary(elements, "Ca", "Calcium", 20);
            AddToDictionary(elements, "Sc", "Scandium", 21);
            AddToDictionary(elements, "Ti", "Titanium", 22);

            return elements;
        }
        //Another method to build , Optional use BuildDictionary2() instead BuildDictionary!
        private static Dictionary<String, Element> BuildDictionary2()
        {
            return new Dictionary<string, Element>
            {
                {"K",
                    new Element() { Symbol = "K", Name = "Potassium", AtomicNumber = 19 } },
                {"Ca",
                    new Element() { Symbol="Ca", Name="Calcium", AtomicNumber=20 } },
                {"Sc",
                    new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
                {"Ti",
                    new Element() { Symbol="Ti", Name="Titanium", AtomicNumber=22}}
            };
        }

        //Find element use ContainKey and Item[TKey].
        private static void FindInDictionary(string symbol)
        {
            Dictionary<string, Element> elements = BuildDictionary2();
            if(elements.ContainsKey(symbol) == false)
            {
                Console.WriteLine(symbol + "not found");
            }
            else
            {
                Element theElement = elements[symbol];
                Console.WriteLine("found " + theElement.Name);
            }
        }

        //Use TryGetValue to find element!
        private static void FinInDictionary2(string symbol)
        {
            Dictionary<string, Element> elements = BuildDictionary();

            Element theElement = null;
            if (elements.TryGetValue(symbol, out theElement) == false) Console.WriteLine(symbol + " not found.");
            else Console.WriteLine("Found " + theElement.Name);
        }
        private static void Main()
        {
            Dictionary<String, Element> elements = BuildDictionary2();

            foreach (KeyValuePair<String, Element> kvp in elements)
            {
                Element theElement = kvp.Value;
                Console.WriteLine("key: " + kvp.Key);
                Console.WriteLine("value: " + theElement.Symbol + " " + theElement.Name + " " + theElement.AtomicNumber);
            }
            FindInDictionary("Ti");
            FinInDictionary2("Ca");
        }
    }
    public class Element
    {
        public String Symbol { get; set; }
        public String Name { get; set; }
        public int AtomicNumber { get; set; }
        
    }
}
