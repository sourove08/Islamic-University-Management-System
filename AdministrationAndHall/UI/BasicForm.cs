using System.Windows.Forms;

namespace AdministrationAndHall.UI
{
    public partial class BasicForm : Form
    {
        public BasicForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void StudentButton_Click(object sender, System.EventArgs e)
        {
            StudentInformation StuInformation=new StudentInformation();
            StuInformation.ShowDialog();
        }

        private void teachearButton_Click(object sender, System.EventArgs e)
        {
            Administration ad = new Administration();
            ad.ShowDialog();

        }

        private void hallOperationButton_Click(object sender, System.EventArgs e)
        {
            HallOperation Hall=new HallOperation();
            Hall.ShowDialog();
        }

      

        private void othersButton_Click(object sender, System.EventArgs e)
        {
            StudentModification modify=new StudentModification();
            modify.ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            MainReports reports=new MainReports();
            reports.ShowDialog();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
           SearchResidentialStudent resi=new SearchResidentialStudent();
            resi.ShowDialog();
        }

        private void createUserToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            userCreateForm create=new userCreateForm();
            create.ShowDialog();
        }

        private void deleteUserToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {

            
            removeUser user=new removeUser();
            user.ShowDialog();
            
            

        }

        private void exitToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            PasswordChange change=new PasswordChange();
            change.ShowDialog();
        }

        private void exitToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void mainToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            BasicForm form = new BasicForm();
            form.ShowDialog();


        }

        private void toolStripTextBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void createUserToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            userCreateForm form = new userCreateForm();
            form.ShowDialog();
        }

        private void deleteUserToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            removeUser remove = new removeUser();
            remove.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            PasswordChange change = new PasswordChange();
            change.ShowDialog();
        }

        private void exitToolStripMenuItem3_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem5_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void databaseBackupToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DatabaseBackupForm f = new DatabaseBackupForm();
            f.ShowDialog();
        }

        private void databaseRestoreToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            RestoreDatabaseForm r = new RestoreDatabaseForm();
            r.ShowDialog();
        }

        private void exitToolStripMenuItem4_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        }
    }

