using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Validations
{
   public class ConfirmPasswordAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;
            string password = (validationContext.ObjectInstance as User).Password;
            if (value.Equals(password))
                return null;
            return new ValidationResult("date begin project less than today");
        }
    }
}
