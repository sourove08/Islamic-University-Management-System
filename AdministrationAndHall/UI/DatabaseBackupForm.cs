using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdministrationAndHall.UI
{
    public partial class DatabaseBackupForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
        private SqlCommand comm;
        private SqlDataReader reader;
        private string sql = "";
        public DatabaseBackupForm()
        {
            InitializeComponent();
           
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            if (DatabaseNameComboBox.Text == "")
            {
                MessageBox.Show("Please select a Database to Backup");
                return;
               
            }
            else
            {
                


                try
                {

                    
                    SqlConnection connection = new SqlConnection(connectionString);
                   
                    connection.Open();
                    
                    
                    sql = "BACKUP DATABASE " + DatabaseNameComboBox.Text + " TO DISK ='" + LocationTextBox.Text + "\\" + DatabaseNameComboBox.Text + "-" + DateTime.Now.Ticks + ".bak'";
                    comm = new SqlCommand(sql, connection);
                    
                    comm.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Database Backup Successfully.");
                }
                catch (Exception)
                {
                    MessageBox.Show("System Error");
                }
            }

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {

              
              FolderBrowserDialog fbd = new FolderBrowserDialog();
             
              try
              {

                  if (fbd.ShowDialog() == DialogResult.OK)

                      LocationTextBox.Text = fbd.SelectedPath;


              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              
              }

              
           
        }

        private System.Windows.Forms.DialogResult STAShowDialog(FolderBrowserDialog fbd)
        {
            throw new NotImplementedException();
        }

        private void butnconnect_Click(object sender, EventArgs e)
        {

             
           SqlCommand command;
           
            string sql = "";
            try
            {
            
               
                SqlConnection connection = new SqlConnection(connectionString);
                
                connection.Open();
                MessageBox.Show("Congratulations!!!\n\nSystem is connected With Database.", "Successful Notice Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
                sql="EXEC sp_databases";

                command=new SqlCommand(sql,connection);

                reader=command.ExecuteReader();
                DatabaseNameComboBox.Items.Clear();

                while (reader.Read())
                {
                
                DatabaseNameComboBox.Items.Add(reader[0].ToString());
                
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
