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
    public partial class removeUser : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public removeUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

         
            if(userNameRemoveTextBox.Text=="" && passwordRemoveTextBox.Text=="")
            {
                MessageBox.Show("You Entered Null Value.\nFill Up The Text Field Properly.\nThank You", "Message Box",
                                MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                DialogResult removeUser = MessageBox.Show("User Name = " + userNameRemoveTextBox.Text + "\nPassword= " + passwordRemoveTextBox.Text +
                      "\nDo You Want To Remove This User ? ", "Confirmation Window", MessageBoxButtons.YesNo,MessageBoxIcon.Question);


                if (removeUser == DialogResult.Yes)
                {

                   

                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();

                    SqlCommand command =
                        new SqlCommand(
                            @"delete from login where (username='" + this.userNameRemoveTextBox.Text + "'and password='" +
                            this.passwordRemoveTextBox.Text + "')", connection);

                    int rows = command.ExecuteNonQuery();
                    if (rows == 1)
                    {
                        MessageBox.Show("User Remove Succsfully", "Confirmation Window", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                        userNameRemoveTextBox.Text = passwordRemoveTextBox.Text = " ";
                    
                    }

                    else
                    {
                        MessageBox.Show("User Not Deleted\nYou Entered Wrong UserName or Password", "Error Window", MessageBoxButtons.OK,MessageBoxIcon.Error
                                       );
                    }
                }
                
            }

            


            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }


