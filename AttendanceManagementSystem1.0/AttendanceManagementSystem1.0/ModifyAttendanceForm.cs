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
    public partial class ModifyAttendanceForm : Form
    {
        private const string AdminPassword = "0000"; // Set admin password here

        public ModifyAttendanceForm()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
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
                    emp.EmployeeID.ToString() == txtEmployeeID.Text &&
                    emp.EmployeeName == txtEmployeeName.Text);

            if (employee == null)
            {
                MessageBox.Show("Employee record not found.");
                return;
            }

            // Update fields based on user input
            employee.CheckInTime = dtpCheckInTime.Value;
            employee.CheckOutTime = dtpCheckOutTime.Value;

            // Update Tardiness and Early Departures based on checkbox states
            employee.Tardiness = chkTardiness.CheckedItems.Contains("Tardiness") ? 1 : 0;
            employee.EarlyDepartures = chkEarlyDeparture.CheckedItems.Contains("Early Departure") ? 1 : 0;

            // Handle Absenteeism
            if (chkAbsenteeism.CheckedItems.Contains("Absenteeism"))
            {
                // Mark as Absent if Absenteeism checkbox is checked
                employee.SetAbsenteeism(1);
            }
            else
            {
                // If unchecked, mark as Present (ensure both Check-In and Check-Out are set)
                if (employee.CheckInTime.HasValue && employee.CheckOutTime.HasValue)
                {
                    employee.SetAbsenteeism(0); // Present
                }
                else
                {
                    MessageBox.Show("Please provide both Check-In and Check-Out times to mark as Present.");
                    return;
                }
            }

            MessageBox.Show("Attendance record modified successfully.");
        }
    }
}