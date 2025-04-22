using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class AdminDashboard: Form
    {
        private List<Employee> employees;
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnEmployeeMgmt_Click(object sender, EventArgs e)
        {
            var form = new employeeManagement();
            form.ShowDialog();
        }
        private void btnPayroll_Click_1(object sender, EventArgs e)
        {

            var form = new PayrollProcessForm(employees);
            form.ShowDialog();
        }
    }
}
