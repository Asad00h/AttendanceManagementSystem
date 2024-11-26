namespace AttendanceManagementSystem1._0
{
    partial class InputAttendanceForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblCheckInTime = new Label();
            lblCheckOutTime = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 23);
            label1.Name = "label1";
            label1.Size = new Size(382, 38);
            label1.TabIndex = 0;
            label1.Text = "Input Employee Attendance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 119);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "EmployeeID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 168);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 2;
            label3.Text = "EmployeeName:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(333, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 27);
            textBox2.TabIndex = 4;
            // 
            // lblCheckInTime
            // 
            lblCheckInTime.AutoSize = true;
            lblCheckInTime.Location = new Point(96, 386);
            lblCheckInTime.Name = "lblCheckInTime";
            lblCheckInTime.Size = new Size(206, 20);
            lblCheckInTime.TabIndex = 5;
            lblCheckInTime.Text = "Check-in time: Not checked in";
            // 
            // lblCheckOutTime
            // 
            lblCheckOutTime.AutoSize = true;
            lblCheckOutTime.Location = new Point(510, 386);
            lblCheckOutTime.Name = "lblCheckOutTime";
            lblCheckOutTime.Size = new Size(216, 20);
            lblCheckOutTime.TabIndex = 6;
            lblCheckOutTime.Text = "Check-out time: Not checked in";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(208, 276);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "CheckIn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCheckIn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(510, 276);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "CheckOut";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnCheckOut_Click;
            // 
            // InputAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblCheckOutTime);
            Controls.Add(lblCheckInTime);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InputAttendanceForm";
            Text = "InputAttendanceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblCheckInTime;
        private Label lblCheckOutTime;
        private Button button1;
        private Button button2;
    }
}