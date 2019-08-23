using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdministrationAndHall.UI
{
    public partial class Administration : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public Administration()
        {
            InitializeComponent();
            
        }

     

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            fullNameTextBox.Text = "";
        }

       
        private void mainButton_Click(object sender, EventArgs e)
        {
            BasicForm form1 = new BasicForm();
            form1.ShowDialog();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            try
            {

                
                SqlConnection connection = new SqlConnection(connectionString);
                
                connection.Open();
               
                if (fullNameTextBox.Text == String.Empty)
                {

                    fullNameTextBox.Text = "Please Enter Name";
                    
                }

                else if (EmailValidation.CheckForMail(emailTextbox.Text))
                {
                    string query = string.Format(@"insert into administration values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')"
                           , idTextBox.Text,
                            fullNameTextBox.Text,
                            sexComboBox.Text,
                            presentTextBox.Text,
                            permanentTextBox.Text,
                            departmentComboBox.Text,
                            joiningdateTimePickerBox.Value.Date,
                            resigningdateTimePickerBox.Value.Date,
                            mobileTextbox.Text,
                            emailTextbox.Text);

                    SqlCommand command = new SqlCommand(query, connection);

                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Data Saved Succsfully !", "Successful Notice Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }

                    else
                    {
                        MessageBox.Show("Data Not Saved", "Error Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    emaillebelBox.Visible = true;
                    exampleBox.Visible = true;

                    emaillebelBox.Text = "Please Enter Accurate Mail Format.Example:";
                    exampleBox.Text = "example@gmail.com";
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {

            idTextBox.Text = fullNameTextBox.Text =
            sexComboBox.Text = presentTextBox.Text =
            permanentTextBox.Text = departmentComboBox.Text =
            mobileTextbox.Text = joiningdateTimePickerBox.Text =
           resigningdateTimePickerBox.Text = emailTextbox.Text = "";
        }

        private void previousButton_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con1 =
                   new SqlConnection(connectionString);

                con1.Open();

                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(
                  "select * from  administration where id= ( SELECT TOP 1 id FROM administration ORDER BY id DESC)", con1);




                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {

                    idTextBox.Text = (myReader["id"].ToString());
                    fullNameTextBox.Text = (myReader["name"].ToString());
                    sexComboBox.Text = (myReader["sex"].ToString());
                    permanentTextBox.Text = (myReader["permanentAddress"].ToString());
                    presentTextBox.Text = (myReader["presentAddress"].ToString());


                    departmentComboBox.Text = (myReader["designation"].ToString());

                    joiningdateTimePickerBox.Text = (myReader["joining"].ToString());
                    resigningdateTimePickerBox.Text = (myReader["resign"].ToString());
                    mobileTextbox.Text = (myReader["mobile"].ToString());

                    emailTextbox.Text = (myReader["email"].ToString());
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void mainButton_Click_1(object sender, EventArgs e)
        {
            BasicForm bs = new BasicForm();
            bs.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SqlConnection con1 =
                       new SqlConnection(connectionString);
                con1.Open();
                try
                {

                    SqlCommand command = new SqlCommand("select max(id) from administration", con1);

                    int i = Convert.ToInt16(command.ExecuteScalar().ToString());

                    idTextBox.Text = (i + 1).ToString();
                }

                finally
                {
                    con1.Close();
                }
            }
            catch (Exception abc)
            {
                MessageBox.Show(abc.Message);
            }
        }

        private void emaillebelBox_Click(object sender, EventArgs e)
        {

        }

      
    }
}
