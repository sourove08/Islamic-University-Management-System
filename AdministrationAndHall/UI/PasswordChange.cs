using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdministrationAndHall.UI
{
    public partial class PasswordChange : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (currentUserNameTextBox.Text == "" || currentPasswordTextBox.Text == "" || newPasswordTextBox.Text == "" ||
                confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("You Entered Null Value.\nFill Up The Text Field Properly.\nThank You", "Message Box",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else 
            {
                DialogResult updatePassword =
                    MessageBox.Show("Your Updated Password is : " + newPasswordTextBox.Text +
                                    "\nDo You Want To Update This User's Password ? ", "Confirmation Window",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information);


                if (updatePassword == DialogResult.Yes)
                {



                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from login where username ='" + currentUserNameTextBox.Text + "' and password='" + currentPasswordTextBox.Text + "'", connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows[0][0].ToString() == "1")
                    {
                        if (newPasswordTextBox.Text == confirmPasswordTextBox.Text)
                        {
                            SqlCommand command2 = new SqlCommand(@"update login set password='" + newPasswordTextBox.Text + "' where username='" +
                                currentUserNameTextBox.Text + "'", connection);

                            int rows = command2.ExecuteNonQuery();
                            if (rows == 1)
                            {
                                MessageBox.Show("Password Changed Succsfully", "Confirmation Window", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);

                                currentUserNameTextBox.Text =
                                    currentPasswordTextBox.Text =
                                    newPasswordTextBox.Text = confirmPasswordTextBox.Text = " ";

                            }



                        }

                        else
                        {
                            MessageBox.Show("You Entered Wrong Confirmation Password",
                                            "Error Window", MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }

                    }

                    
                    
                    else
                    {
                         MessageBox.Show("You Entered Wrong Username or Password",
                                        "Error Window", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                   

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

