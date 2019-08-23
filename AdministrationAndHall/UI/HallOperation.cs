using System.Configuration;
using System.Windows.Forms;

namespace AdministrationAndHall.UI
{
    public partial class HallOperation : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        public HallOperation()
        {
            InitializeComponent();
        }

        private void provostEntryTextBox_Click(object sender, System.EventArgs e)
        {
            ProvostEntryForm provost=new ProvostEntryForm();
            provost.ShowDialog();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ProvostList provost=new ProvostList();
            provost.ShowDialog();

        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            StudentModification result=new StudentModification();
            result.ShowDialog();
        }

       

        private void mainForm_Click(object sender, System.EventArgs e)
        {
            BasicForm Basic=new BasicForm();
            Basic.ShowDialog();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            ResidentialEntry residentialEntry=new ResidentialEntry();
            residentialEntry.ShowDialog();
        }
    }
}
