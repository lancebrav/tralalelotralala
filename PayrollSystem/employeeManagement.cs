using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class employeeManagement: Form
    {
        private List<Employee> employees = new List<Employee>();
        private string dataFilePath = "employees.txt";

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            RefreshDataGridView();
        }

        private void LoadEmployees()
        {
            if (File.Exists(dataFilePath))
            {
                try
                {
                    var lines = File.ReadAllLines(dataFilePath);
                    employees.Clear();

                    foreach (var line in lines)
                    {
                        var data = line.Split(',');
                        employees.Add(new Employee
                        {
                            Id = int.Parse(data[0]),
                            Name = data[1],
                            Position = data[2],
                            Salary = decimal.Parse(data[3])
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }

        private void RefreshDataGridView()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = employees;
            dgvEmployees.Columns["Id"].HeaderText = "ID";
            dgvEmployees.Columns["Name"].HeaderText = "Full Name";
            dgvEmployees.Columns["Salary"].DefaultCellStyle.Format = "C2";
        }



        public employeeManagement()
        {
            InitializeComponent();

            this.Load += EmployeeManagement_Load;

        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            RefreshDataGridView();
        }


        private void lblEmpManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditEmployeeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                employees.Add(form.Employee);
                RefreshDataGridView();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var selectedEmployee = (Employee)dgvEmployees.SelectedRows[0].DataBoundItem;
                var form = new AddEditEmployeeForm(selectedEmployee);
                if (form.ShowDialog() == DialogResult.OK)
                    RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Delete this employee?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    employees.Remove((Employee)dgvEmployees.SelectedRows[0].DataBoundItem);
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var lines = employees.Select(emp =>
                    $"{emp.Id},{emp.Name},{emp.Position},{emp.Salary}");
                File.WriteAllLines(dataFilePath, lines);
                MessageBox.Show("Data saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                var filtered = employees.Where(emp =>
                    emp.Name.ToLower().Contains(searchTerm) ||
                    emp.Position.ToLower().Contains(searchTerm)).ToList();

                dgvEmployees.DataSource = filtered;
            }
            else
            {
                RefreshDataGridView();
            }
        }
    }
}
