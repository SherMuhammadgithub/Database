namespace DatabaseProject
{
    partial class CLO
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
            this.InputClo = new System.Windows.Forms.TextBox();
            this.CloDataGrid = new System.Windows.Forms.DataGridView();
            this.AddClo = new System.Windows.Forms.Button();
            this.DeleteClo = new System.Windows.Forms.Button();
            this.UpdateClo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CloDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // InputClo
            // 
            this.InputClo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputClo.Location = new System.Drawing.Point(91, 94);
            this.InputClo.Name = "InputClo";
            this.InputClo.Size = new System.Drawing.Size(100, 22);
            this.InputClo.TabIndex = 1;
            // 
            // CloDataGrid
            // 
            this.CloDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CloDataGrid.Location = new System.Drawing.Point(323, 78);
            this.CloDataGrid.Name = "CloDataGrid";
            this.CloDataGrid.RowHeadersWidth = 51;
            this.CloDataGrid.RowTemplate.Height = 24;
            this.CloDataGrid.Size = new System.Drawing.Size(379, 198);
            this.CloDataGrid.TabIndex = 2;
            this.CloDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CloDataGrid_CellContentClick);
            // 
            // AddClo
            // 
            this.AddClo.Location = new System.Drawing.Point(57, 156);
            this.AddClo.Name = "AddClo";
            this.AddClo.Size = new System.Drawing.Size(75, 23);
            this.AddClo.TabIndex = 3;
            this.AddClo.Text = "Add";
            this.AddClo.UseVisualStyleBackColor = true;
            this.AddClo.Click += new System.EventHandler(this.AddClo_Click);
            // 
            // DeleteClo
            // 
            this.DeleteClo.Location = new System.Drawing.Point(107, 194);
            this.DeleteClo.Name = "DeleteClo";
            this.DeleteClo.Size = new System.Drawing.Size(75, 23);
            this.DeleteClo.TabIndex = 4;
            this.DeleteClo.Text = "Delete";
            this.DeleteClo.UseVisualStyleBackColor = true;
            this.DeleteClo.Click += new System.EventHandler(this.DeleteClo_Click);
            // 
            // UpdateClo
            // 
            this.UpdateClo.Location = new System.Drawing.Point(174, 156);
            this.UpdateClo.Name = "UpdateClo";
            this.UpdateClo.Size = new System.Drawing.Size(75, 23);
            this.UpdateClo.TabIndex = 5;
            this.UpdateClo.Text = "Update";
            this.UpdateClo.UseVisualStyleBackColor = true;
            this.UpdateClo.Click += new System.EventHandler(this.UpdateClo_Click);
            // 
            // CLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateClo);
            this.Controls.Add(this.DeleteClo);
            this.Controls.Add(this.AddClo);
            this.Controls.Add(this.CloDataGrid);
            this.Controls.Add(this.InputClo);
            this.Controls.Add(this.label1);
            this.Name = "CLO";
            this.Text = "CLO";
            ((System.ComponentModel.ISupportInitialize)(this.CloDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputClo;
        private System.Windows.Forms.DataGridView CloDataGrid;
        private System.Windows.Forms.Button AddClo;
        private System.Windows.Forms.Button DeleteClo;
        private System.Windows.Forms.Button UpdateClo;
    }
}