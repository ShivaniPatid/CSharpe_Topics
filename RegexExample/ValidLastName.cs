using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexExample
{
    internal class ValidLastName
    {
        public static void ValidateLastName()
        {
            Console.WriteLine("Enter the Last Name");
            string lastName = Console.ReadLine();

            string pattern = "^[A-Z]{1}[a-z]{2,}$";

            if (Regex.IsMatch(lastName, pattern))
            {
                Console.WriteLine("Last name is valid...");
            }
            else
            {
                Console.WriteLine("Invalid last name... Please enter a valid last name");
            }
        }
    }
}
