using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdministrationAndHall.UI
{
    public partial class StudentReports : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public StudentReports()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void sessionComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            pictureBox1.Visible = false;
           
            SqlConnection connection = new SqlConnection(connectionString);
            
            SqlCommand cmd = new SqlCommand("Select id,name,session,roll,registration,deptname from GeneralStudent where deptname ='" + this.departmentComboBox.Text + "' and session='" + this.sessionComboBox.Text + "'", connection);

            try
            {

                StudentdataGridViewBox.Visible = true;
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                StudentdataGridViewBox.DataSource = dt;
                connection.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            
                
        }

        private void StudentdataGridViewBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ShowInformationButton.Visible = true;
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =StudentdataGridViewBox .Rows[e.RowIndex];

                selectedIDTextBox.Text = row.Cells["id"].Value.ToString();

                SqlConnection con1 =
                    new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                con1.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(
                    "select * from GeneralStudent  where id='" + this.selectedIDTextBox.Text + "'", con1);


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
        }

        private void selectedIDTextBox_TextChanged(object sender, EventArgs e)
        {

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
    }
}
