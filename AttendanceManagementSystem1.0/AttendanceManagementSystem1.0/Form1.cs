namespace AttendanceManagementSystem1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Replace these with actual validation checks or database calls
            string username = "admin"; // Example username
            string password = "0000"; // Example password

            if (textBox1.Text == username && textBox2.Text == password)
            {
                // Successful login
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the MainForm and close the login form
                Mainform mainForm = new Mainform();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Invalid login
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
