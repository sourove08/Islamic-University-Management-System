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
    public partial class FreeSitsReports : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public FreeSitsReports()
        {
            InitializeComponent();
        }

        private void FreeSitsReports_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            label2.Visible = false;
            
            SqlConnection con2 =
                    new SqlConnection(connectionString);

            con2.Open();
            if (residentialComboBox.Text == "")
            {

                MessageBox.Show("Please Select Any Hall Name.\nYou Entered Null Value\nThank You", "Error Message Window", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
            else
            {

                SqlCommand myCommand = new SqlCommand(
                    "select id ,entry ,deadline ,roomno FROM ResidentialStudent WHERE hallname ='" + residentialComboBox.Text + "'", con2);
                panel1.Visible = true;
                residentialdataGridView.Visible = true;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;
                DataTable dt = new DataTable();
                da.Fill(dt);
                residentialdataGridView.DataSource = dt;
                con2.Close();
            }

        }

        private void residentialStudentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowInformationButton.Visible = true;
          

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.residentialdataGridView.Rows[e.RowIndex];

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

                con1.Close();
                con1.Dispose();
            }
        }

        private void ShowInformationButton_Click(object sender, EventArgs e)
        {
            infoBox.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicForm form = new BasicForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            SqlConnection con2 =
                   new SqlConnection(connectionString);

            con2.Open();

            
          DateTime CurrentDatetime = new DateTime();
          CurrentDatetime = DateTime.Now ;
          SqlCommand myCommand = new SqlCommand(

          "select id ,entry ,deadline ,roomno FROM ResidentialStudent where  deadline < '"+dateTimePicker1.Value.ToString()+"' AND hallname='"+residentialComboBox.Text+"'", con2);
            
            residentialdataGridView.Visible = true;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = myCommand;
            DataTable dt = new DataTable();
            da.Fill(dt);
            residentialdataGridView.DataSource = dt;
            con2.Close();
        }

        private void currentDateText_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
