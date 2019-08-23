using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;





namespace AdministrationAndHall.UI
{
    public partial class LoginForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 15;
            timer1.Start();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            


            SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from login where username ='" + userNameTextBox.Text + "' and password='" + passwordTextBox.Text + "'", connectionString);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                BasicForm basicform=new BasicForm();
                basicform.ShowDialog();

            }

            else
            {
                MessageBox.Show("Please Check Your Password and Try again", "Login Failed Message Box ", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

                userNameTextBox.Text = passwordTextBox.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            this.timeLabel.Text = dateTime.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
