using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    internal class Print<T>
    {
        private T[] inputArry;

        public Print(T[] inputArry)
        {
            this.inputArry = inputArry;
        }

        public void PrintArray()
        {
            foreach(var i in inputArry)
            {
                Console.WriteLine(i);
            }
        }
    }
}
