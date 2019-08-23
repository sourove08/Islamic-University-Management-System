using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdministrationAndHall.UI
{
    public partial class ProvostList : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public ProvostList()
        {
            InitializeComponent();
        }

        private void mainButton_Click(object sender, System.EventArgs e)
        {
            BasicForm basic=new BasicForm();
            basic.ShowDialog();
        }

        private void provostDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowInformationButton.Visible = true;
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.provostListDataGridView.Rows[e.RowIndex];

                selectedIDTextBox.Text = row.Cells["id"].Value.ToString();

                SqlConnection con1 =
                    new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                con1.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(
                    "select * from TeacharsEntry where id='" + this.selectedIDTextBox.Text + "'", con1);


                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {




                    permanent.Text = (myReader["permanetaddress"].ToString());

                    present.Text = (myReader["presentaddress"].ToString());

                    hons.Text = (myReader["hons"].ToString());
                    msc.Text = (myReader["masters"].ToString());
                    phd.Text = (myReader["phd"].ToString());
                    department.Text = (myReader["deptname"].ToString());
                    mobile.Text = (myReader["mobile"].ToString());

                    email.Text = (myReader["email"].ToString());



                }






            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            provostListDataGridView.Visible = true;
           
            SqlConnection connection = new SqlConnection(connectionString);
            
            SqlCommand cmd = new SqlCommand("Select *   from ProvostEntry",connection);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
               provostListDataGridView.DataSource = dt;
               connection.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


        }

        private void ShowInformationButton_Click(object sender, EventArgs e)
        {
            infoBox.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void exitButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
