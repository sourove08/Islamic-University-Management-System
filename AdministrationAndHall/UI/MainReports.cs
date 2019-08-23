using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdministrationAndHall.UI
{
    public partial class MainReports : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public MainReports()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void sessionComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {


            ProvostList reports=new ProvostList();
            reports.ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            StudentReports reportstu=new StudentReports();

            reportstu.ShowDialog();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            residentialStudentReportsListView resistudent=new residentialStudentReportsListView();
            resistudent.ShowDialog();
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            BasicForm basic=new BasicForm();
            basic.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con1 =
                   new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                con1.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(
                    "select deadline from  ResidentialStudent", con1);


                myReader = myCommand.ExecuteReader();
                int counterName = 0;

                while (myReader.Read())
                {

                    string databasevalue = myReader["deadline"].ToString();

                    DateTime databasedate = DateTime.Parse(databasevalue);
                    DateTime currentDate = DateTime.Now;


                    if (DateTime.Now <= databasedate)
                    {

                    int counterNotName = 0;
                    }

                    else
                    {
                       

                        counterName=counterName+1;
                                 
                    }

                }

                freeSitsTextBox.Text = counterName.ToString();
              

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FreeSitsReports free=new FreeSitsReports();
            free.ShowDialog();

        }

        private void MainReports_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
