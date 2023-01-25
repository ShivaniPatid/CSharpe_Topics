using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressionsExample
{
    internal class Person
    {
        public string SSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        
        public Person(string ssn, string name, string address, int age)
        {
            SSN = ssn;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}
