using System;
using System.Collections;

namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("Shivani");
            queue.Enqueue("Patidar");
            queue.Enqueue('s');
            queue.Enqueue(1903);
            queue.Enqueue(17.19);
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After deleting the element");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
