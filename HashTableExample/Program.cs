using System;
using System.Collections;

namespace HashTableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("A1", "Hello");
            hashtable.Add("A2", "Good Morning");
            hashtable.Add("A3", "India");
            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0} and {1}",entry.Key, entry.Value);
            }
            Console.WriteLine("After deleting the element");
            hashtable.Remove("A3");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0} and {1}", entry.Key, entry.Value);
            }
        }
    }
}
