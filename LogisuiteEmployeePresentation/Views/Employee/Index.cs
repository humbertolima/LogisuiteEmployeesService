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
using LogisuiteEmployeePresentation.Views.Employee;
using System.Runtime.InteropServices;

namespace LogisuiteEmployeePresentation.Views.Employee
{
    public partial class Index : Form
    {
        
        public Index()
        {
            InitializeComponent();
            
        }
        
        private void DecorateTheGridView()
        {
            IndexDataGridView.Columns[2].HeaderText = @"Last Name";
            IndexDataGridView.Columns[3].HeaderText = @"Date of Birth";
            IndexDataGridView.Columns[4].HeaderText = @"Annual Salary";
            IndexDataGridView.Columns[6].HeaderText = @"Phone Number";
            IndexDataGridView.Columns[7].HeaderText = @"Social Security";
            IndexDataGridView.Columns[3].DefaultCellStyle.Format = "d MMM yyyy";
            IndexDataGridView.Columns[4].DefaultCellStyle.Format = "C";
            
        }

        public void Initialize()
        {
            this.IndexDataGridView.DataSource = EmployeesController.ViewAll();
            DecorateTheGridView();
            label3.Text = @"Total de Registros: " + IndexDataGridView.Rows.Count;
        }
        private void Index_Load(object sender, EventArgs e)
        {
            
            Initialize();
            
        }

        private void IndexDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var employee = new LogisuiteEmployeeService.Employee()
                {

                    Id = (int)IndexDataGridView.SelectedCells[0].Value,
                    Name = IndexDataGridView.SelectedCells[1].Value.ToString(),
                    LastName = IndexDataGridView.SelectedCells[2].Value.ToString(),
                    DateofBirth = (DateTime)IndexDataGridView.SelectedCells[3].Value,
                    AnnualSalary = (decimal)IndexDataGridView.SelectedCells[4].Value,
                    Address = IndexDataGridView.SelectedCells[5].Value.ToString(),
                    Phone = (long)IndexDataGridView.SelectedCells[6].Value,
                    SocialSecurityNumber = (long)IndexDataGridView.SelectedCells[7].Value
                };

               
                var employeeForm = new EmployeeForm(employee);
                employeeForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Please select the whole row!!!");
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var idToDelete= (int) (IndexDataGridView.SelectedCells[0].Value);
                if (MessageBox.Show(@"Sure you want to delete this register?", @"Delete", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning) != DialogResult.OK) return;
                var result = EmployeesController.Delete(idToDelete);
                Index_Load(sender, e);
                MessageBox.Show(result == 1 

                    ? @"The register successfully deleted" 
                    : @"The employee is not regitered");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Please select the whole row!!!");
            }

        }

       
        private void Index_Enter(object sender, EventArgs e)
        {
            Index_Load(sender, e);
        }

        private void Index_Activated(object sender, EventArgs e)
        {
            Initialize();
        }

        private void IndexDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.IndexDataGridView.DataSource = EmployeesController.Search(txtSearch.Text);
            DecorateTheGridView();
        }

        private void Index_ResizeEnd(object sender, EventArgs e)
        {
            
        }
    }
}
