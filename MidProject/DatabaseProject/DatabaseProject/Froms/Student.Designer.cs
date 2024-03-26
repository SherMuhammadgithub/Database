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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IpFirstName = new System.Windows.Forms.TextBox();
            this.IpRegNo = new System.Windows.Forms.TextBox();
            this.IpEmail = new System.Windows.Forms.TextBox();
            this.IpContact = new System.Windows.Forms.TextBox();
            this.IpLastName = new System.Windows.Forms.TextBox();
            this.CbStatus = new System.Windows.Forms.ComboBox();
            this.StdGrid = new System.Windows.Forms.DataGridView();
            this.errorLName = new System.Windows.Forms.ErrorProvider(this.components);
            this.Students = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.AddBtn = new FontAwesome.Sharp.IconButton();
            this.DeleteBtn = new FontAwesome.Sharp.IconButton();
            this.UpdateBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StdGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLName)).BeginInit();
            this.SuspendLayout();
            // 
            // IpFirstName
            // 
            this.IpFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpFirstName.Location = new System.Drawing.Point(182, 102);
            this.IpFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpFirstName.Name = "IpFirstName";
            this.IpFirstName.Size = new System.Drawing.Size(181, 23);
            this.IpFirstName.TabIndex = 1;
            // 
            // IpRegNo
            // 
            this.IpRegNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpRegNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpRegNo.Location = new System.Drawing.Point(182, 186);
            this.IpRegNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpRegNo.Name = "IpRegNo";
            this.IpRegNo.Size = new System.Drawing.Size(181, 23);
            this.IpRegNo.TabIndex = 7;
            // 
            // IpEmail
            // 
            this.IpEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpEmail.Location = new System.Drawing.Point(182, 280);
            this.IpEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpEmail.Name = "IpEmail";
            this.IpEmail.Size = new System.Drawing.Size(181, 23);
            this.IpEmail.TabIndex = 8;
            this.IpEmail.Validating += new System.ComponentModel.CancelEventHandler(this.IpEmail_Validating);
            // 
            // IpContact
            // 
            this.IpContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpContact.Location = new System.Drawing.Point(414, 186);
            this.IpContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpContact.Name = "IpContact";
            this.IpContact.Size = new System.Drawing.Size(168, 23);
            this.IpContact.TabIndex = 9;
            // 
            // IpLastName
            // 
            this.IpLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IpLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IpLastName.Location = new System.Drawing.Point(414, 102);
            this.IpLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpLastName.Name = "IpLastName";
            this.IpLastName.Size = new System.Drawing.Size(168, 23);
            this.IpLastName.TabIndex = 10;
            this.IpLastName.Validating += new System.ComponentModel.CancelEventHandler(this.IpLastName_Validating);
            // 
            // CbStatus
            // 
            this.CbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CbStatus.FormattingEnabled = true;
            this.CbStatus.Location = new System.Drawing.Point(414, 280);
            this.CbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(168, 27);
            this.CbStatus.TabIndex = 13;
            // 
            // StdGrid
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Protest Riot", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Lime;
            this.StdGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StdGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StdGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StdGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.StdGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Protest Riot", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StdGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Protest Riot", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StdGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.StdGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StdGrid.Location = new System.Drawing.Point(0, 459);
            this.StdGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StdGrid.Name = "StdGrid";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Protest Riot", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StdGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.StdGrid.RowHeadersWidth = 51;
            this.StdGrid.RowTemplate.Height = 24;
            this.StdGrid.Size = new System.Drawing.Size(839, 149);
            this.StdGrid.TabIndex = 18;
            this.StdGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StdGrid_CellContentClick_1);
            // 
            // errorLName
            // 
            this.errorLName.ContainerControl = this;
            // 
            // Students
            // 
            this.Students.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Students.FlatAppearance.BorderSize = 0;
            this.Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Students.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.ForeColor = System.Drawing.Color.Gainsboro;
            this.Students.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.Students.IconColor = System.Drawing.Color.Gainsboro;
            this.Students.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Students.IconSize = 32;
            this.Students.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Students.Location = new System.Drawing.Point(164, 48);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Students.Size = new System.Drawing.Size(201, 47);
            this.Students.TabIndex = 19;
            this.Students.Text = "First Name";
            this.Students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Students.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Students.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(398, 48);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(233, 47);
            this.iconButton1.TabIndex = 20;
            this.iconButton1.Text = " Last Name";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(398, 132);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(175, 47);
            this.iconButton2.TabIndex = 21;
            this.iconButton2.Text = " Contact";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(164, 226);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(175, 47);
            this.iconButton3.TabIndex = 22;
            this.iconButton3.Text = " Email";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton4.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(164, 132);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(175, 47);
            this.iconButton4.TabIndex = 23;
            this.iconButton4.Text = " Reg No";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(398, 226);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton5.Size = new System.Drawing.Size(175, 47);
            this.iconButton5.TabIndex = 24;
            this.iconButton5.Text = "Status";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.AddBtn.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.AddBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.AddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBtn.IconSize = 32;
            this.AddBtn.Location = new System.Drawing.Point(150, 329);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AddBtn.Size = new System.Drawing.Size(120, 36);
            this.AddBtn.TabIndex = 35;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.UseMnemonic = false;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.DeleteBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBtn.IconSize = 32;
            this.DeleteBtn.Location = new System.Drawing.Point(297, 329);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.DeleteBtn.Size = new System.Drawing.Size(141, 36);
            this.DeleteBtn.TabIndex = 38;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteBtn.UseMnemonic = false;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.UpdateBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.UpdateBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.UpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateBtn.IconSize = 32;
            this.UpdateBtn.Location = new System.Drawing.Point(465, 329);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.UpdateBtn.Size = new System.Drawing.Size(142, 36);
            this.UpdateBtn.TabIndex = 39;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateBtn.UseMnemonic = false;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(604, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = " Manage Students here***";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.CbStatus);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.IpLastName);
            this.Controls.Add(this.IpEmail);
            this.Controls.Add(this.StdGrid);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.IpContact);
            this.Controls.Add(this.IpRegNo);
            this.Controls.Add(this.iconButton2);
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
        private System.Windows.Forms.TextBox IpRegNo;
        private System.Windows.Forms.TextBox IpEmail;
        private System.Windows.Forms.TextBox IpContact;
        private System.Windows.Forms.TextBox IpLastName;
        private System.Windows.Forms.ComboBox CbStatus;
        private System.Windows.Forms.DataGridView StdGrid;
        private System.Windows.Forms.ErrorProvider errorLName;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton Students;
        private FontAwesome.Sharp.IconButton AddBtn;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private System.Windows.Forms.Label label1;
    }
}