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
    public partial class userCreateForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public userCreateForm()
        {
            InitializeComponent();
            userNameCreateTextBox.MaxLength = 10;
            passwordCreateTextBox.MaxLength = 10;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
           
            connection.Open();



            if (userNameCreateTextBox.Text == "" || passwordCreateTextBox.Text == "" || confirmTextBox.Text == "")
            {


                MessageBox.Show(
                    "Please Check Your Field or Fields.\nI think You have not filled up the Text Box or Boxes.\nThank You Very Much",
                    "Error Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else if (passwordCreateTextBox.Text == confirmTextBox.Text)
            {
                DialogResult createUser =
                    MessageBox.Show(
                        "User Name = " + userNameCreateTextBox.Text + "\nPassword= " + passwordCreateTextBox.Text +
                        "\nDo You Want To Create This User ? ", "Confirmation Window", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                try
                {

                    if (createUser == DialogResult.Yes)
                    {

                        SqlDataAdapter Newadapter = new SqlDataAdapter("select count(*) from login where username ='" + userNameCreateTextBox.Text + "'", connection);

                        DataTable NewdataTable = new DataTable();
                        Newadapter.Fill(NewdataTable);

                        if (NewdataTable.Rows[0][0].ToString() == "1")
                        {

                            MessageBox.Show("Already This User Has Created.\n Please Enter Another User Name.\nThanks",
                                "Alert Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            
                        }

                        else
                        {
                            string query = string.Format(@"insert into login values('{0}','{1}')", userNameCreateTextBox.Text,
                                                       passwordCreateTextBox.Text);

                            SqlCommand command = new SqlCommand();
                            command.Connection = connection;

                            command.CommandText = query;

                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {


                                MessageBox.Show("User Create Succsfully.\nThank You.", "Confirmation Window", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);

                                userNameCreateTextBox.Text = passwordCreateTextBox.Text = confirmTextBox.Text = " ";
                            }

                            else
                            {
                                MessageBox.Show("User Not Created", "Error Window", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }

                        }


                    }


                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }


            }
            else
            {
                MessageBox.Show("Your Password Do Not Match.\nPlease Make Sure to Input the Right Password.\nThanks",
                                "Alert Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
