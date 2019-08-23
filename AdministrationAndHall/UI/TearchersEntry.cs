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
    public partial class TearchersEntry : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public TearchersEntry()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                
                connection.Open();
                
                if (idTextBox.Text == String.Empty)
                {
                    idLebelBox.Visible = true;
                    idLebelBox.Text = "Please Enter ID";

                }

                else if (TeacheremailTextBox.Text == String.Empty || EmailValidation.CheckForMail(TeacheremailTextBox.Text))
                {
                    string query =string.Format(@"insert into TeacharsEntry values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", this.idTextBox.Text, this.fullNametextBox.Text, this.permanentTextBox.Text, this.presentTextBox.Text,
                                           this.honsTextBox.Text,
                                            this.mscTextBox.Text, this.phdTextBox.Text, this.deptComboBox.Text, this.dateTimePickerBox.Text, this.mobileTextBox.Text,
                                            this.TeacheremailTextBox.Text);


                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    command.CommandText = query;
                    DateTimePicker inputdate = dateTimePickerBox;


                    if (DateTime.Today > inputdate.Value)
                    {
                        int rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Data Saved Succsfully");

                        }

                        else
                        {
                            MessageBox.Show("Data Not Saved");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Entered The Wrong Joning Date.\nJoining Date Does Not More Than Current Date and Time");
                    }
                }


                else
                {
                    exampleBox.Visible = true;
                    label11.Visible = true;

                    label11.Text = "Invalid Email:";
                    exampleBox.Text = "example@gmail.com";
                }
                
                    }

            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            idTextBox.Text =
            fullNametextBox.Text =
            permanentTextBox.Text =
            presentTextBox.Text =
            honsTextBox.Text =
            mscTextBox.Text =
            phdTextBox.Text =
            deptComboBox.Text =
            dateTimePickerBox.Text =
            mobileTextBox.Text =
            TeacheremailTextBox.Text = "";
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            BasicForm form1 = new BasicForm();
            form1.ShowDialog();
        }

        private void idTextBox_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection con1 =
                       new SqlConnection(connectionString);
                con1.Open();
                try
                {

                    SqlCommand command = new SqlCommand("select max(id) from TeacharsEntry", con1);

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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void presentAddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (presentAddressCheckBox.Checked == false)
            {
                presentTextBox.Text = String.Empty;

            }
            else
            {
                presentTextBox.Text = permanentTextBox.Text;
            }

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
                  "select * from  TeacharsEntry where id= ( SELECT TOP 1 id FROM TeacharsEntry ORDER BY id DESC)", con1);
              

                    

                        myReader = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {
                      
                        idTextBox.Text = (myReader["id"].ToString());
                        fullNametextBox.Text = (myReader["name"].ToString());
                        permanentTextBox.Text = (myReader["permanetaddress"].ToString());
                        presentTextBox.Text = (myReader["presentaddress"].ToString());
                        honsTextBox.Text=(myReader["hons"].ToString());
                        mscTextBox.Text=(myReader["masters"].ToString());
                        phdTextBox.Text=(myReader["phd"].ToString());
                        deptComboBox.Text=(myReader["deptname"].ToString());
                        dateTimePickerBox.Text=(myReader["joindate"].ToString());
                        mobileTextBox.Text=(myReader["mobile"].ToString());
                        TeacheremailTextBox.Text=(myReader["email"].ToString());
      
                        }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        }
        }
    

