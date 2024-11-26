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
    public partial class QueryAttendanceForm : Form
    {
        public QueryAttendanceForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgvSearchResults.AutoGenerateColumns = false;
            dgvSearchResults.Columns.Clear();

            // Employee ID column
            dgvSearchResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Employee ID",
                DataPropertyName = "EmployeeID", // Matches the EmployeeID property in Employee class
                Name = "EmployeeIDColumn"
            });

            // Name column
            dgvSearchResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "EmployeeName", // Ensure this matches the Employee class property for name
                Name = "NameColumn"
            });

            // Check-In Time column
            dgvSearchResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Check-In Time",
                DataPropertyName = "CheckIn", // Using formatted CheckIn in the query results
                Name = "CheckInTimeColumn"
            });

            // Check-Out Time column
            dgvSearchResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Check-Out Time",
                DataPropertyName = "CheckOut", // Using formatted CheckOut in the query results
                Name = "CheckOutTimeColumn"
            });

            // Tardiness column
            dgvSearchResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tardiness",
                DataPropertyName = "Tardiness", // Ensure this matches the Employee class property for tardiness
                Name = "TardinessColumn"
            });

            // Early Departures column
            dgvSearchResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Early Departures",
                DataPropertyName = "EarlyDepartures", // Ensure this matches the Employee class property for early departures
                Name = "EarlyDepartureColumn"
            });

            // Absenteeism column
            dgvSearchResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Absenteeism",
                DataPropertyName = "Absenteeism", // Ensure this matches the Employee class property for absenteeism
                Name = "AbsenteeismColumn"
            });

            // Optional: Customize appearance
            dgvSearchResults.BorderStyle = BorderStyle.Fixed3D;
            dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Retrieve input from TextBoxes
            string employeeId = txtEmployeeID.Text.Trim();

            // Perform search based on Employee ID
            var filteredRecords = EmployeeData.Employees
                .Where(emp =>
                    (string.IsNullOrEmpty(employeeId) || emp.EmployeeID.ToString() == employeeId)
                )
                .Select(emp => new
                {
                    emp.EmployeeID,
                    EmployeeName = emp.EmployeeName,
                    CheckIn = emp.CheckInTime?.ToString("hh:mm:ss tt") ?? "Not checked in",
                    CheckOut = emp.CheckOutTime?.ToString("hh:mm:ss tt") ?? "Not checked out",
                    emp.Tardiness,
                    emp.EarlyDepartures,
                    emp.Absenteeism
                })
                .ToList();

            // Display results in DataGridView
            if (filteredRecords.Any())
            {
                dgvSearchResults.DataSource = filteredRecords;
            }
            else
            {
                MessageBox.Show("No records match the search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSearchResults.DataSource = null; // Clear grid if no results
            }
        }

    }
}