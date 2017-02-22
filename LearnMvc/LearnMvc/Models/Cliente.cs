using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearnMvc.Models
{
    public class FirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) // Checking for Empty Value
            {
                return new ValidationResult("Please Provide First Name");
            }
            else
            {
                if (value.ToString().Contains("@"))
                {
                    return new ValidationResult("First Name should Not contain @");
                }
            }
            return ValidationResult.Success;
        }
    }

    public class Cliente
    {
        [Key]
        public int id { get; set; }
        //[Required(ErrorMessage = "Enter Nombre")]
        public string Nombre { get; set; }
        //[Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }
        //[Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}