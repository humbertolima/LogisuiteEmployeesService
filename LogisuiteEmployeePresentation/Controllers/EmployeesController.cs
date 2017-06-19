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

        public static string Save(Employee value, out bool test)
        {
            return Client.Save(value, out test );

        }

        public static int Delete(int id)
        {
            return Client.Delete(id);
        }
    }
}
