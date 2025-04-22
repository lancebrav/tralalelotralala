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
    public partial class PayrollProcessForm: Form
    {
        private List<Employee> employees;
        private const decimal OvertimeRate = 1.5m;

        public PayrollProcessForm(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            cmbEmployees.DataSource = employees;
            cmbEmployees.DisplayMember = "Name";
            cmbEmployees.ValueMember = "Id";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee first!");
                return;
            }
            if (!(cmbEmployees.SelectedItem is Employee selectedEmployee))
            {
                MessageBox.Show("Invalid employee data!");
                return;
            }
            decimal basePay = selectedEmployee.Salary;
            if (decimal.TryParse(txtOvertime.Text, out decimal overtimeHours) &&
                decimal.TryParse(txtDeductions.Text, out decimal deductions))
            {
                decimal overtimePay = overtimeHours * (basePay / 160) * OvertimeRate;
                decimal netPay = basePay + overtimePay - deductions;
                txtNetPay.Text = netPay.ToString("C2");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payroll saved successfully!");
        } //actually save button

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedItem is Employee selected)
            {
                txtBaseSalary.Text = selected.Salary.ToString("C2");
            }
        }
        //nadoble wtf 
        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedItem is Employee selected)
            {
                txtBaseSalary.Text = selected.Salary.ToString("C2");
            }
        }
    }
}
