using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Student : Form
    {
        Functions Connection;
        public Student()
        {
            InitializeComponent();
            Connection = new Functions();
            LoadStatus();
            LoadStudent();
        }
        private void LoadStatus()
        {
            String Query = "Select * from Lookup Where Category = 'STUDENT_STATUS'";
            DataTable dt = Connection.GetData(Query);
            CbStatus.DisplayMember = "Name";
            CbStatus.ValueMember = "LookupId";
            CbStatus.DataSource = dt;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                // empty value check will be added in future
                
                string Name = IpFirstName.Text;
                string LastName = IpLastName.Text;
                string Contact = IpContact.Text;
                string Email = IpEmail.Text;
                string emailPattern = @"\w+@\w+\.\w+";
                if (!Regex.IsMatch(Email, emailPattern))
                {
                    MessageBox.Show("Invalid email format. Please enter a valid email address.");
                    return; // Exit the method if email is invalid
                }
                string RegNo = IpRegNo.Text;
                int Status = Convert.ToInt32(CbStatus.SelectedValue);

               
                string Query = "INSERT INTO Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status) VALUES('{0}','{1}','{2}','{3}','{4}',{5})";
                Query = string.Format(Query, Name, LastName, Contact, Email, RegNo, Status);
                int Rows = Connection.SetData(Query);
                if (Rows > 0)
                {
                    MessageBox.Show("Student Added Successfully");
                    LoadStudent();
                    IpContact.Text = "";
                    IpEmail.Text = "";
                    IpFirstName.Text = "";
                    IpLastName.Text = "";
                    IpRegNo.Text = "";
                    CbStatus.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Error Occured");
                }

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void LoadStudent()
        {
            string Query = "Select * from Student";
            DataTable dt = Connection.GetData(Query);
            StdGrid.DataSource = dt;
        }

        int StdId = 0;
        private void StdGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdId = Convert.ToInt32(StdGrid.Rows[e.RowIndex].Cells[0].Value);
            IpFirstName.Text = StdGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            IpLastName.Text = StdGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            IpContact.Text = StdGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            IpEmail.Text = StdGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            IpRegNo.Text = StdGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            CbStatus.SelectedValue = StdGrid.Rows[e.RowIndex].Cells[6].Value;

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "Delete from Student where Id = {0}";
                Query = string.Format(Query, StdId);
                int Rows = Connection.SetData(Query);
                if (Rows > 0)
                {
                    MessageBox.Show("Student Deleted Successfully");
                    LoadStudent();
                    IpContact.Text = "";
                    IpEmail.Text = "";
                    IpFirstName.Text = "";
                    IpLastName.Text = "";
                    IpRegNo.Text = "";
                    CbStatus.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }
            catch(Exception err)
            {
                 MessageBox.Show(err.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "Update Student set FirstName = '{0}', LastName = '{1}', Contact = '{2}', Email = '{3}', RegistrationNumber = '{4}', Status = {5} where Id = {6}";
                Query = string.Format(Query, IpFirstName.Text, IpLastName.Text, IpContact.Text, IpEmail.Text, IpRegNo.Text, CbStatus.SelectedValue, StdId);
                int Rows = Connection.SetData(Query);
                if (Rows > 0)
                {
                    MessageBox.Show("Student Updated Successfully");
                    LoadStudent();
                    IpContact.Text = "";
                    IpEmail.Text = "";
                    IpFirstName.Text = "";
                    IpLastName.Text = "";
                    IpRegNo.Text = "";
                    CbStatus.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
