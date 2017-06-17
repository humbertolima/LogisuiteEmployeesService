using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogisuiteEmployeePresentation.Controllers;

namespace LogisuiteEmployeePresentation.Views.Employee
{
    public partial class EmployeeForm : Form
    {
        private LogisuiteEmployeeService.Employee _employee;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(LogisuiteEmployeeService.Employee employee)
        {
            InitializeComponent();
            this._employee = employee;
        }

        private void InitializeForm()
        {
            if (_employee == null)
            {
                _employee = new LogisuiteEmployeeService.Employee();
            }
            else
            {
                txtName.Text = _employee.Name;
                txtLastName.Text = _employee.LastName;
                txtAddress.Text = _employee.Address;
                txtAnnualSalary.Text = _employee.AnnualSalary.ToString("N");
                txtPhone.Text = _employee.Phone.ToString();
                txtSocialSecurity.Text = _employee.SocialSecurityNumber.ToString();
                txtDateofBirth.Text = _employee.DateofBirth.ToString("d MMM yyyy");
            }
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

        private void BuildEmployee()
        {
            _employee.Name = txtName.Text;
            _employee.LastName = txtLastName.Text;
            _employee.Address = txtAddress.Text;
            _employee.AnnualSalary = decimal.Parse(txtAnnualSalary.Text);
            _employee.DateofBirth = DateTime.Parse(txtDateofBirth.Text);
            _employee.SocialSecurityNumber = long.Parse(txtSocialSecurity.Text);
            _employee.Phone = long.Parse(txtPhone.Text);
        }

        private void Details_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Focus();
            this.Close();
            
        }

        private void txtDateofBirth_Validating(object sender, CancelEventArgs e)
        {
            DateTime time;
            var result = DateTime.TryParse(txtDateofBirth.Text, out time);
            if (!result)
            {
                MessageBox.Show(@"The Date of Birth field must be a valid date type", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDateofBirth.Text = _employee.DateofBirth.ToString("d MMM yyyy");
                txtDateofBirth.Focus();
            }
            if (!IsDateofBirthValid(DateTime.Parse(txtDateofBirth.Text)))
            {
                MessageBox.Show(@"The Employee must be over 18 years old", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDateofBirth.Text = _employee.DateofBirth.ToString("d MMM yyyy");
                txtDateofBirth.Focus();
            }
        }

        private void txtAnnualSalary_Validating(object sender, CancelEventArgs e)
        {
            decimal salary;
            var result = decimal.TryParse(txtAnnualSalary.Text, out salary);
            if (!result)
            {
                MessageBox.Show(@"The Annual Salary field must be a valid numerical type", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnnualSalary.Text = _employee.AnnualSalary.ToString("N");
                txtAnnualSalary.Focus();
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            long pnone;
            var result = long.TryParse(txtPhone.Text, out pnone);
            if (!result)
            {
                MessageBox.Show(@"The Annual Salary field must be a valid numerical type", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Text = _employee.Phone.ToString();
                txtPhone.Focus();
            }
            if (!IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show(@"The Phone Number field must be 10 digits", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Text = _employee.Phone.ToString();
                txtPhone.Focus();
            }

        }

        private void txtSocialSecurity_Validating(object sender, CancelEventArgs e)
        {
            long social;
            var result = long.TryParse(txtSocialSecurity.Text, out social);
            if (!result)
            {
                MessageBox.Show(@"The Social Security field must be a valid numerical type", @"Invalid Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSocialSecurity.Text = _employee.SocialSecurityNumber.ToString();
                txtSocialSecurity.Focus();
            }
            if (!IsValidSocial(txtSocialSecurity.Text))
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
                BuildEmployee();
                EmployeesController.Save(_employee);
                this.Close();
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(@"Please fill all the fields");
            }

        }
    }
}
