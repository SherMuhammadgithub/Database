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
            this.label1 = new System.Windows.Forms.Label();
            this.InputRubDetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddRubrc = new System.Windows.Forms.Button();
            this.CLOsCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RbrcDataGrid = new System.Windows.Forms.DataGridView();
            this.InputRbrcId = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RbrcDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Rubrics";
            // 
            // InputRubDetail
            // 
            this.InputRubDetail.Location = new System.Drawing.Point(47, 233);
            this.InputRubDetail.Multiline = true;
            this.InputRubDetail.Name = "InputRubDetail";
            this.InputRubDetail.Size = new System.Drawing.Size(157, 79);
            this.InputRubDetail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rubric Details";
            // 
            // AddRubrc
            // 
            this.AddRubrc.Location = new System.Drawing.Point(51, 351);
            this.AddRubrc.Name = "AddRubrc";
            this.AddRubrc.Size = new System.Drawing.Size(153, 30);
            this.AddRubrc.TabIndex = 9;
            this.AddRubrc.Text = "Add";
            this.AddRubrc.UseVisualStyleBackColor = true;
            this.AddRubrc.Click += new System.EventHandler(this.AddRubrc_Click);
            // 
            // CLOsCb
            // 
            this.CLOsCb.FormattingEnabled = true;
            this.CLOsCb.Location = new System.Drawing.Point(47, 145);
            this.CLOsCb.Name = "CLOsCb";
            this.CLOsCb.Size = new System.Drawing.Size(157, 24);
            this.CLOsCb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select CLO";
            // 
            // RbrcDataGrid
            // 
            this.RbrcDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RbrcDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RbrcDataGrid.Location = new System.Drawing.Point(232, 125);
            this.RbrcDataGrid.Name = "RbrcDataGrid";
            this.RbrcDataGrid.RowHeadersWidth = 51;
            this.RbrcDataGrid.RowTemplate.Height = 24;
            this.RbrcDataGrid.Size = new System.Drawing.Size(445, 200);
            this.RbrcDataGrid.TabIndex = 12;
            this.RbrcDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RbrcDataGrid_CellContentClick);
            // 
            // InputRbrcId
            // 
            this.InputRbrcId.Location = new System.Drawing.Point(47, 77);
            this.InputRbrcId.Name = "InputRbrcId";
            this.InputRbrcId.Size = new System.Drawing.Size(157, 22);
            this.InputRbrcId.TabIndex = 13;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(575, 366);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(93, 30);
            this.Update.TabIndex = 14;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(457, 366);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(93, 30);
            this.delete.TabIndex = 15;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Rubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.InputRbrcId);
            this.Controls.Add(this.RbrcDataGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CLOsCb);
            this.Controls.Add(this.AddRubrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputRubDetail);
            this.Controls.Add(this.label1);
            this.Name = "Rubric";
            this.Text = "Rubric";
            ((System.ComponentModel.ISupportInitialize)(this.RbrcDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputRubDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddRubrc;
        private System.Windows.Forms.ComboBox CLOsCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView RbrcDataGrid;
        private System.Windows.Forms.TextBox InputRbrcId;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button delete;
    }
}