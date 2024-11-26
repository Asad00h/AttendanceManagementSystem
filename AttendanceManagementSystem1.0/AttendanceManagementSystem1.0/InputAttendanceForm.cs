using System;
using System.Linq;
using System.Windows.Forms;
using AttendanceManagementSystem; // Ensure this matches the namespace of EmployeeData and Employee classes

namespace AttendanceManagementSystem1._0
{
    public partial class InputAttendanceForm : Form
    {
        public InputAttendanceForm()
        {
            InitializeComponent();
        }

        private int GetSelectedEmployeeID()
        {
            if (int.TryParse(textBox1.Text, out int employeeID))
                return employeeID;

            MessageBox.Show("Please enter a valid Employee ID.");
            return -1;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int employeeID = GetSelectedEmployeeID();
            var employee = EmployeeData.Employees.FirstOrDefault(emp => emp.EmployeeID == employeeID);

            if (employee != null)
            {
                employee.CheckIn(DateTime.Now);
                lblCheckInTime.Text = "Check-in time: " + employee.CheckInTime?.ToString("hh:mm:ss tt");

                if (employee.Tardiness == 1)
                {
                    MessageBox.Show("This check-in is late!");
                }
            }
            else
            {
                MessageBox.Show("Employee not found!");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int employeeID = GetSelectedEmployeeID();
            var employee = EmployeeData.Employees.FirstOrDefault(emp => emp.EmployeeID == employeeID);

            if (employee != null)
            {
                employee.CheckOut();
                lblCheckOutTime.Text = "Check-out time: " + employee.CheckOutTime?.ToString("hh:mm:ss tt");

                if (employee.EarlyDepartures == 1)
                {
                    MessageBox.Show("This check-out is early!");
                }
            }
            else
            {
                MessageBox.Show("Employee not found!");
            }
        }
    }
}
