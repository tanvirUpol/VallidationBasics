using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vallidation1.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please enter your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DobValidation(ErrorMessage = "User must be 18 or above")]
        public DateTime Dob { get; set; }
    }
}