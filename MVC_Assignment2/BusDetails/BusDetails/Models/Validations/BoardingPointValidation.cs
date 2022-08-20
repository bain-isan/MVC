using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BusDetails.Models.Validations
{
    public class BoardingPointValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string str = value.ToString();
                if (str == "BGL" || str == "CHN" || str == "HYD" || str == "MUM" || str == "PUN")
                    return ValidationResult.Success;
            }
            return new ValidationResult("Please Enter Valid Boarding Point...");
        }
    }
}