using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            AddRecords(list);
            RetriveRecodesBet13to18(list);
            RetriveTwoRecodes(list);
            RetriveAverageAge(list);
            CheckSpecificName(list);
            SkipRecordsLessthan60(list);
            RemoveSpecificName(list);
        }

        private static void AddRecords(List<Person> list)
        {
            list.Add(new Person("12345", "Shivani", "street 1", 15));
            list.Add(new Person("12346", "Arpita", "street 2", 62));
            list.Add(new Person("12347", "Komal", "street 3", 65));
            list.Add(new Person("12348", "Rajat", "street 4", 45));
            list.Add(new Person("12349", "Komal", "street 5", 14));


        }

        private static void RetriveRecodesBet13to18(List<Person> list)
        {
            foreach(Person person in list.FindAll(s => (s.Age < 18 && s.Age > 13 )).ToList())
            {
                Console.WriteLine("Name : "+person.Name+" Age : "+person.Age);
            }

        }

        private static void RetriveTwoRecodes(List<Person> list)
        {
            foreach (Person person in list.FindAll(s => (s.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + " Age : " + person.Age);
            }

        }

        private static void RetriveAverageAge(List<Person> list)
        {
            double aveAge = list.Average(s => s.Age);
            Console.WriteLine("Average of Ages : " + aveAge);
        }

        private static void CheckSpecificName(List<Person> list)
        {
            bool val = list.Any(s => s.Name == "Rajat");
            if(val)
            {
                Console.WriteLine("Name is present in the list");
            }
            else
            {
                Console.WriteLine("Name is present in the list");

            }
        }

        private static void SkipRecordsLessthan60(List<Person> list)
        {
            foreach (Person person in list.FindAll(s => (s.Age > 60)))
            {
                Console.WriteLine("Name : " + person.Name + " Age : " + person.Age);
            }

        }
        private static void RemoveSpecificName(List<Person> list)
        {
            int count = list.RemoveAll(s => s.Name == "Komal");
            foreach(Person person in list)
            {
                Console.WriteLine("SSN : "+person.SSN+" Name : "+person.Name+" Address : "+person.Address+" Age : "+person.Age);

            }
            Console.WriteLine("total remone records : "+count);
        }
    }
}
