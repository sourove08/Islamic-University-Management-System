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
using AdministrationAndHall.UI;

namespace AdministrationAndHall.UI
{
    public partial class SearchResidentialStudent : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;

        public SearchResidentialStudent()
        {
            InitializeComponent();
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

                        SqlDataReader abc = null;
                        SqlCommand command = new SqlCommand("select * from ResidentialStudent where id='" + searchTextBox.Text + "'", con1);

                        abc = command.ExecuteReader();

                        while (abc.Read())
                        {
                            hallNameComboBox.Text = (abc["HallName"].ToString());
                            entryDateTextBox.Text = (abc["Entry"].ToString());
                            deadlineTextBox.Text = (abc["Deadline"].ToString());

                        }

                        System.Windows.Forms.DialogResult result = MessageBox.Show("Success\n\nStudent ID  :" + idTextBox.Text + "\nFull Name  :" +
                                        fullNameTextBox.Text + "\nSex  :" + sexComboBox.Text + "\nPermanent Address  :" +
                                        permanentTextBox.Text + "\nPresent Address  :" + presentTextBox.Text + "\nRoll  :" +
                                        registrationTextBox.Text + "\nDepartment Name  :" + departmentComboBox.Text +
                                        "\nSession  :" + sessionComboBox.Text + "\nSSC Result  :" + sscTextBox.Text +
                                        "\nHSC Result  : " + hsctextbox.Text + "\nMobile No  :" + mobileTextbox.Text +
                                        "\nHome Mobile  :" + familyTextBox.Text
                                        + "\nEmail Id  :" + emailTextbox.Text + "\nHall Name  :" + hallNameComboBox.Text + "\nEntry Date  :" + entryDateTextBox.Text + "\nDeadline Date  :" + entryDateTextBox.Text + "\n\nThank You.", "Information and Confirmation Window", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        System.Windows.Forms.DialogResult dialogResult1 = MessageBox.Show(
                                "Do You Want To Update or Delete " + fullNameTextBox.Text + "'s Information?",
                                "Confirmation Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                        if (dialogResult1 == DialogResult.Yes)
                        {


                            Panel1.Visible = true;


                        }


                        else if (result == DialogResult.No)
                        {

                            Application.Exit();

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


                string query = "update studentinfo set fullname='" + this.fullNameTextBox.Text + "', sex= '" +
                               this.sexComboBox.Text + "',  permanentaddress= '" + this.permanentTextBox.Text +
                               "', presentaddress= '" + this.presentTextBox.Text + "', roll= '" + this.rollTextBox.Text +
                               "', reg= '" + this.registrationTextBox.Text + "', deptname= '" +
                               this.departmentComboBox.Text + "', session= '" + this.sessionComboBox.Text + "', ssc= '" +
                               this.sscTextBox.Text + "', hsc= '" + this.hsctextbox.Text + "', mobile= '" +
                               this.mobileTextbox.Text + "', home= '" + this.familyTextBox.Text + "',email= '" +
                               this.emailTextbox.Text + "'  where id='" + this.idTextBox.Text + "';";

                SqlCommand command = new SqlCommand();

                command.Connection = connection;

                command.CommandText = query;


                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Data Succsfully Updated", "Sucessfull Window", MessageBoxButtons.OK, MessageBoxIcon.Information);

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



























        private void mainButton_Click(object sender, EventArgs e)
        {
            BasicForm form = new BasicForm();
            form.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            entrydateTimePickerBox.Visible = true;
            entryDateTextBox.Visible = false;
        }

        private void editButton2_Click(object sender, EventArgs e)
        {
            deadlinedateTimePickerBox.Visible = true;
            deadlineTextBox.Visible = false;
        }

        private void updateButton_Click_1(object sender, EventArgs e)
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
                               this.emailTextbox.Text + "'  where id='" + this.idTextBox.Text + "';";

                SqlCommand command = new SqlCommand();

                command.Connection = connection;

                command.CommandText = query;


                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {


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




            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();


                string query = "update ResidentialStudent set HallName='" + this.hallNameComboBox.Text + "', EntryDate= '" +
                               this.entrydateTimePickerBox.Text + "',  Deadline= '" + this.deadlinedateTimePickerBox.Text + "'";

                SqlCommand command = new SqlCommand();

                command.Connection = connection;

                command.CommandText = query;


                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Data Succsfully Updated", "Sucessfull Window", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


                DialogResult exitresult = MessageBox.Show("Do you Want to Delete " + fullNameTextBox.Text + "'s Data?",
                                                          "Delete Confirmation Dialog Box",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (exitresult == DialogResult.Yes)
                {

                    string query = "delete from ResidentialStudent where id='" + this.idTextBox.Text + "';";

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    command.CommandText = query;


                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show(" Data Deleted Succsfully", "Delete Confirmation Window", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        string query1 = "delete from ResidentialStudent where id='" + this.searchTextBox.Text + "';";

                        SqlCommand command1 = new SqlCommand();
                        command1.Connection = connection;

                        command1.CommandText = query1;


                        int rows1 = command1.ExecuteNonQuery();

                        if (rows1 > 0)
                        {
                            MessageBox.Show(" Data Deleted Succsfully", "Delete Confirmation Window",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }


                        
                        
                    }
                }


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
                    emailTextbox.Text =
                    hallNameComboBox.Text =
                    entryDateTextBox.Text =
                    deadlineTextBox.Text = "";


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void SearchResidentialStudent_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


   
            

            
