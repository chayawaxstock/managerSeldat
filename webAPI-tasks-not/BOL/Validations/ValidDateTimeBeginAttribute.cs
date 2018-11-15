﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Validations
{
  public class ValidDateTimeBeginAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;

            if (DateTime.Parse(value.ToString()).Date >= (DateTime.Parse(DateTime.Now.ToString()).Date))
                return null;
           return new ValidationResult("date begin project less than today");
        }

    }
}
