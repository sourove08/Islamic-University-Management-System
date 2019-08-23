using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdministrationAndHall.UI
{
    public partial class ProvostEntryForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public ProvostEntryForm()
        {
            InitializeComponent();
        }

        private void hallComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            try
            {
        
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query =
                    string.Format(
                        @"insert into ProvostEntry values('{0}','{1}','{2}','{3}','{4}')",this.provostidTextBox.Text,  this.provostfullNametextBox.Text, this.joiningdateTimePickerBox.Text, this.deadlinedateTimePickerBox.Text, this.provosthallComboBox.Text);


                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = query;
                DateTimePicker inputdate = joiningdateTimePickerBox;


                if (DateTime.Today > inputdate.Value)
                {
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Data Saved Succsfully", "Sucessfull Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);





                    }

                    else
                    {
                        MessageBox.Show("Data Not Saved", "Error Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "You Entered The Wrong Joning Date.\nJoining Date Does Not More Than Current Date and Time",
                        "Error Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            provostidTextBox.Text =
                provostfullNametextBox.Text =
                joiningdateTimePickerBox.Text = deadlinedateTimePickerBox.Text = provosthallComboBox.Text = "";
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            BasicForm form = new BasicForm();
            form.ShowDialog();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con1 =
                    new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                con1.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(
                    "select * from TeacharsEntry where id='" + searchTeachersIdTextBox.Text + "'", con1);
                if (searchTeachersIdTextBox.Text == "")
                {

                    MessageBox.Show("Please Enter Studet Id.\nYou Entered Null Value\nThank You", "Error Message Window",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                }
                else
                {

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(
                            "select count(*) from TeacharsEntry where id ='" + searchTeachersIdTextBox.Text + "' ", con1);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows[0][0].ToString() == "1")
                    {

                        myReader = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {


                           provostidTextBox.Text = (myReader["id"].ToString());
                           provostfullNametextBox.Text = (myReader["name"].ToString());

                        }

                       

                    }

                    else
                    {
                        MessageBox.Show(" ID Not Found In Your Database.\nPlease Make Sure About Your ID",
                                        "Waring Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }







                }



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
    }

        private void button2_Click(object sender, EventArgs e)
        {

            provostidTextBox.Text = provostfullNametextBox.Text = joiningdateTimePickerBox.Text = deadlinedateTimePickerBox.Text = 
            provosthallComboBox.Text =searchTeachersIdTextBox.Text="" ;

        }





    
        private void searchTeachersIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void provostidTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void provostfullNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void joiningdateTimePickerBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void deadlinedateTimePickerBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            

             try
            {
               SqlConnection con1 =
               new SqlConnection(connectionString);
                
                con1.Open();
               
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(
                  "select * from  ProvostEntry where id= ( SELECT TOP 1 id FROM ProvostEntry ORDER BY id DESC)", con1);
              

                    

                        myReader = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {

                            searchTeachersIdTextBox.Text = (myReader["id"].ToString());
                            provostidTextBox.Text = (myReader["id"].ToString());
                            provostfullNametextBox.Text = (myReader["name"].ToString());
                            joiningdateTimePickerBox.Text = (myReader["joining"].ToString());
                            deadlinedateTimePickerBox.Text = (myReader["deadline"].ToString());
                   

                        }







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
}
}



            

        
    
