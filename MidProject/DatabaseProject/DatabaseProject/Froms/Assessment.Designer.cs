namespace DatabaseProject
{
    partial class Assessment
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputAssTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InputAssTMarks = new System.Windows.Forms.TextBox();
            this.InputAssTWeightage = new System.Windows.Forms.TextBox();
            this.AssessmentDataGrid = new System.Windows.Forms.DataGridView();
            this.AddAssmnt = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GoToComp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Assesments here***";
            // 
            // InputAssTitle
            // 
            this.InputAssTitle.Location = new System.Drawing.Point(146, 286);
            this.InputAssTitle.Name = "InputAssTitle";
            this.InputAssTitle.Size = new System.Drawing.Size(139, 22);
            this.InputAssTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Weightage";
            // 
            // InputAssTMarks
            // 
            this.InputAssTMarks.Location = new System.Drawing.Point(156, 339);
            this.InputAssTMarks.Name = "InputAssTMarks";
            this.InputAssTMarks.Size = new System.Drawing.Size(129, 22);
            this.InputAssTMarks.TabIndex = 5;
            // 
            // InputAssTWeightage
            // 
            this.InputAssTWeightage.Location = new System.Drawing.Point(194, 384);
            this.InputAssTWeightage.Name = "InputAssTWeightage";
            this.InputAssTWeightage.Size = new System.Drawing.Size(91, 22);
            this.InputAssTWeightage.TabIndex = 6;
            // 
            // AssessmentDataGrid
            // 
            this.AssessmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssessmentDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssessmentDataGrid.Location = new System.Drawing.Point(0, 0);
            this.AssessmentDataGrid.Name = "AssessmentDataGrid";
            this.AssessmentDataGrid.RowHeadersWidth = 51;
            this.AssessmentDataGrid.RowTemplate.Height = 24;
            this.AssessmentDataGrid.Size = new System.Drawing.Size(760, 218);
            this.AssessmentDataGrid.TabIndex = 7;
            this.AssessmentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssessmentDataGrid_CellContentClick);
            // 
            // AddAssmnt
            // 
            this.AddAssmnt.Location = new System.Drawing.Point(50, 439);
            this.AddAssmnt.Name = "AddAssmnt";
            this.AddAssmnt.Size = new System.Drawing.Size(210, 33);
            this.AddAssmnt.TabIndex = 8;
            this.AddAssmnt.Text = "Add";
            this.AddAssmnt.UseVisualStyleBackColor = true;
            this.AddAssmnt.Click += new System.EventHandler(this.AddAssmnt_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(666, 233);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(81, 33);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(565, 233);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(84, 33);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // GoToComp
            // 
            this.GoToComp.Location = new System.Drawing.Point(565, 504);
            this.GoToComp.Name = "GoToComp";
            this.GoToComp.Size = new System.Drawing.Size(164, 36);
            this.GoToComp.TabIndex = 11;
            this.GoToComp.Text = "Manage Components ";
            this.GoToComp.UseVisualStyleBackColor = true;
            this.GoToComp.Click += new System.EventHandler(this.GoToComp_Click);
            // 
            // Assessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 585);
            this.Controls.Add(this.GoToComp);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.AddAssmnt);
            this.Controls.Add(this.AssessmentDataGrid);
            this.Controls.Add(this.InputAssTWeightage);
            this.Controls.Add(this.InputAssTMarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputAssTitle);
            this.Controls.Add(this.label1);
            this.Name = "Assessment";
            this.Text = "Assessment";
            this.Load += new System.EventHandler(this.Assessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputAssTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputAssTMarks;
        private System.Windows.Forms.TextBox InputAssTWeightage;
        private System.Windows.Forms.DataGridView AssessmentDataGrid;
        private System.Windows.Forms.Button AddAssmnt;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button GoToComp;
    }
}