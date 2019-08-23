using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdministrationAndHall.UI
{
 
    public partial class RestoreDatabaseForm : Form
    {
        

        public RestoreDatabaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            ofd.FilterIndex = 0;


            if (ofd.ShowDialog() == DialogResult.OK)

            {
                textRestoreBox.Text = ofd.FileName;
            
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"server=(local)\SQLEXPRESS;integrated security=true";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                SqlCommand command = new SqlCommand();
                string sql = "";
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                  
                    connection.Open();

                    sql = "ALTER Database " + DatabaseNameComboBox.Text+ " SET single_user WITH ROLLBACK IMMEDIATE ;";

                    sql += "Restore Database " + DatabaseNameComboBox.Text + " from Disk='" + textRestoreBox.Text + "' WITH REPLACE;";

                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
     
                    MessageBox.Show("Database Restored Successful!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("System Error");
            }       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butnconnect_Click(object sender, EventArgs e)
        {
            SqlDataReader reader;

            SqlCommand command;

            string sql = "";
            try
            {

                string connectionString = @"server=(local)\SQLEXPRESS;integrated security=true";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                sql = "EXEC sp_databases";

                command = new SqlCommand(sql, connection);

                reader = command.ExecuteReader();
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
    }
}
