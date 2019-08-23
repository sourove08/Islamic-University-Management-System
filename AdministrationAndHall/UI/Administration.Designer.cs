namespace AdministrationAndHall.UI
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resigningdateTimePickerBox = new System.Windows.Forms.DateTimePicker();
            this.joiningdateTimePickerBox = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exampleBox = new System.Windows.Forms.Label();
            this.emaillebelBox = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.presentTextBox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.mobileTextbox = new System.Windows.Forms.TextBox();
            this.permanentTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdministrationAndHall.Properties.Resources.BanglaAndEnglishLogo;
            this.pictureBox1.Location = new System.Drawing.Point(478, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(423, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.resigningdateTimePickerBox);
            this.groupBox1.Controls.Add(this.joiningdateTimePickerBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.exampleBox);
            this.groupBox1.Controls.Add(this.emaillebelBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.sexComboBox);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.presentTextBox);
            this.groupBox1.Controls.Add(this.emailTextbox);
            this.groupBox1.Controls.Add(this.mobileTextbox);
            this.groupBox1.Controls.Add(this.permanentTextBox);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(39, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 400);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrative Stuff Entry";
            // 
            // resigningdateTimePickerBox
            // 
            this.resigningdateTimePickerBox.CustomFormat = "dd-MM-yyyy";
            this.resigningdateTimePickerBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resigningdateTimePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.resigningdateTimePickerBox.Location = new System.Drawing.Point(657, 128);
            this.resigningdateTimePickerBox.Name = "resigningdateTimePickerBox";
            this.resigningdateTimePickerBox.Size = new System.Drawing.Size(113, 25);
            this.resigningdateTimePickerBox.TabIndex = 92;
            // 
            // joiningdateTimePickerBox
            // 
            this.joiningdateTimePickerBox.CustomFormat = "dd-MM-yyyy";
            this.joiningdateTimePickerBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joiningdateTimePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.joiningdateTimePickerBox.Location = new System.Drawing.Point(657, 81);
            this.joiningdateTimePickerBox.Name = "joiningdateTimePickerBox";
            this.joiningdateTimePickerBox.Size = new System.Drawing.Size(113, 25);
            this.joiningdateTimePickerBox.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(524, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 21);
            this.label7.TabIndex = 90;
            this.label7.Text = "Joining Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 89;
            this.label1.Text = "Resinging Date";
            // 
            // exampleBox
            // 
            this.exampleBox.AutoSize = true;
            this.exampleBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleBox.ForeColor = System.Drawing.Color.Green;
            this.exampleBox.Location = new System.Drawing.Point(664, 224);
            this.exampleBox.Name = "exampleBox";
            this.exampleBox.Size = new System.Drawing.Size(49, 19);
            this.exampleBox.TabIndex = 88;
            this.exampleBox.Text = "label1";
            this.exampleBox.Visible = false;
            // 
            // emaillebelBox
            // 
            this.emaillebelBox.AutoSize = true;
            this.emaillebelBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillebelBox.ForeColor = System.Drawing.Color.Maroon;
            this.emaillebelBox.Location = new System.Drawing.Point(589, 224);
            this.emaillebelBox.Name = "emaillebelBox";
            this.emaillebelBox.Size = new System.Drawing.Size(49, 19);
            this.emaillebelBox.TabIndex = 87;
            this.emaillebelBox.Text = "label1";
            this.emaillebelBox.Visible = false;
            this.emaillebelBox.Click += new System.EventHandler(this.emaillebelBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.nextButton);
            this.groupBox2.Controls.Add(this.previousButton);
            this.groupBox2.Controls.Add(this.mainButton);
            this.groupBox2.Controls.Add(this.exit);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(198, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 88);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Image = global::AdministrationAndHall.Properties.Resources.SaveWhite;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(19, 19);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(84, 56);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nextButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nextButton.Location = new System.Drawing.Point(117, 19);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(95, 56);
            this.nextButton.TabIndex = 30;
            this.nextButton.Text = "Next";
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.previousButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Image = global::AdministrationAndHall.Properties.Resources.Previous;
            this.previousButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.previousButton.Location = new System.Drawing.Point(218, 19);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(127, 56);
            this.previousButton.TabIndex = 31;
            this.previousButton.Text = "Previous";
            this.previousButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click_1);
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mainButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.Image = global::AdministrationAndHall.Properties.Resources.FolderGenuine;
            this.mainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainButton.Location = new System.Drawing.Point(351, 19);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(89, 56);
            this.mainButton.TabIndex = 32;
            this.mainButton.Text = "Main";
            this.mainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Image = global::AdministrationAndHall.Properties.Resources.FormClose;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.Location = new System.Drawing.Point(455, 19);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(93, 56);
            this.exit.TabIndex = 33;
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // sexComboBox
            // 
            this.sexComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sexComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexComboBox.Location = new System.Drawing.Point(217, 105);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(100, 29);
            this.sexComboBox.TabIndex = 84;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(137, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 21);
            this.label16.TabIndex = 83;
            this.label16.Text = "Sex";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.departmentComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "Exam Controller",
            "Assistant Exam Controller",
            "Sub Assistant Assistant Exam Controller",
            "Section Officer"});
            this.departmentComboBox.Location = new System.Drawing.Point(217, 224);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(216, 29);
            this.departmentComboBox.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 72;
            this.label8.Text = "Designation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 71;
            this.label5.Text = "Present Address";
            // 
            // presentTextBox
            // 
            this.presentTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.presentTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentTextBox.Location = new System.Drawing.Point(217, 179);
            this.presentTextBox.Multiline = true;
            this.presentTextBox.Name = "presentTextBox";
            this.presentTextBox.Size = new System.Drawing.Size(216, 31);
            this.presentTextBox.TabIndex = 79;
            // 
            // emailTextbox
            // 
            this.emailTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailTextbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.Location = new System.Drawing.Point(657, 177);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(217, 29);
            this.emailTextbox.TabIndex = 81;
            // 
            // mobileTextbox
            // 
            this.mobileTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mobileTextbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextbox.Location = new System.Drawing.Point(657, 37);
            this.mobileTextbox.MaxLength = 14;
            this.mobileTextbox.Name = "mobileTextbox";
            this.mobileTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mobileTextbox.Size = new System.Drawing.Size(151, 29);
            this.mobileTextbox.TabIndex = 80;
            // 
            // permanentTextBox
            // 
            this.permanentTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.permanentTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permanentTextBox.Location = new System.Drawing.Point(217, 140);
            this.permanentTextBox.Multiline = true;
            this.permanentTextBox.Name = "permanentTextBox";
            this.permanentTextBox.Size = new System.Drawing.Size(216, 33);
            this.permanentTextBox.TabIndex = 78;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fullNameTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTextBox.Location = new System.Drawing.Point(217, 70);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(230, 29);
            this.fullNameTextBox.TabIndex = 77;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.idTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(217, 32);
            this.idTextBox.MaxLength = 5;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 29);
            this.idTextBox.TabIndex = 76;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.idTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.idTextBox_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "Full Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(576, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 21);
            this.label14.TabIndex = 75;
            this.label14.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = " Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Permanent Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(534, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 74;
            this.label12.Text = "Mobile No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 73;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Administration";
            this.Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker resigningdateTimePickerBox;
        private System.Windows.Forms.DateTimePicker joiningdateTimePickerBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exampleBox;
        private System.Windows.Forms.Label emaillebelBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox presentTextBox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox mobileTextbox;
        private System.Windows.Forms.TextBox permanentTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
    }
}