using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
using System.IO;


namespace AdministrationAndHall.UI
{
    public partial class StudentModification : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public StudentModification()
        {
            InitializeComponent();
        }


        private void exit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void mainButton_Click(object sender, System.EventArgs e)
        {
            BasicForm basic = new BasicForm();
            basic.ShowDialog();
        }

       
        private void searchButton_Click(object sender, System.EventArgs e)
        {

            try
            {

                SqlConnection con1 =new SqlConnection(connectionString);
                
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
                        idTextBox.Text = (myReader["id"].ToString());
                        fullNameTextBox.Text = (myReader["name"].ToString());
                        sexComboBox.Text = (myReader["sex"].ToString());
                        permanentTextBox.Text = (myReader["permanentaddress"].ToString());
                        presentTextBox.Text = (myReader["presentaddress"].ToString());
                        rollTextBox.Text = (myReader["roll"].ToString());
                        registrationTextBox.Text = (myReader["registration"].ToString());
                        departmentComboBox.Text = (myReader["deptname"].ToString());
                        sessionComboBox.Text = (myReader["session"].ToString());
                        sscTextBox.Text = (myReader["ssc"].ToString());
                        hsctextbox.Text = (myReader["hsc"].ToString());
                        mobileTextbox.Text = (myReader["mobile"].ToString());
                        familyTextBox.Text = (myReader["home"].ToString());
                        emailTextbox.Text = (myReader["email"].ToString());

                        if (!Convert.IsDBNull(myReader["photo"]))
                        {

                            /*
                               SqlDataAdapter sda = new SqlDataAdapter("Select * from GeneralStudent where id= " + searchTextBox.Text + "", con1);
                               DataTable dt = new DataTable();
                               sda.Fill(dt);
                               byte[] mydata = new byte[0];
                               mydata = (byte[])dt.Rows[0][2];
                               MemoryStream mst = new MemoryStream(mydata);
                               searchpictureBox.Image = Image.FromStream(mst);

                            */
                            richTextBox2.Visible =false ;
                            searchpictureBox.Text = null;
                            richTextBox2.Visible = true;
                            richTextBox2.Text = "Photos Available";
                            
                 
                        }
                         
                        else
                        {
                            richTextBox2.Visible = false;
                            searchpictureBox.Text = null;
                            richTextBox1.Visible = true;
                            richTextBox1.Text = "Photos Not Available";
                        
                        }
                        
                        
                    }

                    myReader.Close();


                    SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from GeneralStudent where id ='" + searchTextBox.Text + "' ", con1);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows[0][0].ToString() == "0")
                    {

                        MessageBox.Show(" ID Not Found In Your Database.\nPlease Make Sure About Your ID",
                                               "Waring Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {

                        System.Windows.Forms.DialogResult result = MessageBox.Show("Success!\n\nStudent ID :" + idTextBox.Text + "\nFull Name :" +
                                         fullNameTextBox.Text + "\nSex :" + sexComboBox.Text + "\nPermanent Address :" +
                                         permanentTextBox.Text + "\nPresent Address :" + presentTextBox.Text + "\nRoll :" +
                                         registrationTextBox.Text + "\nDepartment Name :" + departmentComboBox.Text +
                                         "\nSession :" + sessionComboBox.Text + "\nSSC Result :" + sscTextBox.Text +
                                         "\nHSC Result " + hsctextbox.Text + "\nMobile No :" + mobileTextbox.Text +
                                         "\nHome Mobile" + familyTextBox.Text
                                         + "\nEmail Id :" + emailTextbox.Text + "\n\nThank You", "Information and Confirmation Window", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        System.Windows.Forms.DialogResult dialogResult1 = MessageBox.Show(
                                "Do You Want To Update or Delete " + fullNameTextBox.Text + "'s Information?",
                                "Confirmation Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        
                        if (dialogResult1 == DialogResult.Yes)
                        {

                            addPhoto.Visible = true;

                            searchResultGroupBox.Visible = true;



                        }


                        else if (dialogResult1 == DialogResult.No)
                        {

                            searchResultGroupBox.Visible = false;

                        }

                    }


                }

                con1.Close();

            }
            catch (Exception ex)
            {
                searchResultGroupBox.Visible = false;

                MessageBox.Show(ex.Message);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                


                string query = "update GeneralStudent set name='" + this.fullNameTextBox.Text + "', sex= '" +
                               this.sexComboBox.Text + "',  permanentaddress= '" + this.permanentTextBox.Text +
                               "', presentaddress= '" + this.presentTextBox.Text + "', roll= '" + this.rollTextBox.Text +
                               "', registration= '" + this.registrationTextBox.Text + "', deptname= '" +
                               this.departmentComboBox.Text + "', session= '" + this.sessionComboBox.Text + "', ssc= '" +
                               this.sscTextBox.Text + "', hsc= '" + this.hsctextbox.Text + "', mobile= '" +
                               this.mobileTextbox.Text + "', home= '" + this.familyTextBox.Text + "',email= '" +
                               this.emailTextbox.Text + "',photo=@image  where id='" + this.idTextBox.Text + "';";

                SqlCommand command = new SqlCommand();

                command.Connection = connection;

                command.CommandText = query;

                MemoryStream stream = new MemoryStream();

                searchpictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] ima = stream.ToArray();
                command.Parameters.AddWithValue("@image", ima);

                int rows = command.ExecuteNonQuery();
               

                if (rows > 0 )
                {
                    MessageBox.Show("Data Succsfully Updated", "Sucessfull Window", MessageBoxButtons.OK,MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("Data Not Updated", "Error Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();


                DialogResult exitresult = MessageBox.Show("Do you Want to Delete "+fullNameTextBox.Text+"'s Data?",
                                                          "Delete Confirmation Dialog Box",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (exitresult == DialogResult.Yes)
                {

                    string query = "delete from GeneralStudent where id='" + this.idTextBox.Text + "';";

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    command.CommandText = query;


                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show(" Data Deleted Succsfully", "Delete Confirmation Window", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        idTextBox.Text =
                            fullNameTextBox.Text =
                            sexComboBox.Text =
                            permanentTextBox.Text =
                            presentTextBox.Text =
                            rollTextBox.Text =
                            registrationTextBox.Text =
                            departmentComboBox.Text =
                            sessionComboBox.Text =
                            sscTextBox.Text =
                            hsctextbox.Text =
                            mobileTextbox.Text =
                            familyTextBox.Text =
                            emailTextbox.Text = "";


                    }

                    else
                    {
                        MessageBox.Show("Data Not Deleted.\n\nYou entered wrong ID");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void idTextBox_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 =
                    new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                con1.Open();
                
                SqlCommand myCommand = new SqlCommand(
                    "select Max(id) from studentinfo", con1);


                SqlDataReader dr = myCommand.ExecuteReader();
                dr.Read();
                int i = Convert.ToInt16(dr["id"].ToString());
                idTextBox.Text = (i + 1).ToString();


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void addPhoto_Click(object sender, EventArgs e)
        {
            try
            {

                richTextBox1.Visible = false;
                searchpictureBox.Visible = true;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    searchpictureBox.Image = Image.FromFile(ofd.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchResultGroupBox.Visible = false;
        }
    }


}
        

       




    






