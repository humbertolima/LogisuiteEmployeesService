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

        private string CheckPhoneAndSocialSecNumbers(Employee value, out bool result)
        {
            var response = "The employee was saved successfully";
            result = true;
            foreach (var item in _context.Employees)
            {
                if (item.Id == value.Id) continue;
                if (item.Phone == value.Phone)
                {
                    response = "There is an employee with the same phone number";
                    result = false;
                }
                if (item.SocialSecurityNumber != value.SocialSecurityNumber) continue;
                response = "There is an employee with the same social security number";
                result = false;
            }


            return response;
        }

        [WebMethod(Description = "View the list of all employees from the data base")]
        public List<Employee> ViewAll()
        {
            return _context.Employees.ToList();
        }

        [WebMethod(Description = "Update an employee")]
        public string Update(Employee value, out bool result)
        {
            result = false;
            var response = CheckPhoneAndSocialSecNumbers(value, out bool test);
            if (!test) return response;
            _context.UpdateValue(value.Id, value.Name, value.LastName, value.DateofBirth, value.AnnualSalary, value.Address,
                value.Phone,
                value.SocialSecurityNumber);
            result = true;


            return response;
        }

        [WebMethod(Description = "Insert an employee to the data base")]
        public string  Insert(Employee value, out bool result)
        {

            result = false;
            var response = CheckPhoneAndSocialSecNumbers(value, out bool test);
            if (!test) return response;
            _context.InsertValue(value.Name, value.LastName, value.DateofBirth, value.AnnualSalary, value.Address,
                value.Phone,
                value.SocialSecurityNumber);
            result = true;


            return response;
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

        [WebMethod]
        public List<Employee> Search(string value)
        {
            return _context.Employees.Where(x => x.Name.Contains(value) || x.LastName.Contains(value) || x.Address.Contains(value)).ToList();
        }
    }
}
