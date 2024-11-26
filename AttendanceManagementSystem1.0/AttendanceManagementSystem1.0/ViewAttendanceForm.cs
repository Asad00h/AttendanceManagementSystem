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
    public partial class ViewAttendanceForm : Form
    {
        public ViewAttendanceForm()
        {
            InitializeComponent();
            InitializeDataGridView();

            // Check absenteeism status before loading records
            EmployeeData.EndOfDayCheck();
            LoadAttendanceRecords();
        }

        private void InitializeDataGridView()
        {
            // Set up DataGridView layout and appearance
            dgvAttendanceRecords.AutoGenerateColumns = false;
            dgvAttendanceRecords.Columns.Clear();

            // Manually add columns
            dgvAttendanceRecords.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Employee ID",
                DataPropertyName = "EmployeeID",
                Name = "EmployeeIDColumn"
            });

            dgvAttendanceRecords.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Employee Name",
                DataPropertyName = "EmployeeName",
                Name = "EmployeeNameColumn"
            });

            dgvAttendanceRecords.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Check-In Time",
                DataPropertyName = "CheckIn",
                Name = "CheckInTimeColumn"
            });

            dgvAttendanceRecords.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Check-Out Time",
                DataPropertyName = "CheckOut",
                Name = "CheckOutTimeColumn"
            });

            dgvAttendanceRecords.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tardiness",
                DataPropertyName = "Tardiness",
                Name = "TardinessColumn"
            });

            dgvAttendanceRecords.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Early Departures",
                DataPropertyName = "EarlyDepartures",
                Name = "EarlyDeparturesColumn"
            });

            dgvAttendanceRecords.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Absenteeism",
                DataPropertyName = "Absenteeism",
                Name = "AbsenteeismColumn"
            });

            // Set dock style to fill the form
            dgvAttendanceRecords.Dock = DockStyle.Fill;

            // Optional: Set a nicer appearance (border, header style, etc.)
            dgvAttendanceRecords.BorderStyle = BorderStyle.Fixed3D;
            dgvAttendanceRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Add padding around the DataGridView
            dgvAttendanceRecords.Margin = new Padding(10);
        }
        private void ViewAttendanceForm_Load(object sender, EventArgs e)
        {
            // Create a layout panel for organizing the form
            var panel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                Padding = new Padding(10),
                AutoSize = true
            };
        }
        private void LoadAttendanceRecords()
        {
            var attendanceRecords = EmployeeData.Employees
                .Select(emp => new
                {
                    EmployeeID = emp.EmployeeID,
                    EmployeeName = emp.EmployeeName,
                    CheckIn = emp.CheckInTime.HasValue ? emp.CheckInTime.Value.ToString("hh:mm:ss tt") : "Not checked in",
                    CheckOut = emp.CheckOutTime.HasValue ? emp.CheckOutTime.Value.ToString("hh:mm:ss tt") : "Not checked out",
                    Tardiness = emp.Tardiness == 1 ? "Yes" : "No",
                    EarlyDepartures = emp.EarlyDepartures == 1 ? "Yes" : "No",
                    Absenteeism = emp.Absenteeism == 1 ? "yes" : "No"
                })
                .ToList();

            dgvAttendanceRecords.DataSource = attendanceRecords;
        }
          
    }
}
