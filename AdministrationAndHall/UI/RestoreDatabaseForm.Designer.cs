namespace AdministrationAndHall.UI
{
    partial class RestoreDatabaseForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DatabaseNameComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.butnBrowse = new System.Windows.Forms.Button();
            this.textRestoreBox = new System.Windows.Forms.TextBox();
            this.butnconnect = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label4);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(100, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 102);
            this.panel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(92, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Administration Department ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DatabaseNameComboBox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.butnBrowse);
            this.panel1.Controls.Add(this.textRestoreBox);
            this.panel1.Location = new System.Drawing.Point(61, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 180);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Database Name";
            // 
            // DatabaseNameComboBox
            // 
            this.DatabaseNameComboBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DatabaseNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseNameComboBox.FormattingEnabled = true;
            this.DatabaseNameComboBox.Location = new System.Drawing.Point(223, 15);
            this.DatabaseNameComboBox.Name = "DatabaseNameComboBox";
            this.DatabaseNameComboBox.Size = new System.Drawing.Size(121, 27);
            this.DatabaseNameComboBox.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FloralWhite;
            this.button3.Image = global::AdministrationAndHall.Properties.Resources.FormClose;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(342, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Database to Restore";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FloralWhite;
            this.button2.Image = global::AdministrationAndHall.Properties.Resources.BackupDatabse;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(227, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Restore";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butnBrowse
            // 
            this.butnBrowse.BackColor = System.Drawing.Color.SlateGray;
            this.butnBrowse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnBrowse.ForeColor = System.Drawing.Color.FloralWhite;
            this.butnBrowse.Image = global::AdministrationAndHall.Properties.Resources.Next;
            this.butnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butnBrowse.Location = new System.Drawing.Point(460, 46);
            this.butnBrowse.Name = "butnBrowse";
            this.butnBrowse.Size = new System.Drawing.Size(113, 48);
            this.butnBrowse.TabIndex = 3;
            this.butnBrowse.Text = "Browse";
            this.butnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butnBrowse.UseVisualStyleBackColor = false;
            this.butnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // textRestoreBox
            // 
            this.textRestoreBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textRestoreBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRestoreBox.Location = new System.Drawing.Point(227, 58);
            this.textRestoreBox.Name = "textRestoreBox";
            this.textRestoreBox.Size = new System.Drawing.Size(212, 26);
            this.textRestoreBox.TabIndex = 2;
            // 
            // butnconnect
            // 
            this.butnconnect.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnconnect.ForeColor = System.Drawing.Color.DarkGreen;
            this.butnconnect.Location = new System.Drawing.Point(236, 120);
            this.butnconnect.Name = "butnconnect";
            this.butnconnect.Size = new System.Drawing.Size(264, 59);
            this.butnconnect.TabIndex = 12;
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
            this.panel4.Location = new System.Drawing.Point(99, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(732, 381);
            this.panel4.TabIndex = 13;
            // 
            // RestoreDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(924, 404);
            this.Controls.Add(this.panel4);
            this.Name = "RestoreDatabaseForm";
            this.Text = "RestoreDatabaseForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butnBrowse;
        private System.Windows.Forms.TextBox textRestoreBox;
        private System.Windows.Forms.Button butnconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DatabaseNameComboBox;
        private System.Windows.Forms.Panel panel4;
    }
}