using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FootblallLeagueManagement.Models.Validations
{
    public class StatusValidation : ValidationAttribute
    { 
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string str = value.ToString();
                if (str.Equals("WIN") || str.Equals("DRAW"))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Please Enter 'Win' or 'Draw'");
        }
    }
}