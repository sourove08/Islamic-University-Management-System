namespace AdministrationAndHall.UI
{
    partial class StudentReports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sessionComboBox = new System.Windows.Forms.ComboBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentdataGridViewBox = new System.Windows.Forms.DataGridView();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hsc = new System.Windows.Forms.Label();
            this.rrr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Label();
            this.ssc = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.presentAddressLebel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.session = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.Label();
            this.sexlebel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.roll = new System.Windows.Forms.Label();
            this.permanent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.present = new System.Windows.Forms.Label();
            this.selectedIDTextBox = new System.Windows.Forms.TextBox();
            this.ShowInformationButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridViewBox)).BeginInit();
            this.infoBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(273, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 57);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Result For Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Select Department";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(346, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Select Session";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sessionComboBox
            // 
            this.sessionComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sessionComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sessionComboBox.FormattingEnabled = true;
            this.sessionComboBox.Items.AddRange(new object[] {
            "2006-2007",
            "2007-2008",
            "2008-2009",
            "2009-2010",
            "2010-2011",
            "2011-2012",
            "2012-2013",
            "2013-2014",
            "2014-2015",
            "2015-2016",
            "2016-2017"});
            this.sessionComboBox.Location = new System.Drawing.Point(477, 32);
            this.sessionComboBox.Name = "sessionComboBox";
            this.sessionComboBox.Size = new System.Drawing.Size(133, 27);
            this.sessionComboBox.TabIndex = 19;
            this.sessionComboBox.SelectedIndexChanged += new System.EventHandler(this.sessionComboBox_SelectedIndexChanged);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.departmentComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "CSE",
            "ICE",
            "APEE",
            "MATHEMATICS",
            "BANGLA",
            "PUBLIC ADMINISTRATION",
            "STATISTICS",
            "ENGLISH"});
            this.departmentComboBox.Location = new System.Drawing.Point(169, 28);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(171, 27);
            this.departmentComboBox.TabIndex = 20;
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sessionComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(134, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 82);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // StudentdataGridViewBox
            // 
            this.StudentdataGridViewBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentdataGridViewBox.Location = new System.Drawing.Point(134, 163);
            this.StudentdataGridViewBox.Name = "StudentdataGridViewBox";
            this.StudentdataGridViewBox.Size = new System.Drawing.Size(639, 405);
            this.StudentdataGridViewBox.TabIndex = 25;
            this.StudentdataGridViewBox.Visible = false;
            this.StudentdataGridViewBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentdataGridViewBox_CellContentClick);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.infoBox.Controls.Add(this.groupBox4);
            this.infoBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.Location = new System.Drawing.Point(802, 251);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(400, 317);
            this.infoBox.TabIndex = 28;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "More Information of the Selected Student";
            this.infoBox.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.hsc);
            this.groupBox4.Controls.Add(this.rrr);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.home);
            this.groupBox4.Controls.Add(this.ssc);
            this.groupBox4.Controls.Add(this.email);
            this.groupBox4.Controls.Add(this.presentAddressLebel);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.session);
            this.groupBox4.Controls.Add(this.mobile);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.reg);
            this.groupBox4.Controls.Add(this.sexlebel);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.roll);
            this.groupBox4.Controls.Add(this.permanent);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.present);
            this.groupBox4.Location = new System.Drawing.Point(27, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 271);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sex :";
            // 
            // hsc
            // 
            this.hsc.AutoSize = true;
            this.hsc.ForeColor = System.Drawing.Color.Green;
            this.hsc.Location = new System.Drawing.Point(164, 166);
            this.hsc.Name = "hsc";
            this.hsc.Size = new System.Drawing.Size(0, 19);
            this.hsc.TabIndex = 18;
            // 
            // rrr
            // 
            this.rrr.AutoSize = true;
            this.rrr.Location = new System.Drawing.Point(101, 223);
            this.rrr.Name = "rrr";
            this.rrr.Size = new System.Drawing.Size(56, 19);
            this.rrr.TabIndex = 16;
            this.rrr.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Permanent Address :";
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.ForeColor = System.Drawing.Color.Green;
            this.home.Location = new System.Drawing.Point(163, 204);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(0, 19);
            this.home.TabIndex = 16;
            // 
            // ssc
            // 
            this.ssc.AutoSize = true;
            this.ssc.ForeColor = System.Drawing.Color.Green;
            this.ssc.Location = new System.Drawing.Point(164, 147);
            this.ssc.Name = "ssc";
            this.ssc.Size = new System.Drawing.Size(0, 19);
            this.ssc.TabIndex = 18;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.ForeColor = System.Drawing.Color.Green;
            this.email.Location = new System.Drawing.Point(163, 223);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(0, 19);
            this.email.TabIndex = 16;
            // 
            // presentAddressLebel
            // 
            this.presentAddressLebel.AutoSize = true;
            this.presentAddressLebel.Location = new System.Drawing.Point(31, 71);
            this.presentAddressLebel.Name = "presentAddressLebel";
            this.presentAddressLebel.Size = new System.Drawing.Size(127, 19);
            this.presentAddressLebel.TabIndex = 16;
            this.presentAddressLebel.Text = "Present Address :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 19);
            this.label13.TabIndex = 16;
            this.label13.Text = "Home Mobile :";
            // 
            // session
            // 
            this.session.AutoSize = true;
            this.session.ForeColor = System.Drawing.Color.Green;
            this.session.Location = new System.Drawing.Point(163, 128);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(0, 19);
            this.session.TabIndex = 18;
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.ForeColor = System.Drawing.Color.Green;
            this.mobile.Location = new System.Drawing.Point(164, 185);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(0, 19);
            this.mobile.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Roll No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mobile Number :";
            // 
            // reg
            // 
            this.reg.AutoSize = true;
            this.reg.ForeColor = System.Drawing.Color.Green;
            this.reg.Location = new System.Drawing.Point(164, 109);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(0, 19);
            this.reg.TabIndex = 18;
            // 
            // sexlebel
            // 
            this.sexlebel.AutoSize = true;
            this.sexlebel.ForeColor = System.Drawing.Color.Green;
            this.sexlebel.Location = new System.Drawing.Point(164, 33);
            this.sexlebel.Name = "sexlebel";
            this.sexlebel.Size = new System.Drawing.Size(0, 19);
            this.sexlebel.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Registration :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "HSC Point :";
            // 
            // roll
            // 
            this.roll.AutoSize = true;
            this.roll.ForeColor = System.Drawing.Color.Green;
            this.roll.Location = new System.Drawing.Point(164, 90);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(0, 19);
            this.roll.TabIndex = 18;
            // 
            // permanent
            // 
            this.permanent.AutoSize = true;
            this.permanent.ForeColor = System.Drawing.Color.Green;
            this.permanent.Location = new System.Drawing.Point(164, 52);
            this.permanent.Name = "permanent";
            this.permanent.Size = new System.Drawing.Size(0, 19);
            this.permanent.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Session :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "SSC Point :";
            // 
            // present
            // 
            this.present.AutoSize = true;
            this.present.ForeColor = System.Drawing.Color.Green;
            this.present.Location = new System.Drawing.Point(164, 71);
            this.present.Name = "present";
            this.present.Size = new System.Drawing.Size(0, 19);
            this.present.TabIndex = 18;
            // 
            // selectedIDTextBox
            // 
            this.selectedIDTextBox.Location = new System.Drawing.Point(905, 51);
            this.selectedIDTextBox.Name = "selectedIDTextBox";
            this.selectedIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.selectedIDTextBox.TabIndex = 30;
            this.selectedIDTextBox.Visible = false;
            this.selectedIDTextBox.TextChanged += new System.EventHandler(this.selectedIDTextBox_TextChanged);
            // 
            // ShowInformationButton
            // 
            this.ShowInformationButton.BackColor = System.Drawing.Color.GhostWhite;
            this.ShowInformationButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowInformationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowInformationButton.Location = new System.Drawing.Point(855, 163);
            this.ShowInformationButton.Name = "ShowInformationButton";
            this.ShowInformationButton.Size = new System.Drawing.Size(281, 61);
            this.ShowInformationButton.TabIndex = 29;
            this.ShowInformationButton.Text = "Show More Information of this Student";
            this.ShowInformationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowInformationButton.UseVisualStyleBackColor = false;
            this.ShowInformationButton.Visible = false;
            this.ShowInformationButton.Click += new System.EventHandler(this.ShowInformationButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdministrationAndHall.Properties.Resources.SearchWithCart;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdministrationAndHall.Properties.Resources.ReportBook;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(322, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 297);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageKey = "(none)";
            this.button2.Location = new System.Drawing.Point(779, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 56);
            this.button2.TabIndex = 21;
            this.button2.Text = "Show";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.mainButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.ForeColor = System.Drawing.SystemColors.Info;
            this.mainButton.Image = global::AdministrationAndHall.Properties.Resources.FolderGenuine;
            this.mainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainButton.Location = new System.Drawing.Point(921, 577);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(94, 50);
            this.mainButton.TabIndex = 33;
            this.mainButton.Text = "Main";
            this.mainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Image = global::AdministrationAndHall.Properties.Resources.FormClose;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.Location = new System.Drawing.Point(1043, 577);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(93, 50);
            this.exit.TabIndex = 34;
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // StudentReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1214, 647);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.selectedIDTextBox);
            this.Controls.Add(this.ShowInformationButton);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StudentdataGridViewBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "StudentReports";
            this.Text = "Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridViewBox)).EndInit();
            this.infoBox.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sessionComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView StudentdataGridViewBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ShowInformationButton;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hsc;
        private System.Windows.Forms.Label rrr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Label ssc;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label presentAddressLebel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label session;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label reg;
        private System.Windows.Forms.Label sexlebel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label roll;
        private System.Windows.Forms.Label permanent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label present;
        private System.Windows.Forms.TextBox selectedIDTextBox;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button exit;
    }
}