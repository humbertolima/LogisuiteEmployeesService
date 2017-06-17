using LogisuiteEmployeePresentation.LogisuiteEmployeeService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisuiteEmployeePresentation.Controllers
{
    public class PhoneNumberValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var employee = (Employee) validationContext.ObjectInstance;
            var phoneNumber = employee.Phone.ToString();
            var counter = 0;
            foreach (var i in phoneNumber)
            {
                counter++;
            }
            return (counter == 10)
                ? ValidationResult.Success
                : new ValidationResult("The phone number is incorrect(Should have 10 digits)");
        }
    }
}
