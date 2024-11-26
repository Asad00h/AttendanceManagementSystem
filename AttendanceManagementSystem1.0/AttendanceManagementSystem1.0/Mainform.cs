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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;

            // Manually assign button click events if not wired in designer
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
        }

        // Handle KeyDown event for selecting functions with keys 1 to 5 and exiting with 6
        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1: // Press 1 to open Input Attendance Form
                    OpenInputAttendanceForm();
                    break;
                case Keys.D2: // Press 2 to open View Attendance Form
                    OpenViewAttendanceForm();
                    break;
                case Keys.D3: // Press 3 to open Search Attendance Form
                    OpenQueryAttendanceForm();
                    break;
                case Keys.D4: // Press 4 to open Modify Attendance Form
                    OpenModifyAttendanceForm();
                    break;
                case Keys.D5: // Press 5 to open Delete Attendance Form
                    OpenDeleteAttendanceForm();
                    break;
                case Keys.D6: // Press 6 to exit the application
                    Application.Exit();
                    break;
                default:
                    MessageBox.Show("Invalid input! Please enter a number between 1 and 6.");
                    break;
            }
        }

        // Methods to open each form
        private void OpenInputAttendanceForm()
        {
            InputAttendanceForm inputForm = new InputAttendanceForm();
            inputForm.ShowDialog(); // Open input Attendance Form
        }

        private void OpenViewAttendanceForm()
        {
            ViewAttendanceForm viewForm = new ViewAttendanceForm();
            viewForm.ShowDialog(); // Open View Attendance Form
        }

        private void OpenQueryAttendanceForm()
        {
            QueryAttendanceForm queryForm = new QueryAttendanceForm();
            queryForm.ShowDialog(); // Open query Attendance Form
        }

        private void OpenModifyAttendanceForm()
        {
            ModifyAttendanceForm modifyForm = new ModifyAttendanceForm();
            modifyForm.ShowDialog(); // Open Modify Attendance Form
        }

        private void OpenDeleteAttendanceForm()
        {
            DeleteAttendanceForm deleteForm = new DeleteAttendanceForm();
            deleteForm.ShowDialog(); // Open Delete Attendance Form
        }

        // Button click event handlers
        private void button1_Click(object? sender, EventArgs e)
        {
            OpenInputAttendanceForm();
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            OpenViewAttendanceForm();
        }
        private void button3_Click(object? sender, EventArgs e)
        {
            OpenQueryAttendanceForm();
        }

        private void button4_Click(object? sender, EventArgs e)
        {
            OpenModifyAttendanceForm();
        }

        private void button5_Click(object? sender, EventArgs e)
        {
            OpenDeleteAttendanceForm();
        }

        private void button6_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
