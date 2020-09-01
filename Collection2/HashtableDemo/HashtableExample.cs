using System;
using System.Collections;

namespace HashtableDemo
{
    class HashtableExample
    {
        static void Main(string[] args)
        {
            Hashtable openwith = new Hashtable();
            //add
            openwith.Add("txt", "notepad.exe");
            openwith.Add("bmp", "paint.exe");
            openwith.Add("dib", "paint.exe");
            openwith.Add("rtf", "wordpad.exe");
            // The Add method throws an exception if the new key is  
            // already in the hash table. 
            try
            {
                openwith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with key = \"txt\" already exists.");
            }
            // The Item property is the default property, so you  
            // can omit its name when accessing elements.  
            Console.WriteLine("For key = \"rtf\", value = {0}.", openwith["rtf"]);
            // The default Item property can be used to change the value 
            // associated with a key. 
            openwith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value {0}.", openwith["rtf"]);
            // If a key does not exist, setting the default Item property 
            // for that key adds a new key/value pair. 
            openwith["doc"] = "winword.exe";
            // ContainsKey can be used to test keys before inserting  
            // them. 
            if (!openwith.ContainsKey("ht"))
            {
                openwith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value add for key = \"ht\": {0}", openwith["ht"]);
            }
            // When you use foreach to enumerate hash table elements, 
            // the elements are retrieved as KeyValuePair objects. 
            Console.WriteLine();
            foreach(DictionaryEntry de in openwith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
            // To get the values alone, use the Values property. 
            ICollection valueColl = openwith.Values;
            // The elements of the ValueCollection are strongly typed 
            // with the type that was specified for hash table values. 
            Console.WriteLine();
            foreach(string s in valueColl)
            {
                Console.WriteLine("Value = {0}.", s);
            }
            // To get the keys alone, use the Keys property. 
            ICollection keyColl = openwith.Keys;
            // The elements of the KeyCollection are strongly typed 
            // with the type that was specified for hash table keys. 
            foreach(string s in keyColl)
            {
                Console.WriteLine("Key = {0}.", s);
            }
            //Use the remove method to remove a key/value pair.
            Console.WriteLine("\nRemove(\"doc\")");
            openwith.Remove("doc");
            if (!openwith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }
        }
    }
}
