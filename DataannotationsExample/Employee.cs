using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataannotationsExample
{
    internal class Employee
    {
        [Required(ErrorMessage = "Employe {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Number of characters sholud be minimus 3 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Range(18, 99, ErrorMessage = "Age should be between 18 to 99")]
        public int Age { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
