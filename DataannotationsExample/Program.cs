using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DataannotationsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Shivani";
            employee.Age = 20;
            employee.PhoneNumber = "62641abcd";
            employee.Email = "shivani@gmail";

            ValidationContext context = new ValidationContext(employee, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employee, context, result, true);

            if (!valid)
            {
                foreach (ValidationResult vr in result)
                {
                    Console.WriteLine("Member name {0}", vr.MemberNames.First());
                    Console.WriteLine("Error message {0} {1}", vr.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name :" + employee.Name + ", Age : " + employee.Age + ", Phone Number : " + employee.Name + ", Email : " + employee.Email);
            }
        }
            

    }
}
