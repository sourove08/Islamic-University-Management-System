namespace AdministrationAndHall.UI
{
    partial class ProvostEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvostEntryForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTeachersIdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.provosthallComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deadlinedateTimePickerBox = new System.Windows.Forms.DateTimePicker();
            this.joiningdateTimePickerBox = new System.Windows.Forms.DateTimePicker();
            this.provostfullNametextBox = new System.Windows.Forms.TextBox();
            this.provostidTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.searchTeachersIdTextBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(297, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 88);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Teacher\'s Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchTeachersIdTextBox
            // 
            this.searchTeachersIdTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTeachersIdTextBox.Location = new System.Drawing.Point(172, 34);
            this.searchTeachersIdTextBox.Multiline = true;
            this.searchTeachersIdTextBox.Name = "searchTeachersIdTextBox";
            this.searchTeachersIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.searchTeachersIdTextBox.TabIndex = 2;
            this.searchTeachersIdTextBox.TextChanged += new System.EventHandler(this.searchTeachersIdTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(290, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.deadlinedateTimePickerBox);
            this.groupBox1.Controls.Add(this.joiningdateTimePickerBox);
            this.groupBox1.Controls.Add(this.provostfullNametextBox);
            this.groupBox1.Controls.Add(this.provostidTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(297, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 277);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Provosts Entry Section";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.provosthallComboBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(52, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 75);
            this.panel1.TabIndex = 34;
            // 
            // provosthallComboBox
            // 
            this.provosthallComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provosthallComboBox.FormattingEnabled = true;
            this.provosthallComboBox.Items.AddRange(new object[] {
            "Saddam Hossain Hall",
            "Bangabandhu Sheik Mujibor Rahaman Hall",
            "Shohid Ziaur Rahaman Hall",
            "Lalon Hall",
            "Begum Khaleda Zia Hall",
            "Fozilantunnesa Hall",
            "Seikh Hasina Hall"});
            this.provosthallComboBox.Location = new System.Drawing.Point(107, 26);
            this.provosthallComboBox.Name = "provosthallComboBox";
            this.provosthallComboBox.Size = new System.Drawing.Size(199, 27);
            this.provosthallComboBox.TabIndex = 32;
            this.provosthallComboBox.SelectedIndexChanged += new System.EventHandler(this.hallComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hall Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // deadlinedateTimePickerBox
            // 
            this.deadlinedateTimePickerBox.CustomFormat = "dd.MM.yyyy";
            this.deadlinedateTimePickerBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlinedateTimePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deadlinedateTimePickerBox.Location = new System.Drawing.Point(172, 146);
            this.deadlinedateTimePickerBox.Name = "deadlinedateTimePickerBox";
            this.deadlinedateTimePickerBox.Size = new System.Drawing.Size(121, 26);
            this.deadlinedateTimePickerBox.TabIndex = 33;
            this.deadlinedateTimePickerBox.ValueChanged += new System.EventHandler(this.deadlinedateTimePickerBox_ValueChanged);
            // 
            // joiningdateTimePickerBox
            // 
            this.joiningdateTimePickerBox.CustomFormat = "dd.MM.yyyy";
            this.joiningdateTimePickerBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joiningdateTimePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.joiningdateTimePickerBox.Location = new System.Drawing.Point(172, 106);
            this.joiningdateTimePickerBox.Name = "joiningdateTimePickerBox";
            this.joiningdateTimePickerBox.Size = new System.Drawing.Size(121, 26);
            this.joiningdateTimePickerBox.TabIndex = 33;
            this.joiningdateTimePickerBox.ValueChanged += new System.EventHandler(this.joiningdateTimePickerBox_ValueChanged);
            // 
            // provostfullNametextBox
            // 
            this.provostfullNametextBox.BackColor = System.Drawing.SystemColors.Window;
            this.provostfullNametextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provostfullNametextBox.Location = new System.Drawing.Point(172, 66);
            this.provostfullNametextBox.Multiline = true;
            this.provostfullNametextBox.Name = "provostfullNametextBox";
            this.provostfullNametextBox.Size = new System.Drawing.Size(212, 25);
            this.provostfullNametextBox.TabIndex = 15;
            this.provostfullNametextBox.TextChanged += new System.EventHandler(this.provostfullNametextBox_TextChanged);
            // 
            // provostidTextBox
            // 
            this.provostidTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.provostidTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provostidTextBox.Location = new System.Drawing.Point(172, 32);
            this.provostidTextBox.Name = "provostidTextBox";
            this.provostidTextBox.Size = new System.Drawing.Size(100, 26);
            this.provostidTextBox.TabIndex = 14;
            this.provostidTextBox.TextChanged += new System.EventHandler(this.provostidTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Provost Full Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Deadline Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Provost Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Joining Date";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(386, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 36);
            this.label1.TabIndex = 42;
            this.label1.Text = "Provost Entry Form";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(117, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 55);
            this.button2.TabIndex = 51;
            this.button2.Text = "Next";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(22, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.Location = new System.Drawing.Point(480, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(85, 56);
            this.exit.TabIndex = 47;
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.Image = global::AdministrationAndHall.Properties.Resources.FolderGenuine;
            this.mainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainButton.Location = new System.Drawing.Point(383, 12);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(91, 56);
            this.mainButton.TabIndex = 46;
            this.mainButton.Text = "Main";
            this.mainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(8, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 56);
            this.saveButton.TabIndex = 45;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.previousButton);
            this.groupBox3.Controls.Add(this.saveButton);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.mainButton);
            this.groupBox3.Controls.Add(this.exit);
            this.groupBox3.Location = new System.Drawing.Point(214, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 75);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.previousButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Image = global::AdministrationAndHall.Properties.Resources.Previous;
            this.previousButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.previousButton.Location = new System.Drawing.Point(233, 13);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(144, 53);
            this.previousButton.TabIndex = 52;
            this.previousButton.Text = "Previous";
            this.previousButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // ProvostEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(924, 529);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ProvostEntryForm";
            this.Text = "ProvostEntryForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTeachersIdTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox provosthallComboBox;
        private System.Windows.Forms.TextBox provostfullNametextBox;
        private System.Windows.Forms.TextBox provostidTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker joiningdateTimePickerBox;
        private System.Windows.Forms.DateTimePicker deadlinedateTimePickerBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button previousButton;
    }
}