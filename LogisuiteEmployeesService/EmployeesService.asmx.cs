using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Services;
using LogisuiteEmployeesService.Model;

namespace LogisuiteEmployeesService
{
    /// <summary>
    /// Summary description for EmployeesService
    /// </summary>
    [WebService(Namespace = "http://logisuite/employees/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class EmployeesService : System.Web.Services.WebService
    {
        private readonly LogisuiteEntities _context = new LogisuiteEntities();
        [WebMethod(Description = "View the list of all employees from the data base")]
        public List<Employee> ViewAll()
        {
            return _context.Employees.ToList();
        }

        [WebMethod(Description = "Insert or Update an employee's properties")]
        public string Save(Employee value, out bool test)
        {
            
            var result = "The employee was saved successfully";
            if (_context.Employees.SingleOrDefault(x => x.SocialSecurityNumber == value.SocialSecurityNumber) !=
                null)
            {
                result = "There is already and employee with the same social security number";
                test = false;
            }
            else if (_context.Employees.SingleOrDefault(x => x.Phone == value.Phone) != null)
            {
                result = "There is already and employee with the same phone number";
                test = false;
            }
            else if (value.Id == 0)
            {
                _context.InsertValue(value.Name, value.LastName, value.AnnualSalary, value.Address, value.Phone,
                    value.SocialSecurityNumber);
                test = true;
            }
            else
            {
                //var employeeToEdit = _context.Employees.Single(v => v.Id == value.Id);
                //employeeToEdit.Name = value.Name;
                //employeeToEdit.LastName = value.LastName;
                //employeeToEdit.Address = value.Address;
                //employeeToEdit.DateofBirth = value.DateofBirth;
                //employeeToEdit.AnnualSalary = value.AnnualSalary;
                //employeeToEdit.Phone = value.Phone;
                //employeeToEdit.SocialSecurityNumber = value.SocialSecurityNumber;

                _context.UpdateValue(value.Id, value.Name, value.LastName, value.AnnualSalary, value.Address,
                    value.Phone, value.SocialSecurityNumber);
                test = true;


            }
            _context.SaveChanges();
            return result;
        }

        [WebMethod(Description = "Delete an employee from the data base")]
        public int Delete(int id)
        {

            return _context.DeleteValue(id);

        }

        [WebMethod(Description = "Select an Employee from the data base")]
        public Employee Select(int id)
        {
            return _context.Employees.SingleOrDefault(v => v.Id == id);
        }
    }
}
