using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PayrollSystem
{
    public partial class AddEditEmployeeForm: Form
    {
        public Employee Employee { get; private set; }
        public AddEditEmployeeForm(Employee emp = null)
        {
            InitializeComponent();
            Employee = emp ?? new Employee { Id = new Random().Next(1000, 9999) };


            if (emp != null)
            {
                txtName.Text = emp.Name;
                txtPosition.Text = emp.Position;
                txtSalary.Text = emp.Salary.ToString();
            }
        }

        private void AddEditEmployeeForm_Load(object sender, EventArgs e)

        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {

                MessageBox.Show("Please enter a name.");
                return;
            }

            Employee.Name = txtName.Text.Trim();
            Employee.Position = txtPosition.Text.Trim();
            Employee.Salary = decimal.Parse(txtSalary.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();


        }
    }
}
