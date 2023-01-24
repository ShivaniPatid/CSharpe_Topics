using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexExample
{
    internal class ValidEmail
    {
        public static void ValidateEmail()
        {
            Console.WriteLine("Enter a email");
            string email = Console.ReadLine();

            string pattern = @"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$";

            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("Email is valid...");
            }
            else
            {
                Console.WriteLine("Email is not valid... Please enter a valid email address");
            }
        }
    }
}
