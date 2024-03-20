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
            this.AddDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatePick
            // 
            this.DatePick.Location = new System.Drawing.Point(12, 134);
            this.DatePick.Name = "DatePick";
            this.DatePick.Size = new System.Drawing.Size(200, 22);
            this.DatePick.TabIndex = 0;
            // 
            // AddDate
            // 
            this.AddDate.Location = new System.Drawing.Point(12, 195);
            this.AddDate.Name = "AddDate";
            this.AddDate.Size = new System.Drawing.Size(75, 23);
            this.AddDate.TabIndex = 1;
            this.AddDate.Text = "Add";
            this.AddDate.UseVisualStyleBackColor = true;
            this.AddDate.Click += new System.EventHandler(this.AddDate_Click);
            // 
            // ClassSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddDate);
            this.Controls.Add(this.DatePick);
            this.Name = "ClassSessions";
            this.Text = "ClassSessions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePick;
        private System.Windows.Forms.Button AddDate;
    }
}