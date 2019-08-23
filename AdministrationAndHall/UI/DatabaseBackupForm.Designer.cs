namespace AdministrationAndHall.UI
{
    partial class DatabaseBackupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatabaseNameComboBox = new System.Windows.Forms.ComboBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.butnconnect = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location To Backup";
            // 
            // DatabaseNameComboBox
            // 
            this.DatabaseNameComboBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DatabaseNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseNameComboBox.FormattingEnabled = true;
            this.DatabaseNameComboBox.Location = new System.Drawing.Point(165, 17);
            this.DatabaseNameComboBox.Name = "DatabaseNameComboBox";
            this.DatabaseNameComboBox.Size = new System.Drawing.Size(121, 27);
            this.DatabaseNameComboBox.TabIndex = 1;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LocationTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTextBox.Location = new System.Drawing.Point(165, 58);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(100, 26);
            this.LocationTextBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BackupButton);
            this.panel1.Controls.Add(this.DatabaseNameComboBox);
            this.panel1.Controls.Add(this.BrowseButton);
            this.panel1.Controls.Add(this.LocationTextBox);
            this.panel1.Location = new System.Drawing.Point(129, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 180);
            this.panel1.TabIndex = 5;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SlateGray;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.ExitButton.Image = global::AdministrationAndHall.Properties.Resources.FormClose;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(280, 115);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(92, 51);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.BackColor = System.Drawing.Color.SlateGray;
            this.BackupButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.BackupButton.Image = global::AdministrationAndHall.Properties.Resources.BackupDatabse;
            this.BackupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackupButton.Location = new System.Drawing.Point(165, 115);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(100, 51);
            this.BackupButton.TabIndex = 4;
            this.BackupButton.Text = "Backup";
            this.BackupButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackupButton.UseVisualStyleBackColor = false;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.SlateGray;
            this.BrowseButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.BrowseButton.Image = global::AdministrationAndHall.Properties.Resources.Next;
            this.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseButton.Location = new System.Drawing.Point(271, 46);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(113, 48);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label4);
            this.panel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(27, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 102);
            this.panel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(127, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Administration Department ";
            // 
            // butnconnect
            // 
            this.butnconnect.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnconnect.ForeColor = System.Drawing.Color.DarkGreen;
            this.butnconnect.Location = new System.Drawing.Point(186, 122);
            this.butnconnect.Name = "butnconnect";
            this.butnconnect.Size = new System.Drawing.Size(306, 59);
            this.butnconnect.TabIndex = 11;
            this.butnconnect.Text = "Connect With Your System";
            this.butnconnect.UseVisualStyleBackColor = true;
            this.butnconnect.Click += new System.EventHandler(this.butnconnect_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.butnconnect);
            this.panel4.Location = new System.Drawing.Point(29, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(645, 379);
            this.panel4.TabIndex = 13;
            // 
            // DatabaseBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(707, 409);
            this.Controls.Add(this.panel4);
            this.Name = "DatabaseBackupForm";
            this.Text = "DatabaseBackupForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DatabaseNameComboBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butnconnect;
        private System.Windows.Forms.Panel panel4;
    }
}