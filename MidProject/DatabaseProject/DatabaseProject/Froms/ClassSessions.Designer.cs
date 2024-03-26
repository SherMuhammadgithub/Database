namespace DatabaseProject
{
    partial class ClassSessions
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
            this.DatePick = new System.Windows.Forms.DateTimePicker();
            this.Students = new FontAwesome.Sharp.IconButton();
            this.AddBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DatePick
            // 
            this.DatePick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatePick.Location = new System.Drawing.Point(99, 122);
            this.DatePick.Name = "DatePick";
            this.DatePick.Size = new System.Drawing.Size(200, 22);
            this.DatePick.TabIndex = 0;
            // 
            // Students
            // 
            this.Students.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Students.BackColor = System.Drawing.Color.White;
            this.Students.FlatAppearance.BorderSize = 0;
            this.Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Students.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.Students.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.Students.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.Students.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Students.IconSize = 32;
            this.Students.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Students.Location = new System.Drawing.Point(85, 69);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Students.Size = new System.Drawing.Size(234, 47);
            this.Students.TabIndex = 16;
            this.Students.Text = "Class Sessions";
            this.Students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Students.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Students.UseVisualStyleBackColor = false;
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.AddBtn.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.AddBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.AddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBtn.IconSize = 32;
            this.AddBtn.Location = new System.Drawing.Point(126, 170);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AddBtn.Size = new System.Drawing.Size(120, 36);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.UseMnemonic = false;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = " Manage Class Sessions here***";
            // 
            // ClassSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.DatePick);
            this.Name = "ClassSessions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePick;
        private FontAwesome.Sharp.IconButton Students;
        private FontAwesome.Sharp.IconButton AddBtn;
        private System.Windows.Forms.Label label1;
    }
}