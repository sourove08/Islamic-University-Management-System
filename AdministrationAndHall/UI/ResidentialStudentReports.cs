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

namespace AdministrationAndHall
{
    public partial class residentialStudentReportsListView : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public residentialStudentReportsListView()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {


           
            SqlConnection connection = new SqlConnection(connectionString);
            
            SqlCommand cmd = new SqlCommand("Select *   from ResidentialStudent where HallName ='" + this.residentialComboBox.Text + "'", connection);

            try
            {

                panel1.Visible = true;
                residentialStudentdataGridView.Visible = true;
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                residentialStudentdataGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void residentialStudentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            ShowInformationButton.Visible = true;
            pictureBox1.Visible = true;
      
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.residentialStudentdataGridView.Rows[e.RowIndex];

                    selectedIDTextBox.Text = row.Cells["id"].Value.ToString();

                    SqlConnection con1 =
                        new SqlConnection(connectionString);
                    DataTable dt = new DataTable();
                    con1.Open();
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(
                        "select * from GeneralStudent where id='" + this.selectedIDTextBox.Text + "'", con1);


                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {


                        sexlebel.Text = (myReader["sex"].ToString());


                        permanent.Text = (myReader["permanentaddress"].ToString());

                        present.Text = (myReader["presentaddress"].ToString());
                        roll.Text = (myReader["roll"].ToString());
                        reg.Text = (myReader["registration"].ToString());
                        session.Text = (myReader["deptname"].ToString());
                        ssc.Text = (myReader["session"].ToString());
                        hsc.Text = (myReader["ssc"].ToString());
                        mobile.Text = (myReader["hsc"].ToString());
                        home.Text = (myReader["mobile"].ToString());

                        email.Text = (myReader["email"].ToString());

                    }

                }


        }

        private void ShowInformationButton_Click(object sender, EventArgs e)
        {

            infoBox.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicForm basic=new BasicForm();
            basic.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
                
            }


        }


    

