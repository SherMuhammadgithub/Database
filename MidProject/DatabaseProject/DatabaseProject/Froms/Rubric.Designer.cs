namespace DatabaseProject
{
    partial class Rubric
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InputRubDetail = new System.Windows.Forms.TextBox();
            this.CLOsCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RbrcDataGrid = new System.Windows.Forms.DataGridView();
            this.InputRbrcId = new System.Windows.Forms.TextBox();
            this.Students = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.AddBtn = new FontAwesome.Sharp.IconButton();
            this.UpdateBtn = new FontAwesome.Sharp.IconButton();
            this.DeleteBtn = new FontAwesome.Sharp.IconButton();
            this.RbrcLvl = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RbrcDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InputRubDetail
            // 
            this.InputRubDetail.Location = new System.Drawing.Point(161, 415);
            this.InputRubDetail.Multiline = true;
            this.InputRubDetail.Name = "InputRubDetail";
            this.InputRubDetail.Size = new System.Drawing.Size(157, 26);
            this.InputRubDetail.TabIndex = 2;
            // 
            // CLOsCb
            // 
            this.CLOsCb.FormattingEnabled = true;
            this.CLOsCb.Location = new System.Drawing.Point(262, 310);
            this.CLOsCb.Name = "CLOsCb";
            this.CLOsCb.Size = new System.Drawing.Size(157, 24);
            this.CLOsCb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = " ";
            // 
            // RbrcDataGrid
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            this.RbrcDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.RbrcDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RbrcDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RbrcDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RbrcDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.RbrcDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RbrcDataGrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.RbrcDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.RbrcDataGrid.Location = new System.Drawing.Point(0, 0);
            this.RbrcDataGrid.Name = "RbrcDataGrid";
            this.RbrcDataGrid.RowHeadersWidth = 51;
            this.RbrcDataGrid.RowTemplate.Height = 24;
            this.RbrcDataGrid.Size = new System.Drawing.Size(800, 200);
            this.RbrcDataGrid.TabIndex = 12;
            this.RbrcDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RbrcDataGrid_CellContentClick);
            // 
            // InputRbrcId
            // 
            this.InputRbrcId.Location = new System.Drawing.Point(64, 312);
            this.InputRbrcId.Name = "InputRbrcId";
            this.InputRbrcId.Size = new System.Drawing.Size(157, 22);
            this.InputRbrcId.TabIndex = 13;
            // 
            // Students
            // 
            this.Students.FlatAppearance.BorderSize = 0;
            this.Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Students.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.ForeColor = System.Drawing.Color.Gainsboro;
            this.Students.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.Students.IconColor = System.Drawing.Color.Gainsboro;
            this.Students.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Students.IconSize = 32;
            this.Students.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Students.Location = new System.Drawing.Point(52, 257);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Students.Size = new System.Drawing.Size(181, 47);
            this.Students.TabIndex = 30;
            this.Students.Text = "Rubric ID";
            this.Students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Students.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Students.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(137, 362);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(226, 47);
            this.iconButton1.TabIndex = 31;
            this.iconButton1.Text = " Rubric Name";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(239, 257);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(181, 47);
            this.iconButton2.TabIndex = 32;
            this.iconButton2.Text = " Clo Name";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.AddBtn.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.AddBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.AddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBtn.IconSize = 32;
            this.AddBtn.Location = new System.Drawing.Point(182, 482);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AddBtn.Size = new System.Drawing.Size(120, 36);
            this.AddBtn.TabIndex = 34;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.UseMnemonic = false;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.UpdateBtn.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.UpdateBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.UpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateBtn.IconSize = 32;
            this.UpdateBtn.Location = new System.Drawing.Point(632, 233);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.UpdateBtn.Size = new System.Drawing.Size(142, 36);
            this.UpdateBtn.TabIndex = 38;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateBtn.UseMnemonic = false;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.DeleteBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBtn.IconSize = 32;
            this.DeleteBtn.Location = new System.Drawing.Point(473, 233);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.DeleteBtn.Size = new System.Drawing.Size(141, 36);
            this.DeleteBtn.TabIndex = 37;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteBtn.UseMnemonic = false;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // RbrcLvl
            // 
            this.RbrcLvl.BackColor = System.Drawing.Color.GhostWhite;
            this.RbrcLvl.FlatAppearance.BorderSize = 0;
            this.RbrcLvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbrcLvl.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbrcLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.RbrcLvl.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.RbrcLvl.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.RbrcLvl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RbrcLvl.IconSize = 32;
            this.RbrcLvl.Location = new System.Drawing.Point(582, 482);
            this.RbrcLvl.Name = "RbrcLvl";
            this.RbrcLvl.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.RbrcLvl.Size = new System.Drawing.Size(192, 36);
            this.RbrcLvl.TabIndex = 39;
            this.RbrcLvl.Text = " Rubric Level";
            this.RbrcLvl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RbrcLvl.UseMnemonic = false;
            this.RbrcLvl.UseVisualStyleBackColor = false;
            this.RbrcLvl.Click += new System.EventHandler(this.RbrcLvl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = " Manage Rubrics here***";
            // 
            // Rubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbrcLvl);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.InputRbrcId);
            this.Controls.Add(this.RbrcDataGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CLOsCb);
            this.Controls.Add(this.InputRubDetail);
            this.Name = "Rubric";
            this.Text = "Rubric";
            ((System.ComponentModel.ISupportInitialize)(this.RbrcDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputRubDetail;
        private System.Windows.Forms.ComboBox CLOsCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView RbrcDataGrid;
        private System.Windows.Forms.TextBox InputRbrcId;
        private FontAwesome.Sharp.IconButton Students;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton AddBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton RbrcLvl;
        private System.Windows.Forms.Label label1;
    }
}