using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogisuiteEmployeePresentation.Controllers;

namespace LogisuiteEmployeePresentation.Views.Employee
{
    public partial class EmployeeForm : Form
    {
        private readonly LogisuiteEmployeeService.Employee _employee;
        public EmployeeForm()
        {
            _employee = new LogisuiteEmployeeService.Employee();
            InitializeComponent();
        }

        public EmployeeForm(LogisuiteEmployeeService.Employee employee)
        {
            InitializeComponent();
            this._employee = employee;
        }

        private void InitializeForm()
        {
            
                txtName.Text = _employee.Name;
                txtLastName.Text = _employee.LastName;
                txtAddress.Text = _employee.Address;
                txtAnnualSalary.Text = _employee.AnnualSalary.ToString("N");
                txtPhone.Text = _employee.Phone.ToString();
                txtSocialSecurity.Text = _employee.SocialSecurityNumber.ToString();
                txtDateofBirth.Text = _employee.DateofBirth.ToString("d MMM yyyy");
           
        }

        private bool IsFormValid()
        {
            return (txtName.Text != string.Empty && txtLastName.Text != string.Empty && txtAddress.Text != string.Empty
                    && txtAnnualSalary.Text != string.Empty && txtDateofBirth.Text != string.Empty &&
                    txtPhone.Text != string.Empty
                    && txtSocialSecurity.Text != string.Empty)
                ? true
                : false;
        }

        private static bool IsValidSocial(string value)
        {
            var counter = value.Count();
            return (counter == 9);
        }

        private static bool IsValidPhone(string value)
        {
            var counter = value.Count();
            return (counter == 10);
        }

        private static bool IsDateofBirthValid(DateTime value)
        {
            return (DateTime.Now.Year - value.Year) > 18;
        }

        private LogisuiteEmployeeService.Employee BuildEmployee()
        {
           
                return new LogisuiteEmployeeService.Employee()
                    {
                        Id = _employee.Id,
                        Name = txtName.Text,
                        LastName = txtLastName.Text,
                        Address = txtAddress.Text,
                        AnnualSalary = decimal.Parse(txtAnnualSalary.Text),
                        DateofBirth = DateTime.Parse(txtDateofBirth.Text),
                        SocialSecurityNumber = long.Parse(txtSocialSecurity.Text),
                        Phone = long.Parse(txtPhone.Text)
                    }
                    ;
            
        }

        private void Details_Load(object sender, EventArgs e)
        {
            InitializeForm();
           
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void txtDateofBirth_Validating(object sender, CancelEventArgs e)
        {
            
            var result = DateTime.TryParse(txtDateofBirth.Text, out DateTime time);
            if (!result)
            {
                MessageBox.Show(@"The Date of Birth field must be a valid date type", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDateofBirth.Text = _employee.DateofBirth.ToString("d MMM yyyy");
                txtDateofBirth.Focus();
            }
            else if (!IsDateofBirthValid(DateTime.Parse(txtDateofBirth.Text)))
            {
                MessageBox.Show(@"The Employee must be over 18 years old", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDateofBirth.Text = _employee.DateofBirth.ToString("d MMM yyyy");
                txtDateofBirth.Focus();
            }
        }

        private void txtAnnualSalary_Validating(object sender, CancelEventArgs e)
        {
            var result = decimal.TryParse(txtAnnualSalary.Text, out decimal salary);
            if (result) return;
            MessageBox.Show(@"The Annual Salary field must be a valid numerical type", @"Invalid Field",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtAnnualSalary.Text = _employee.AnnualSalary.ToString("N");
            txtAnnualSalary.Focus();
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            var result = long.TryParse(txtPhone.Text, out long pnone);
            if (!result)
            {
                MessageBox.Show(@"The Phone Number field must be a valid numerical type", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Text = _employee.Phone.ToString();
                txtPhone.Focus();
            }
            else if (!IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show(@"The Phone Number field must be 10 digits", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Text = _employee.Phone.ToString();
                txtPhone.Focus();
            }

        }

        private void txtSocialSecurity_Validating(object sender, CancelEventArgs e)
        {
            var result = long.TryParse(txtSocialSecurity.Text, out long social);
            if (!result)
            {
                MessageBox.Show(@"The Social Security field must be a valid numerical type", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSocialSecurity.Text = _employee.SocialSecurityNumber.ToString();
                txtSocialSecurity.Focus();
            }
            else if (!IsValidSocial(txtSocialSecurity.Text))
            {
                MessageBox.Show(@"The Social Security field must be 9 digits", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSocialSecurity.Text = _employee.SocialSecurityNumber.ToString();
                txtSocialSecurity.Focus();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = BuildEmployee();
                MessageBox.Show(EmployeesController.Save(employee, out bool result));
                if(result)
                    Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Please fill all the fields");
            }
            

        }
    }
}
