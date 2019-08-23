namespace AdministrationAndHall.UI
{
    partial class ProvostList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvostList));
            this.exitButon = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.provostListDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowInformationButton = new System.Windows.Forms.Button();
            this.selectedIDTextBox = new System.Windows.Forms.TextBox();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.department = new System.Windows.Forms.Label();
            this.phd = new System.Windows.Forms.Label();
            this.msc = new System.Windows.Forms.Label();
            this.hons = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.permanent = new System.Windows.Forms.Label();
            this.present = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.provostListDataGridView)).BeginInit();
            this.infoBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButon
            // 
            this.exitButon.BackColor = System.Drawing.Color.LightGray;
            this.exitButon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButon.Image = global::AdministrationAndHall.Properties.Resources.FormClose;
            this.exitButon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitButon.Location = new System.Drawing.Point(988, 461);
            this.exitButon.Name = "exitButon";
            this.exitButon.Size = new System.Drawing.Size(95, 50);
            this.exitButon.TabIndex = 7;
            this.exitButon.Text = "Exit";
            this.exitButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButon.UseVisualStyleBackColor = false;
            this.exitButon.Click += new System.EventHandler(this.exitButon_Click);
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.Color.LightGray;
            this.mainButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.Image = global::AdministrationAndHall.Properties.Resources.FolderGenuine;
            this.mainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainButton.Location = new System.Drawing.Point(890, 461);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(92, 50);
            this.mainButton.TabIndex = 6;
            this.mainButton.Text = "Main";
            this.mainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, -91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Provost List";
            // 
            // provostListDataGridView
            // 
            this.provostListDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.provostListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.provostListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provostListDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.provostListDataGridView.Location = new System.Drawing.Point(166, 71);
            this.provostListDataGridView.Name = "provostListDataGridView";
            this.provostListDataGridView.Size = new System.Drawing.Size(576, 510);
            this.provostListDataGridView.TabIndex = 4;
            this.provostListDataGridView.Visible = false;
            this.provostListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.provostDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Provost List For All Hall";
            // 
            // ShowInformationButton
            // 
            this.ShowInformationButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ShowInformationButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowInformationButton.ForeColor = System.Drawing.Color.MintCream;
            this.ShowInformationButton.Location = new System.Drawing.Point(791, 136);
            this.ShowInformationButton.Name = "ShowInformationButton";
            this.ShowInformationButton.Size = new System.Drawing.Size(350, 61);
            this.ShowInformationButton.TabIndex = 23;
            this.ShowInformationButton.Text = "Show More Information of Any Provosts";
            this.ShowInformationButton.UseVisualStyleBackColor = false;
            this.ShowInformationButton.Visible = false;
            this.ShowInformationButton.Click += new System.EventHandler(this.ShowInformationButton_Click);
            // 
            // selectedIDTextBox
            // 
            this.selectedIDTextBox.Location = new System.Drawing.Point(890, 87);
            this.selectedIDTextBox.Name = "selectedIDTextBox";
            this.selectedIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.selectedIDTextBox.TabIndex = 22;
            this.selectedIDTextBox.Visible = false;
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.infoBox.Controls.Add(this.groupBox1);
            this.infoBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.Location = new System.Drawing.Point(748, 203);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(429, 253);
            this.infoBox.TabIndex = 24;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "More Information of the Selected Student";
            this.infoBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.department);
            this.groupBox1.Controls.Add(this.phd);
            this.groupBox1.Controls.Add(this.msc);
            this.groupBox1.Controls.Add(this.hons);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.mobile);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.permanent);
            this.groupBox1.Controls.Add(this.present);
            this.groupBox1.Location = new System.Drawing.Point(27, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 186);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.department.Location = new System.Drawing.Point(166, 117);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(0, 19);
            this.department.TabIndex = 19;
            // 
            // phd
            // 
            this.phd.AutoSize = true;
            this.phd.ForeColor = System.Drawing.Color.Green;
            this.phd.Location = new System.Drawing.Point(166, 98);
            this.phd.Name = "phd";
            this.phd.Size = new System.Drawing.Size(0, 19);
            this.phd.TabIndex = 19;
            // 
            // msc
            // 
            this.msc.AutoSize = true;
            this.msc.ForeColor = System.Drawing.Color.Green;
            this.msc.Location = new System.Drawing.Point(166, 79);
            this.msc.Name = "msc";
            this.msc.Size = new System.Drawing.Size(0, 19);
            this.msc.TabIndex = 19;
            // 
            // hons
            // 
            this.hons.AutoSize = true;
            this.hons.ForeColor = System.Drawing.Color.Green;
            this.hons.Location = new System.Drawing.Point(166, 60);
            this.hons.Name = "hons";
            this.hons.Size = new System.Drawing.Size(0, 19);
            this.hons.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Permanent Address :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.ForeColor = System.Drawing.Color.Green;
            this.email.Location = new System.Drawing.Point(169, 155);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(0, 19);
            this.email.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(45, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 19);
            this.label19.TabIndex = 16;
            this.label19.Text = "Deapartment :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Phd. From :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Msc From :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 19);
            this.label13.TabIndex = 16;
            this.label13.Text = "Hon\'s From :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 19);
            this.label14.TabIndex = 16;
            this.label14.Text = "Present Address :";
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.ForeColor = System.Drawing.Color.Green;
            this.mobile.Location = new System.Drawing.Point(166, 136);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(0, 19);
            this.mobile.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 19);
            this.label16.TabIndex = 16;
            this.label16.Text = "Mobile Number :";
            // 
            // permanent
            // 
            this.permanent.AutoSize = true;
            this.permanent.ForeColor = System.Drawing.Color.Green;
            this.permanent.Location = new System.Drawing.Point(169, 22);
            this.permanent.Name = "permanent";
            this.permanent.Size = new System.Drawing.Size(0, 19);
            this.permanent.TabIndex = 18;
            // 
            // present
            // 
            this.present.AutoSize = true;
            this.present.ForeColor = System.Drawing.Color.Green;
            this.present.Location = new System.Drawing.Point(169, 41);
            this.present.Name = "present";
            this.present.Size = new System.Drawing.Size(0, 19);
            this.present.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(12, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProvostList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1223, 593);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.ShowInformationButton);
            this.Controls.Add(this.selectedIDTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButon);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.provostListDataGridView);
            this.MaximizeBox = false;
            this.Name = "ProvostList";
            this.Text = "ProvostList";
            ((System.ComponentModel.ISupportInitialize)(this.provostListDataGridView)).EndInit();
            this.infoBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButon;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView provostListDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ShowInformationButton;
        private System.Windows.Forms.TextBox selectedIDTextBox;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label permanent;
        private System.Windows.Forms.Label present;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label phd;
        private System.Windows.Forms.Label msc;
        private System.Windows.Forms.Label hons;
    }
}