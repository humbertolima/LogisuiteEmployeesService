using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisuiteEmployeePresentation.LogisuiteEmployeeService;
using System.Web.ModelBinding;

namespace LogisuiteEmployeePresentation.Controllers
{
    public class EmployeesController
    {
        private static readonly EmployeesServiceSoapClient Client = new EmployeesServiceSoapClient();

        public static List<Employee> ViewAll()
        {
            return Client.ViewAll().ToList();
        }

        public static Employee Select(int id)
        {
            return Client.Select(id);
        }

        public static string Save(Employee value, out bool result)
        {
            return value.Id == 0 ? Client.Insert(value, out result) : Client.Update(value, out result);
        }
        
        public static int Delete(int id)
        {
            return Client.Delete(id);
        }

        public static List<Employee> Search(string name)
        {
            return Client.Search(name).ToList();
        }
    }
}
