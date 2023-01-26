using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Shivani");
           var newNode = list.AddLast("Arpita");
            list.AddLast("Rajat");
            list.AddLast("Kuldeep");
            list.AddLast("Aman");
            list.AddFirst("Aastha");
            list.AddBefore(newNode, "Rajat");
            foreach(string str in list)
            {
                Console.WriteLine(str);
            }

            list.RemoveFirst();
            list.RemoveLast();
            list.Remove("Rajat");
            Console.WriteLine("----------------------");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
}
