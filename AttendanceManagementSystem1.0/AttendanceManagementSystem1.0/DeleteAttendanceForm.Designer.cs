namespace AttendanceManagementSystem1._0
{
    partial class DeleteAttendanceForm
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
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            dgvDeleteConfirmation = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteConfirmation).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 112);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "EmployeeID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(575, 112);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "EmployeeName";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(145, 109);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(182, 27);
            txtEmployeeID.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(700, 109);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(160, 27);
            txtEmployeeName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(296, 19);
            label3.Name = "label3";
            label3.Size = new Size(286, 46);
            label3.TabIndex = 4;
            label3.Text = "Delete Employee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(332, 195);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(414, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 7;
            // 
            // dgvDeleteConfirmation
            // 
            dgvDeleteConfirmation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteConfirmation.Location = new Point(-7, 414);
            dgvDeleteConfirmation.Name = "dgvDeleteConfirmation";
            dgvDeleteConfirmation.RowHeadersWidth = 51;
            dgvDeleteConfirmation.Size = new Size(931, 188);
            dgvDeleteConfirmation.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(392, 313);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 49);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // DeleteAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(919, 600);
            Controls.Add(btnDelete);
            Controls.Add(dgvDeleteConfirmation);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteAttendanceForm";
            Text = "DeleteAttendanceForm";
            ((System.ComponentModel.ISupportInitialize)dgvDeleteConfirmation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private DataGridView dgvDeleteConfirmation;
        private Button btnDelete;
    }
}