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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.errorLName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StdGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLName)).BeginInit();
            this.SuspendLayout();
            // 
            // IpFirstName
            // 
            this.IpFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpFirstName.Location = new System.Drawing.Point(199, 47);
            this.IpFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpFirstName.Name = "IpFirstName";
            this.IpFirstName.Size = new System.Drawing.Size(181, 23);
            this.IpFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Protest Riot", 10.8F);
            this.label2.Location = new System.Drawing.Point(108, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Protest Riot", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Protest Riot", 10.8F);
            this.label4.Location = new System.Drawing.Point(405, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Protest Riot", 10.8F);
            this.label5.Location = new System.Drawing.Point(113, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reg No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Protest Riot", 10.8F);
            this.label6.Location = new System.Drawing.Point(436, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // IpRegNo
            // 
            this.IpRegNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpRegNo.Location = new System.Drawing.Point(199, 259);
            this.IpRegNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpRegNo.Name = "IpRegNo";
            this.IpRegNo.Size = new System.Drawing.Size(181, 23);
            this.IpRegNo.TabIndex = 7;
            // 
            // IpEmail
            // 
            this.IpEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpEmail.Location = new System.Drawing.Point(517, 159);
            this.IpEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpEmail.Name = "IpEmail";
            this.IpEmail.Size = new System.Drawing.Size(168, 23);
            this.IpEmail.TabIndex = 8;
            this.IpEmail.Validating += new System.ComponentModel.CancelEventHandler(this.IpEmail_Validating);
            // 
            // IpContact
            // 
            this.IpContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpContact.Location = new System.Drawing.Point(199, 160);
            this.IpContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpContact.Name = "IpContact";
            this.IpContact.Size = new System.Drawing.Size(181, 23);
            this.IpContact.TabIndex = 9;
            // 
            // IpLastName
            // 
            this.IpLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpLastName.Location = new System.Drawing.Point(517, 47);
            this.IpLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpLastName.Name = "IpLastName";
            this.IpLastName.Size = new System.Drawing.Size(168, 23);
            this.IpLastName.TabIndex = 10;
            this.IpLastName.Validating += new System.ComponentModel.CancelEventHandler(this.IpLastName_Validating);
            this.IpLastName.Validated += new System.EventHandler(this.Add_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(257, 350);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(98, 41);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Protest Riot", 10.8F);
            this.label7.Location = new System.Drawing.Point(429, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status";
            // 
            // CbStatus
            // 
            this.CbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CbStatus.FormattingEnabled = true;
            this.CbStatus.Location = new System.Drawing.Point(517, 258);
            this.CbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(168, 27);
            this.CbStatus.TabIndex = 13;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(373, 350);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(99, 41);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(493, 350);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(92, 41);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // StdGrid
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Protest Riot", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Lime;
            this.StdGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StdGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StdGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StdGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StdGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.StdGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Protest Riot", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StdGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StdGrid.Location = new System.Drawing.Point(-1, 424);
            this.StdGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StdGrid.Name = "StdGrid";
            this.StdGrid.RowHeadersWidth = 51;
            this.StdGrid.RowTemplate.Height = 24;
            this.StdGrid.Size = new System.Drawing.Size(834, 430);
            this.StdGrid.TabIndex = 18;
            this.StdGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StdGrid_CellContentClick_1);
            // 
            // errorLName
            // 
            this.errorLName.ContainerControl = this;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 834);
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
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Protest Riot", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StdGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ErrorProvider errorLName;
    }
}