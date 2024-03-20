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
            this.label1 = new System.Windows.Forms.Label();
            this.InputDetails = new System.Windows.Forms.TextBox();
            this.CbRbrcs = new System.Windows.Forms.ComboBox();
            this.CbRbrcLvl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RubricId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.RbrcLvlGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RbrcLvlGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rubric Level";
            // 
            // InputDetails
            // 
            this.InputDetails.Location = new System.Drawing.Point(50, 212);
            this.InputDetails.Name = "InputDetails";
            this.InputDetails.Size = new System.Drawing.Size(135, 22);
            this.InputDetails.TabIndex = 1;
            // 
            // CbRbrcs
            // 
            this.CbRbrcs.FormattingEnabled = true;
            this.CbRbrcs.Location = new System.Drawing.Point(50, 131);
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
            this.CbRbrcLvl.Location = new System.Drawing.Point(50, 297);
            this.CbRbrcLvl.Name = "CbRbrcLvl";
            this.CbRbrcLvl.Size = new System.Drawing.Size(135, 24);
            this.CbRbrcLvl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Details";
            // 
            // RubricId
            // 
            this.RubricId.AutoSize = true;
            this.RubricId.Location = new System.Drawing.Point(52, 86);
            this.RubricId.Name = "RubricId";
            this.RubricId.Size = new System.Drawing.Size(57, 16);
            this.RubricId.TabIndex = 5;
            this.RubricId.Text = "RubricId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rubric Level";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(369, 340);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // RbrcLvlGrid
            // 
            this.RbrcLvlGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RbrcLvlGrid.Location = new System.Drawing.Point(303, 100);
            this.RbrcLvlGrid.Name = "RbrcLvlGrid";
            this.RbrcLvlGrid.RowHeadersWidth = 51;
            this.RbrcLvlGrid.RowTemplate.Height = 24;
            this.RbrcLvlGrid.Size = new System.Drawing.Size(417, 221);
            this.RbrcLvlGrid.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(574, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Rubric_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RbrcLvlGrid);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RubricId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbRbrcLvl);
            this.Controls.Add(this.CbRbrcs);
            this.Controls.Add(this.InputDetails);
            this.Controls.Add(this.label1);
            this.Name = "Rubric_Level";
            this.Text = "Rubric_Level";
            ((System.ComponentModel.ISupportInitialize)(this.RbrcLvlGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputDetails;
        private System.Windows.Forms.ComboBox CbRbrcs;
        private System.Windows.Forms.ComboBox CbRbrcLvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RubricId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView RbrcLvlGrid;
        private System.Windows.Forms.Button button3;
    }
}