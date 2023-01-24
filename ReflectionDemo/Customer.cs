using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionDemo
{
    internal class Customer
    {
        //properties
        public int ID { get; set; }
        public string Name { get; set; }
        //constructors
        public Customer()
        {
            this.ID = -1;
            this.Name = string.Empty;
        }

        public Customer(int id, string name)
        {
            this.ID = id;
            this.Name = name;

        }


        //methods
        public void PrintID()
        {
            Console.WriteLine("ID is {0}", this.ID);
        }
        public void PrintName()
        {
            Console.WriteLine("Name is {0}", this.Name);
        }
    }
}
