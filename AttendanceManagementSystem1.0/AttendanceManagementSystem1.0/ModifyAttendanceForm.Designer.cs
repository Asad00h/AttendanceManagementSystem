namespace AttendanceManagementSystem1._0
{
    partial class ModifyAttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtpCheckInTime = new DateTimePicker();
            dtpCheckOutTime = new DateTimePicker();
            chkTardiness = new CheckedListBox();
            chkAbsenteeism = new CheckedListBox();
            chkEarlyDeparture = new CheckedListBox();
            label6 = new Label();
            txtPassword = new TextBox();
            btnModify = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 26);
            label1.Name = "label1";
            label1.Size = new Size(492, 46);
            label1.TabIndex = 0;
            label1.Text = "Modify Employee Attendance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 186);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "EmployeeID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(451, 183);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "EmployeeName";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(108, 183);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(184, 27);
            txtEmployeeID.TabIndex = 3;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(576, 179);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(196, 27);
            txtEmployeeName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(235, 258);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 5;
            label4.Text = "CheckIN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(235, 300);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 6;
            label5.Text = "CheckOut";
            // 
            // dtpCheckInTime
            // 
            dtpCheckInTime.Location = new Point(317, 258);
            dtpCheckInTime.Name = "dtpCheckInTime";
            dtpCheckInTime.Size = new Size(253, 27);
            dtpCheckInTime.TabIndex = 7;
            // 
            // dtpCheckOutTime
            // 
            dtpCheckOutTime.Location = new Point(317, 295);
            dtpCheckOutTime.Name = "dtpCheckOutTime";
            dtpCheckOutTime.Size = new Size(253, 27);
            dtpCheckOutTime.TabIndex = 8;
            // 
            // chkTardiness
            // 
            chkTardiness.FormattingEnabled = true;
            chkTardiness.Items.AddRange(new object[] { "Tardiness" });
            chkTardiness.Location = new Point(318, 364);
            chkTardiness.Name = "chkTardiness";
            chkTardiness.Size = new Size(138, 26);
            chkTardiness.TabIndex = 9;
            // 
            // chkAbsenteeism
            // 
            chkAbsenteeism.FormattingEnabled = true;
            chkAbsenteeism.Items.AddRange(new object[] { "Absenteeism" });
            chkAbsenteeism.Location = new Point(317, 428);
            chkAbsenteeism.Name = "chkAbsenteeism";
            chkAbsenteeism.Size = new Size(140, 26);
            chkAbsenteeism.TabIndex = 10;
            // 
            // chkEarlyDeparture
            // 
            chkEarlyDeparture.FormattingEnabled = true;
            chkEarlyDeparture.Items.AddRange(new object[] { "Early Departure" });
            chkEarlyDeparture.Location = new Point(318, 396);
            chkEarlyDeparture.Name = "chkEarlyDeparture";
            chkEarlyDeparture.Size = new Size(138, 26);
            chkEarlyDeparture.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(209, 505);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(291, 502);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '$';
            txtPassword.Size = new Size(184, 27);
            txtPassword.TabIndex = 13;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.White;
            btnModify.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModify.Location = new Point(318, 589);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(139, 42);
            btnModify.TabIndex = 14;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // ModifyAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(802, 667);
            Controls.Add(btnModify);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(chkEarlyDeparture);
            Controls.Add(chkAbsenteeism);
            Controls.Add(chkTardiness);
            Controls.Add(dtpCheckOutTime);
            Controls.Add(dtpCheckInTime);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModifyAttendanceForm";
            Text = "ModifyAttendanceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpCheckInTime;
        private DateTimePicker dtpCheckOutTime;
        private CheckedListBox chkTardiness;
        private CheckedListBox chkAbsenteeism;
        private CheckedListBox chkEarlyDeparture;
        private Label label6;
        private TextBox txtPassword;
        private Button btnModify;
    }
}