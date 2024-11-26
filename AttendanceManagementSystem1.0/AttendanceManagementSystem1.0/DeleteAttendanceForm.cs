using AttendanceManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagementSystem1._0
{
    public partial class DeleteAttendanceForm : Form
    {
        private const string AdminPassword = "0000"; // Set your admin password here

        public DeleteAttendanceForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if password is empty
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter the password.");
                return;
            }
            if (txtPassword.Text != AdminPassword)
            {
                MessageBox.Show("Incorrect password.");
                return;
            }

            var employee = EmployeeData.Employees
                .FirstOrDefault(emp =>
                    (string.IsNullOrEmpty(txtEmployeeID.Text) || emp.EmployeeID.ToString() == txtEmployeeID.Text) &&
                    (string.IsNullOrEmpty(txtEmployeeName.Text) || emp.EmployeeName == txtEmployeeName.Text));

            if (employee == null)
            {
                MessageBox.Show("Employee record not found.");
                return;
            }

            EmployeeData.Employees.Remove(employee);
            dgvDeleteConfirmation.DataSource = new[] { employee };
            MessageBox.Show("Attendance record deleted successfully.");
        }
    }
}
