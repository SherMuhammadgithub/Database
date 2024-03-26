namespace DatabaseProject
{
    partial class Rubric_Level
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InputDetails = new System.Windows.Forms.TextBox();
            this.CbRbrcs = new System.Windows.Forms.ComboBox();
            this.CbRbrcLvl = new System.Windows.Forms.ComboBox();
            this.RbrcLvlGrid = new System.Windows.Forms.DataGridView();
            this.Students = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.AddBtn = new FontAwesome.Sharp.IconButton();
            this.UpdateBtn = new FontAwesome.Sharp.IconButton();
            this.DeleteBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RbrcLvlGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InputDetails
            // 
            this.InputDetails.AllowDrop = true;
            this.InputDetails.Location = new System.Drawing.Point(56, 432);
            this.InputDetails.Multiline = true;
            this.InputDetails.Name = "InputDetails";
            this.InputDetails.Size = new System.Drawing.Size(359, 105);
            this.InputDetails.TabIndex = 1;
            // 
            // CbRbrcs
            // 
            this.CbRbrcs.FormattingEnabled = true;
            this.CbRbrcs.Location = new System.Drawing.Point(56, 329);
            this.CbRbrcs.Name = "CbRbrcs";
            this.CbRbrcs.Size = new System.Drawing.Size(135, 24);
            this.CbRbrcs.TabIndex = 2;
            // 
            // CbRbrcLvl
            // 
            this.CbRbrcLvl.FormattingEnabled = true;
            this.CbRbrcLvl.Items.AddRange(new object[] {
            "Exceptional",
            "Good",
            "Fair",
            "Unsatisfactory"});
            this.CbRbrcLvl.Location = new System.Drawing.Point(242, 329);
            this.CbRbrcLvl.Name = "CbRbrcLvl";
            this.CbRbrcLvl.Size = new System.Drawing.Size(173, 24);
            this.CbRbrcLvl.TabIndex = 3;
            this.CbRbrcLvl.SelectedIndexChanged += new System.EventHandler(this.CbRbrcLvl_SelectedIndexChanged);
            // 
            // RbrcLvlGrid
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.RbrcLvlGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.RbrcLvlGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RbrcLvlGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RbrcLvlGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.RbrcLvlGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RbrcLvlGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.RbrcLvlGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RbrcLvlGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.RbrcLvlGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.RbrcLvlGrid.Location = new System.Drawing.Point(0, 0);
            this.RbrcLvlGrid.Name = "RbrcLvlGrid";
            this.RbrcLvlGrid.RowHeadersWidth = 51;
            this.RbrcLvlGrid.RowTemplate.Height = 24;
            this.RbrcLvlGrid.Size = new System.Drawing.Size(800, 221);
            this.RbrcLvlGrid.TabIndex = 9;
            this.RbrcLvlGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RbrcLvlGrid_CellContentClick);
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
            this.Students.Location = new System.Drawing.Point(39, 267);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Students.Size = new System.Drawing.Size(181, 47);
            this.Students.TabIndex = 30;
            this.Students.Text = " Rubric Id";
            this.Students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Students.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Students.UseVisualStyleBackColor = true;
            this.Students.Click += new System.EventHandler(this.Students_Click);
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
            this.iconButton1.Location = new System.Drawing.Point(39, 379);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(181, 47);
            this.iconButton1.TabIndex = 31;
            this.iconButton1.Text = " Details";
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
            this.iconButton2.Location = new System.Drawing.Point(226, 267);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(210, 47);
            this.iconButton2.TabIndex = 32;
            this.iconButton2.Text = " Rubric Level";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.AddBtn.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.AddBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.AddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBtn.IconSize = 32;
            this.AddBtn.Location = new System.Drawing.Point(295, 562);
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
            this.UpdateBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.UpdateBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.UpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateBtn.IconSize = 32;
            this.UpdateBtn.Location = new System.Drawing.Point(634, 238);
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
            this.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.DeleteBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBtn.IconSize = 32;
            this.DeleteBtn.Location = new System.Drawing.Point(475, 238);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(586, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = " Manage Rubrics Level here***";
            // 
            // Rubric_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.RbrcLvlGrid);
            this.Controls.Add(this.CbRbrcLvl);
            this.Controls.Add(this.CbRbrcs);
            this.Controls.Add(this.InputDetails);
            this.Name = "Rubric_Level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rubric_Level";
            this.Load += new System.EventHandler(this.Rubric_Level_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RbrcLvlGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputDetails;
        private System.Windows.Forms.ComboBox CbRbrcs;
        private System.Windows.Forms.ComboBox CbRbrcLvl;
        private System.Windows.Forms.DataGridView RbrcLvlGrid;
        private FontAwesome.Sharp.IconButton Students;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton AddBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private System.Windows.Forms.Label label1;
    }
}