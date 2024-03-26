namespace DatabaseProject
{
    partial class StudentResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbStd = new System.Windows.Forms.ComboBox();
            this.CbAss = new System.Windows.Forms.ComboBox();
            this.CbAssComp = new System.Windows.Forms.ComboBox();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.CbRbrcs = new System.Windows.Forms.ComboBox();
            this.CbRbrcsScore = new System.Windows.Forms.ComboBox();
            this.Students = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.EvaluateBt = new FontAwesome.Sharp.IconButton();
            this.ReportBt = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // CbStd
            // 
            this.CbStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbStd.FormattingEnabled = true;
            this.CbStd.Location = new System.Drawing.Point(202, 81);
            this.CbStd.Name = "CbStd";
            this.CbStd.Size = new System.Drawing.Size(163, 28);
            this.CbStd.TabIndex = 2;
            // 
            // CbAss
            // 
            this.CbAss.FormattingEnabled = true;
            this.CbAss.Location = new System.Drawing.Point(563, 81);
            this.CbAss.Name = "CbAss";
            this.CbAss.Size = new System.Drawing.Size(181, 24);
            this.CbAss.TabIndex = 4;
            this.CbAss.SelectedIndexChanged += new System.EventHandler(this.CbAss_SelectedIndexChanged);
            // 
            // CbAssComp
            // 
            this.CbAssComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAssComp.FormattingEnabled = true;
            this.CbAssComp.Location = new System.Drawing.Point(202, 166);
            this.CbAssComp.Name = "CbAssComp";
            this.CbAssComp.Size = new System.Drawing.Size(163, 28);
            this.CbAssComp.TabIndex = 5;
            this.CbAssComp.SelectedIndexChanged += new System.EventHandler(this.CbAssComp_SelectedIndexChanged);
            // 
            // dataGridViewResults
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataGridViewResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewResults.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResults.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewResults.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewResults.Location = new System.Drawing.Point(0, 457);
            this.dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.RowTemplate.Height = 24;
            this.dataGridViewResults.Size = new System.Drawing.Size(768, 193);
            this.dataGridViewResults.TabIndex = 8;
            this.dataGridViewResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResults_CellContentClick);
            // 
            // CbRbrcs
            // 
            this.CbRbrcs.FormattingEnabled = true;
            this.CbRbrcs.Location = new System.Drawing.Point(575, 166);
            this.CbRbrcs.Name = "CbRbrcs";
            this.CbRbrcs.Size = new System.Drawing.Size(169, 24);
            this.CbRbrcs.TabIndex = 9;
            this.CbRbrcs.SelectedIndexChanged += new System.EventHandler(this.CbRbrcs_SelectedIndexChanged);
            // 
            // CbRbrcsScore
            // 
            this.CbRbrcsScore.FormattingEnabled = true;
            this.CbRbrcsScore.Location = new System.Drawing.Point(382, 262);
            this.CbRbrcsScore.Name = "CbRbrcsScore";
            this.CbRbrcsScore.Size = new System.Drawing.Size(162, 24);
            this.CbRbrcsScore.TabIndex = 11;
            this.CbRbrcsScore.SelectedIndexChanged += new System.EventHandler(this.CbRbrcsScore_SelectedIndexChanged);
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
            this.Students.Location = new System.Drawing.Point(21, 68);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Students.Size = new System.Drawing.Size(175, 47);
            this.Students.TabIndex = 14;
            this.Students.Text = "Students";
            this.Students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Students.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Students.UseVisualStyleBackColor = true;
            // 
            // iconButton7
            // 
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.iconButton7.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 32;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(371, 68);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton7.Size = new System.Drawing.Size(205, 47);
            this.iconButton7.TabIndex = 15;
            this.iconButton7.Text = "Assessment";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 153);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(205, 47);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.Text = "Assessment Compoenent";
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
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(386, 153);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(158, 47);
            this.iconButton2.TabIndex = 17;
            this.iconButton2.Text = "Rubric";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(154, 249);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(222, 47);
            this.iconButton3.TabIndex = 18;
            this.iconButton3.Text = "Rubric Score";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // EvaluateBt
            // 
            this.EvaluateBt.BackColor = System.Drawing.Color.Gainsboro;
            this.EvaluateBt.FlatAppearance.BorderSize = 0;
            this.EvaluateBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EvaluateBt.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluateBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.EvaluateBt.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.EvaluateBt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.EvaluateBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EvaluateBt.IconSize = 32;
            this.EvaluateBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EvaluateBt.Location = new System.Drawing.Point(431, 328);
            this.EvaluateBt.Name = "EvaluateBt";
            this.EvaluateBt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EvaluateBt.Size = new System.Drawing.Size(161, 36);
            this.EvaluateBt.TabIndex = 19;
            this.EvaluateBt.Text = "Evaluate";
            this.EvaluateBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EvaluateBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EvaluateBt.UseMnemonic = false;
            this.EvaluateBt.UseVisualStyleBackColor = false;
            this.EvaluateBt.Click += new System.EventHandler(this.EvaluateBt_Click);
            // 
            // ReportBt
            // 
            this.ReportBt.BackColor = System.Drawing.Color.Gainsboro;
            this.ReportBt.FlatAppearance.BorderSize = 0;
            this.ReportBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBt.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.ReportBt.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.ReportBt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.ReportBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReportBt.IconSize = 32;
            this.ReportBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportBt.Location = new System.Drawing.Point(607, 328);
            this.ReportBt.Name = "ReportBt";
            this.ReportBt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ReportBt.Size = new System.Drawing.Size(149, 36);
            this.ReportBt.TabIndex = 20;
            this.ReportBt.Text = "Report";
            this.ReportBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReportBt.UseMnemonic = false;
            this.ReportBt.UseVisualStyleBackColor = false;
            this.ReportBt.Click += new System.EventHandler(this.ReportBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(517, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Manage Student Results here***";
            // 
            // StudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(768, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportBt);
            this.Controls.Add(this.EvaluateBt);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.CbRbrcsScore);
            this.Controls.Add(this.CbRbrcs);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.CbAssComp);
            this.Controls.Add(this.CbAss);
            this.Controls.Add(this.CbStd);
            this.Name = "StudentResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentResult";
            this.Load += new System.EventHandler(this.StudentResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbStd;
        private System.Windows.Forms.ComboBox CbAss;
        private System.Windows.Forms.ComboBox CbAssComp;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.ComboBox CbRbrcs;
        private System.Windows.Forms.ComboBox CbRbrcsScore;
        private FontAwesome.Sharp.IconButton Students;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton EvaluateBt;
        private FontAwesome.Sharp.IconButton ReportBt;
        private System.Windows.Forms.Label label1;
    }
}