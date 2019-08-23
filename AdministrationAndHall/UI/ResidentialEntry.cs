using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdministrationAndHall.UI
{
    public partial class ResidentialEntry : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public ResidentialEntry()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            BasicForm form=new BasicForm();
            form.ShowDialog();

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            try
            {
                
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (residentialIdTextBox.Text == "" || residentialNameTextBox.Text == "")
                {
                    MessageBox.Show("Data Not Saved\nI think You Don't Fill Up ID or Name.\nThanks", "Notice Window",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = string.Format( @"insert into  ResidentialStudent values('{0}','{1}','{2}','{3}','{4}','{5}')",
                            this.residentialIdTextBox.Text, this.residentialNameTextBox.Text,
                            this.residentialhallNametrextBox.Text, this.entrydateTimePickerBox.Text,
                            this.deadlinedateTimePickerBox.Text, roomNoTextBox.Text);


                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    command.CommandText = query;
                    DateTimePicker inputdate = entrydateTimePickerBox;

                    if (DateTime.Today > inputdate.Value)
                    {

                        int rows = command.ExecuteNonQuery();
                        
                        if (rows > 0)
                        
                        {

                            MessageBox.Show("Data Saved Succsfully", "Sucessfull Notification", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                                residentialIdTextBox.Text =
                                residentialNameTextBox.Text =
                                residentialhallNametrextBox.Text =
                                entrydateTimePickerBox.Text = deadlinedateTimePickerBox.Text = "";

                        }
                    }

                    else
                    {
                        MessageBox.Show("Data Not Saved.\nYou Enter Wrong Entry Date.\nPlease Inpur before today's Date\nThank You.", "Warning Message Box", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con1 =
                    new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                con1.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(
                    "select * from GeneralStudent where id='" + searchTextBox.Text + "'", con1);
                if (searchTextBox.Text == "")
                {

                    MessageBox.Show("Please Enter Studet Id.\nYou Entered Null Value\nThank You", "Error Message Window", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                }
                else
                {


                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        residentialIdTextBox.Text = (myReader["id"].ToString());
                        
                        residentialNameTextBox.Text = (myReader["name"].ToString());
                     
                    }

                    myReader.Close();


                    SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from ResidentialStudent where id ='" + searchTextBox.Text + "' ", con1);

                   DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows[0][0].ToString() == "0")
                   {

                     MessageBox.Show(" ID Not Found In Your Database.\nPlease Make Sure About Your ID",
                                       "Waring Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }


                }

                con1.Close();
                con1.Dispose();
            }
            catch (Exception ex)
            {
              

                MessageBox.Show(ex.Message);
            }


        }

       
    }
}
