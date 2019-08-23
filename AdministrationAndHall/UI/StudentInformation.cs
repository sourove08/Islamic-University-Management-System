using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
using System.IO;

namespace AdministrationAndHall.UI
{
    

    public partial class StudentInformation : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        string ImageLoc =""  ; 
       
        public StudentInformation()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ssc ;
                int hsc;
                

                bool sscresult = int.TryParse(sscTextBox.Text, out ssc);
               
                bool hscresult = int.TryParse(sscTextBox.Text, out hsc);
              
                SqlConnection connection = new SqlConnection(connectionString);
               
                connection.Open();

                if (fullNameTextBox.Text == String.Empty)
                {
                    idLebelBox.Visible = true;
                    idLebelBox.Text = "Please Enter Name";
                
                }

               else if (rollTextBox.Text == String.Empty)
                {
                    idLebelBox.Visible = false;
                    rollLevel.Visible = true; 
                    rollLevel.Text = "Please Enter Roll";
                }
                    
                else if (registrationTextBox.Text == String.Empty)
                {
                    rollLevel.Visible = false; 
                    regiLevel.Visible = true;

                    regiLevel.Text = "Please Enter Registration";
                }

                else if (ssc <= 0 || ssc > 5)
                {
                    regiLevel.Visible = false;
                    sscLevel.Visible = true;
                    sscLevel.Text = "Please Input upto 0 and less than 5";

                }
                else if ( hsc <= 0 || hsc > 5)
                {
                    sscLevel.Visible = false;
                    HscLevel.Visible = true;
                    HscLevel.Text = "Please Input upto 0 and less than 5";

                }
               
          
                else if ( EmailValidation.CheckForMail(emailTextbox.Text))
                {
                    MemoryStream stream = new MemoryStream();

                    pictureBox3.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] ima = stream.ToArray();

                    string query = string.Format(@"insert into GeneralStudent values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')"
                            , idTextBox.Text, fullNameTextBox.Text,@ima, sexComboBox.Text, presentTextBox.Text,
                            permanentTextBox.Text, rollTextBox.Text, registrationTextBox.Text,
                            departmentComboBox.Text, sessionComboBox.Text, sscTextBox.Text, hsctextbox.Text,
                            mobileTextbox.Text, familyTextBox.Text, emailTextbox.Text);

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@ima", ima));

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
        
       
        private void nextButton_Click(object sender, EventArgs e)
        {

            idTextBox.Text = fullNameTextBox.Text = sexComboBox.Text = presentTextBox.Text = permanentTextBox.Text = rollTextBox.Text = registrationTextBox.Text =
            departmentComboBox.Text = sessionComboBox.Text = sscTextBox.Text = hsctextbox.Text = mobileTextbox.Text = familyTextBox.Text = emailTextbox.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            BasicForm form1 = new BasicForm();
            form1.ShowDialog();
        }

        
        private void rolTextBox_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con1 =
                       new SqlConnection(connectionString);
                con1.Open();
                try
                {
                   
                    SqlCommand command = new SqlCommand("select max(id) from GeneralStudent", con1);
                    
                    int i =Convert.ToInt16(command.ExecuteScalar().ToString());
                    
                    idTextBox.Text =(i+1).ToString();
                }

                finally
                {
                   con1.Close();
                }
            }
            catch(Exception abc)
            {
                MessageBox.Show(abc.Message);
            }
  

        }

        private void presentAddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (presentAddressCheckBox.Checked==false)

            {
                presentTextBox.Text = String.Empty;

            }
            else
            {
                presentTextBox.Text = permanentTextBox.Text;
            }

        }

        private void permanentTextBox_TextChanged(object sender, EventArgs e)
        {

            if (presentAddressCheckBox.Checked==true)
            {            
               presentTextBox.Text = permanentTextBox.Text;
            }


            
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
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
                  "select * from  GeneralStudent where id= ( SELECT TOP 1 id FROM GeneralStudent ORDER BY id DESC)", con1);
              

                    

                        myReader = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {
                      
                        idTextBox.Text = (myReader["id"].ToString());
                        fullNameTextBox.Text = (myReader["name"].ToString());
                        sexComboBox.Text = (myReader["sex"].ToString());
                        permanentTextBox.Text = (myReader["permanentAddress"].ToString());
                        presentTextBox.Text = (myReader["presentAddress"].ToString());
                        rollTextBox.Text = (myReader["roll"].ToString());
                        registrationTextBox.Text = (myReader["registration"].ToString());
                        departmentComboBox.Text = (myReader["deptname"].ToString());
                        sessionComboBox.Text = (myReader["session"].ToString());
                        sscTextBox.Text = (myReader["ssc"].ToString());
                        hsctextbox.Text = (myReader["hsc"].ToString());
                        mobileTextbox.Text = (myReader["mobile"].ToString());
                        familyTextBox.Text = (myReader["home"].ToString());
                        emailTextbox.Text = (myReader["email"].ToString());
                   

                        }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void PhotButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            try
            {


                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox3.Image = Image.FromFile(ofd.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sscTextBox_TextChanged(object sender, EventArgs e)
        {
            int ssc;
            


            bool sscresult = int.TryParse(sscTextBox.Text, out ssc);

            if (ssc <= 0 || ssc > 5)
            {
                regiLevel.Visible = false;
                sscLevel.Visible = true;
                sscLevel.Text = "Please Input upto 0 and less than 5";

            }

            else
            {
                        
                    
                sscLevel.Visible = false;
            }

              
        }

        private void HscLevel_Click(object sender, EventArgs e)
        {
          
            

        }

        private void hsctextbox_TextChanged(object sender, EventArgs e)
        {
           
              int hsc;
              bool hscresult = int.TryParse(hsctextbox.Text, out hsc);
            
           
              if ( hsc <= 0 || hsc > 5)
                {
                    sscLevel.Visible = false;
                    HscLevel.Visible = true;
                    HscLevel.Text = "Please Input upto 0 and less than 5";

                }

              else
              {
                 
                  HscLevel.Visible = false;
              }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {

        }
}



        }

         
            
        


    


