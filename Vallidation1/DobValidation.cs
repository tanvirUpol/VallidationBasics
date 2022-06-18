using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vallidation1
{
    public class DobValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
           if(value != null)
            {
                string dob = value.ToString();
                DateTime MyDate = DateTime.Parse(dob);
                if((DateTime.Today.Year - MyDate.Year) >= 18)
                {
                    return ValidationResult.Success;
                }


            }
            ErrorMessage = ErrorMessage ?? "Age must be 18 or above";
            return new ValidationResult(ErrorMessage);
        }
    }
}