﻿using System;
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
    public partial class EmployeeDashboard: Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void lblAdminDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();  
            loginForm.Show();
            this.Close();
        }
    }
}
