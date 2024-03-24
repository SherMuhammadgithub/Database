namespace DatabaseProject
{
    partial class AssessmentComp
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
            this.InputTMarks = new System.Windows.Forms.TextBox();
            this.InputName = new System.Windows.Forms.TextBox();
            this.CbRbrcs = new System.Windows.Forms.ComboBox();
            this.CbAssmnt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.AssmntCompGrid = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AssmntCompGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Assessment Comp";
            // 
            // InputTMarks
            // 
            this.InputTMarks.Location = new System.Drawing.Point(24, 262);
            this.InputTMarks.Name = "InputTMarks";
            this.InputTMarks.Size = new System.Drawing.Size(157, 22);
            this.InputTMarks.TabIndex = 15;
            // 
            // InputName
            // 
            this.InputName.Location = new System.Drawing.Point(24, 109);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(157, 22);
            this.InputName.TabIndex = 17;
            // 
            // CbRbrcs
            // 
            this.CbRbrcs.FormattingEnabled = true;
            this.CbRbrcs.Location = new System.Drawing.Point(24, 180);
            this.CbRbrcs.Name = "CbRbrcs";
            this.CbRbrcs.Size = new System.Drawing.Size(157, 24);
            this.CbRbrcs.TabIndex = 18;
            // 
            // CbAssmnt
            // 
            this.CbAssmnt.FormattingEnabled = true;
            this.CbAssmnt.Location = new System.Drawing.Point(24, 332);
            this.CbAssmnt.Name = "CbAssmnt";
            this.CbAssmnt.Size = new System.Drawing.Size(157, 24);
            this.CbAssmnt.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rubric id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total  Marks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Assessment";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(307, 384);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(102, 23);
            this.Add.TabIndex = 24;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AssmntCompGrid
            // 
            this.AssmntCompGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssmntCompGrid.Location = new System.Drawing.Point(234, 116);
            this.AssmntCompGrid.Name = "AssmntCompGrid";
            this.AssmntCompGrid.RowHeadersWidth = 51;
            this.AssmntCompGrid.RowTemplate.Height = 24;
            this.AssmntCompGrid.Size = new System.Drawing.Size(492, 240);
            this.AssmntCompGrid.TabIndex = 25;
            this.AssmntCompGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssmntCompGrid_CellContentClick);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(563, 384);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(102, 23);
            this.delete.TabIndex = 26;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AssessmentComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.AssmntCompGrid);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbAssmnt);
            this.Controls.Add(this.CbRbrcs);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.InputTMarks);
            this.Controls.Add(this.label1);
            this.Name = "AssessmentComp";
            this.Text = "AssessmentComp";
            ((System.ComponentModel.ISupportInitialize)(this.AssmntCompGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTMarks;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.ComboBox CbRbrcs;
        private System.Windows.Forms.ComboBox CbAssmnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView AssmntCompGrid;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}