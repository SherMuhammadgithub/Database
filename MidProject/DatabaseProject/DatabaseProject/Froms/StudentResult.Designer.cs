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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbStd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbAss = new System.Windows.Forms.ComboBox();
            this.CbAssComp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Evaluate = new FontAwesome.Sharp.IconButton();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.CbRbrcs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbRbrcsScore = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Evaluation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student";
            // 
            // CbStd
            // 
            this.CbStd.FormattingEnabled = true;
            this.CbStd.Location = new System.Drawing.Point(155, 83);
            this.CbStd.Name = "CbStd";
            this.CbStd.Size = new System.Drawing.Size(121, 24);
            this.CbStd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Assessement";
            // 
            // CbAss
            // 
            this.CbAss.FormattingEnabled = true;
            this.CbAss.Location = new System.Drawing.Point(472, 86);
            this.CbAss.Name = "CbAss";
            this.CbAss.Size = new System.Drawing.Size(121, 24);
            this.CbAss.TabIndex = 4;
            this.CbAss.SelectedIndexChanged += new System.EventHandler(this.CbAss_SelectedIndexChanged);
            // 
            // CbAssComp
            // 
            this.CbAssComp.FormattingEnabled = true;
            this.CbAssComp.Location = new System.Drawing.Point(68, 188);
            this.CbAssComp.Name = "CbAssComp";
            this.CbAssComp.Size = new System.Drawing.Size(121, 24);
            this.CbAssComp.TabIndex = 5;
            this.CbAssComp.SelectedIndexChanged += new System.EventHandler(this.CbAssComp_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Assessement Component";
            // 
            // Evaluate
            // 
            this.Evaluate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Evaluate.IconColor = System.Drawing.Color.Black;
            this.Evaluate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Evaluate.Location = new System.Drawing.Point(675, 381);
            this.Evaluate.Name = "Evaluate";
            this.Evaluate.Size = new System.Drawing.Size(75, 23);
            this.Evaluate.TabIndex = 7;
            this.Evaluate.Text = "Evaluate";
            this.Evaluate.UseVisualStyleBackColor = true;
            this.Evaluate.Click += new System.EventHandler(this.Evaluate_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(244, 136);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.RowTemplate.Height = 24;
            this.dataGridViewResults.Size = new System.Drawing.Size(520, 166);
            this.dataGridViewResults.TabIndex = 8;
            // 
            // CbRbrcs
            // 
            this.CbRbrcs.FormattingEnabled = true;
            this.CbRbrcs.Location = new System.Drawing.Point(68, 278);
            this.CbRbrcs.Name = "CbRbrcs";
            this.CbRbrcs.Size = new System.Drawing.Size(121, 24);
            this.CbRbrcs.TabIndex = 9;
            this.CbRbrcs.SelectedIndexChanged += new System.EventHandler(this.CbRbrcs_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rubric Details";
            // 
            // CbRbrcsScore
            // 
            this.CbRbrcsScore.FormattingEnabled = true;
            this.CbRbrcsScore.Location = new System.Drawing.Point(68, 371);
            this.CbRbrcsScore.Name = "CbRbrcsScore";
            this.CbRbrcsScore.Size = new System.Drawing.Size(121, 24);
            this.CbRbrcsScore.TabIndex = 11;
            this.CbRbrcsScore.SelectedIndexChanged += new System.EventHandler(this.CbRbrcsScore_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rbrics Score";
            // 
            // StudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbRbrcsScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbRbrcs);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.Evaluate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbAssComp);
            this.Controls.Add(this.CbAss);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbStd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentResult";
            this.Text = "StudentResult";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbStd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbAss;
        private System.Windows.Forms.ComboBox CbAssComp;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton Evaluate;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.ComboBox CbRbrcs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbRbrcsScore;
        private System.Windows.Forms.Label label6;
    }
}