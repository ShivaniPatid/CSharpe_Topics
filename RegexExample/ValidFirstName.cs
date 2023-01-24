using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexExample
{
    internal class ValidFirstName
    {
        public static void ValidateFirstName()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(firstName, pattern))
            {
                Console.WriteLine("Valid first name");
            }
            else
            {
                Console.WriteLine("Invalid first name... Please enter a valid first name");
            }
        }
    }
}
