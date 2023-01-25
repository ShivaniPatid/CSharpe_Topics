using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    internal class Program
    {

        public static void PrintArray<T>(T[] inputArray)
        {
            foreach (T item in inputArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(typeof(T));
        }
        static void Main(string[] args)
        {
            
            MaximumNumber maximumNumber = new MaximumNumber();
            Console.WriteLine("Maximum number is : "+ maximumNumber.PrintMaximumNumber(30, 50, 10));
            int value1 = maximumNumber.PrintMaximumNumber<int>(30, 50, 10);
            Console.WriteLine("Maximum integer number is : " + value1);
            float value2 = maximumNumber.PrintMaximumNumber(2.5f, 5.5f, 7.5f);
            Console.WriteLine("Maximum float number is " + value2);
           

            int[] intArray = { 1, 2, 3 };
            float[] floatArray = { 1.5f, 2.5f, 3.5f };
            string[] stringArray = { "Shivani", "Rajat", "Arpita" };

            //generic class
            new Print<int>(intArray).PrintArray();
            new Print<float>(floatArray).PrintArray();
            new Print<string>(stringArray).PrintArray();


            //generic method
            Program.PrintArray<int>(intArray);
            Program.PrintArray<float>(floatArray);
            Program.PrintArray<string>(stringArray);


            Employee employee1 = new Employee()
            {
                Name = "Shivani",
                Age = 22,
                Address = "Ujjain"

            };
            Employee employee2 = new Employee()
            {
                Name = "Arpita",
                Age = 21,
                Address = "Indore"

            };
            Employee employee3 = new Employee()
            {
                Name = "Rjata",
                Age = 26,
                Address = "Pune"

            };

            List<Employee> employee = new List<Employee>();
            employee.Add(employee1);
            employee.Add(employee2);
            employee.Add(employee3);

            foreach (Employee e in employee)
            {
                Console.WriteLine("Employee name is {0} age is {1} address is {2} ", e.Name, e.Age, e.Address);
            }

            ArithmeticOperation arithmaticOperation = new ArithmeticOperation();
            Console.WriteLine("Division is : " + arithmaticOperation.Division<int>(20, 5));

        }
    }
}
