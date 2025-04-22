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
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';

            txtUsername.Text = "admin";
            txtPassword.Text = "admin123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin123")
            {
                this.Hide();
                AdminDashboard adminForm = new AdminDashboard();
                adminForm.Show();
            }

            else if (username == "employee" && password == "emp123")
            {
                this.Hide();
                EmployeeDashboard empForm = new EmployeeDashboard();
                empForm.Show();
            }

            else
            {
                MessageBox.Show("Invalid username or pass",
                              "Login Failed",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
          
                txtPassword.Text = "";
                txtPassword.Focus();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
