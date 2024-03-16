namespace EmployeeMS
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpNameTb = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmpSalaryTb = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmpGenCb = new System.Windows.Forms.ComboBox();
            this.EmpDepCb = new System.Windows.Forms.ComboBox();
            this.DOBDateTb = new System.Windows.Forms.DateTimePicker();
            this.JDateTb = new System.Windows.Forms.DateTimePicker();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Salary = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmpData = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 94);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Protest Riot", 16.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(545, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMS Version 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Protest Riot", 12.8F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(25, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee Name";
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EmpNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.EmpNameTb.Location = new System.Drawing.Point(31, 198);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(290, 32);
            this.EmpNameTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Square721 BT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(671, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Manage Employees";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Protest Riot", 12.8F);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(25, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Employee Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Protest Riot", 12.8F);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(25, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "Employee Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Protest Riot", 12.8F);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(25, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 33);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date of Birth ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Protest Riot", 12.8F);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(25, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 33);
            this.label7.TabIndex = 18;
            this.label7.Text = "Join Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Protest Riot", 12.8F);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(25, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 33);
            this.label8.TabIndex = 20;
            this.label8.Text = "Employee Daily Salary";
            // 
            // EmpSalaryTb
            // 
            this.EmpSalaryTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EmpSalaryTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.EmpSalaryTb.Location = new System.Drawing.Point(31, 676);
            this.EmpSalaryTb.Name = "EmpSalaryTb";
            this.EmpSalaryTb.Size = new System.Drawing.Size(290, 32);
            this.EmpSalaryTb.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 782);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 19);
            this.panel2.TabIndex = 21;
            // 
            // EmpGenCb
            // 
            this.EmpGenCb.Font = new System.Drawing.Font("Modern No. 20", 12.8F, System.Drawing.FontStyle.Bold);
            this.EmpGenCb.FormattingEnabled = true;
            this.EmpGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGenCb.Location = new System.Drawing.Point(31, 297);
            this.EmpGenCb.Name = "EmpGenCb";
            this.EmpGenCb.Size = new System.Drawing.Size(290, 32);
            this.EmpGenCb.TabIndex = 22;
            // 
            // EmpDepCb
            // 
            this.EmpDepCb.Font = new System.Drawing.Font("Modern No. 20", 12.8F, System.Drawing.FontStyle.Bold);
            this.EmpDepCb.FormattingEnabled = true;
            this.EmpDepCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpDepCb.Location = new System.Drawing.Point(31, 391);
            this.EmpDepCb.Name = "EmpDepCb";
            this.EmpDepCb.Size = new System.Drawing.Size(290, 32);
            this.EmpDepCb.TabIndex = 23;
            // 
            // DOBDateTb
            // 
            this.DOBDateTb.CalendarForeColor = System.Drawing.Color.Teal;
            this.DOBDateTb.CalendarMonthBackground = System.Drawing.Color.Teal;
            this.DOBDateTb.Font = new System.Drawing.Font("Modern No. 20", 12.8F, System.Drawing.FontStyle.Bold);
            this.DOBDateTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBDateTb.Location = new System.Drawing.Point(31, 491);
            this.DOBDateTb.MaxDate = new System.DateTime(2024, 3, 7, 0, 0, 0, 0);
            this.DOBDateTb.Name = "DOBDateTb";
            this.DOBDateTb.Size = new System.Drawing.Size(290, 30);
            this.DOBDateTb.TabIndex = 24;
            this.DOBDateTb.Value = new System.DateTime(2024, 3, 7, 0, 0, 0, 0);
            // 
            // JDateTb
            // 
            this.JDateTb.Font = new System.Drawing.Font("Modern No. 20", 12.8F, System.Drawing.FontStyle.Bold);
            this.JDateTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.JDateTb.Location = new System.Drawing.Point(31, 582);
            this.JDateTb.MaxDate = new System.DateTime(2024, 3, 7, 0, 0, 0, 0);
            this.JDateTb.Name = "JDateTb";
            this.JDateTb.Size = new System.Drawing.Size(290, 30);
            this.JDateTb.TabIndex = 25;
            this.JDateTb.TabStop = false;
            this.JDateTb.Value = new System.DateTime(2024, 3, 7, 0, 0, 0, 0);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Teal;
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.AddBtn.FlatAppearance.BorderSize = 3;
            this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(31, 732);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(134, 44);
            this.AddBtn.TabIndex = 26;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.UpdateBtn.FlatAppearance.BorderSize = 3;
            this.UpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.UpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.UpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateBtn.Location = new System.Drawing.Point(187, 732);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(134, 44);
            this.UpdateBtn.TabIndex = 27;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Protest Riot", 12F);
            this.Logout.ForeColor = System.Drawing.Color.Teal;
            this.Logout.Location = new System.Drawing.Point(939, 125);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(72, 29);
            this.Logout.TabIndex = 61;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(869, 110);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Protest Riot", 12F);
            this.Salary.ForeColor = System.Drawing.Color.Teal;
            this.Salary.Location = new System.Drawing.Point(785, 125);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(65, 29);
            this.Salary.TabIndex = 59;
            this.Salary.Text = "Salary";
            this.Salary.Click += new System.EventHandler(this.Salary_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(715, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Protest Riot", 12F);
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(588, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 29);
            this.label11.TabIndex = 57;
            this.label11.Text = "Departments";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(518, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Protest Riot", 12F);
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(403, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 29);
            this.label12.TabIndex = 55;
            this.label12.Text = "Employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // EmpData
            // 
            this.EmpData.AllowDrop = true;
            this.EmpData.AllowUserToAddRows = false;
            this.EmpData.AllowUserToDeleteRows = false;
            this.EmpData.AllowUserToResizeColumns = false;
            this.EmpData.AllowUserToResizeRows = false;
            this.EmpData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmpData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpData.BackgroundColor = System.Drawing.Color.White;
            this.EmpData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmpData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpData.GridColor = System.Drawing.Color.White;
            this.EmpData.Location = new System.Drawing.Point(468, 297);
            this.EmpData.Name = "EmpData";
            this.EmpData.RowHeadersWidth = 51;
            this.EmpData.RowTemplate.Height = 24;
            this.EmpData.Size = new System.Drawing.Size(654, 342);
            this.EmpData.TabIndex = 62;
            this.EmpData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpData_CellContentClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.DeleteBtn.FlatAppearance.BorderSize = 3;
            this.DeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.DeleteBtn.Location = new System.Drawing.Point(725, 710);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(134, 44);
            this.DeleteBtn.TabIndex = 63;
            this.DeleteBtn.Text = "Delete ";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 801);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EmpData);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.JDateTb);
            this.Controls.Add(this.DOBDateTb);
            this.Controls.Add(this.EmpDepCb);
            this.Controls.Add(this.EmpGenCb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmpSalaryTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpNameTb);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox EmpNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox EmpSalaryTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox EmpGenCb;
        private System.Windows.Forms.ComboBox EmpDepCb;
        private System.Windows.Forms.DateTimePicker DOBDateTb;
        private System.Windows.Forms.DateTimePicker JDateTb;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView EmpData;
        private System.Windows.Forms.Button DeleteBtn;
    }
}