using System;
using System.Collections;

namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            //insert the element
            stack.Push("Shivani");
            stack.Push("Patidar");
            stack.Push('s');
            stack.Push(1903);
            stack.Push(17.19);
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Top most element of the statck is : "+stack.Peek());
            stack.Pop();
            Console.WriteLine("After deleting the element ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
