namespace DatabaseProject
{
    partial class Student
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
            this.IpFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IpRegNo = new System.Windows.Forms.TextBox();
            this.IpEmail = new System.Windows.Forms.TextBox();
            this.IpContact = new System.Windows.Forms.TextBox();
            this.IpLastName = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CbStatus = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.StdGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StdGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Student";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IpFirstName
            // 
            this.IpFirstName.Location = new System.Drawing.Point(203, 63);
            this.IpFirstName.Name = "IpFirstName";
            this.IpFirstName.Size = new System.Drawing.Size(206, 22);
            this.IpFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reg No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // IpRegNo
            // 
            this.IpRegNo.Location = new System.Drawing.Point(203, 244);
            this.IpRegNo.Name = "IpRegNo";
            this.IpRegNo.Size = new System.Drawing.Size(206, 22);
            this.IpRegNo.TabIndex = 7;
            // 
            // IpEmail
            // 
            this.IpEmail.Location = new System.Drawing.Point(455, 161);
            this.IpEmail.Name = "IpEmail";
            this.IpEmail.Size = new System.Drawing.Size(191, 22);
            this.IpEmail.TabIndex = 8;
            // 
            // IpContact
            // 
            this.IpContact.Location = new System.Drawing.Point(203, 161);
            this.IpContact.Name = "IpContact";
            this.IpContact.Size = new System.Drawing.Size(206, 22);
            this.IpContact.TabIndex = 9;
            // 
            // IpLastName
            // 
            this.IpLastName.Location = new System.Drawing.Point(455, 63);
            this.IpLastName.Name = "IpLastName";
            this.IpLastName.Size = new System.Drawing.Size(191, 22);
            this.IpLastName.TabIndex = 10;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(255, 306);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status";
            // 
            // CbStatus
            // 
            this.CbStatus.FormattingEnabled = true;
            this.CbStatus.Location = new System.Drawing.Point(455, 244);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(191, 24);
            this.CbStatus.TabIndex = 13;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(364, 306);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(472, 306);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // StdGrid
            // 
            this.StdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StdGrid.Location = new System.Drawing.Point(158, 419);
            this.StdGrid.Name = "StdGrid";
            this.StdGrid.RowHeadersWidth = 51;
            this.StdGrid.RowTemplate.Height = 24;
            this.StdGrid.Size = new System.Drawing.Size(570, 251);
            this.StdGrid.TabIndex = 16;
            this.StdGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StdGrid_CellContentClick);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 725);
            this.Controls.Add(this.StdGrid);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.CbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.IpLastName);
            this.Controls.Add(this.IpContact);
            this.Controls.Add(this.IpEmail);
            this.Controls.Add(this.IpRegNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IpFirstName);
            this.Controls.Add(this.label1);
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.StdGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IpFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IpRegNo;
        private System.Windows.Forms.TextBox IpEmail;
        private System.Windows.Forms.TextBox IpContact;
        private System.Windows.Forms.TextBox IpLastName;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbStatus;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridView StdGrid;
    }
}