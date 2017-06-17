using LogisuiteEmployeePresentation.LogisuiteEmployeeService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisuiteEmployeePresentation.Controllers
{
    public class BirthDateValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var employee = (Employee)validationContext.ObjectInstance;
            var age = DateTime.Now.Year - employee.DateofBirth.Year;
            return (age > 18) ? ValidationResult.Success : new ValidationResult("The customer shoul be 18 years old");
        }
    }
}
