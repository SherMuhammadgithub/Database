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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
    
        private void LoadStudent()
        {
            string Query = "Select * from Student";
            DataTable dt = Connection.GetData(Query);
            StdGrid.DataSource = dt;
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
        catch (Exception err)
        {
            MessageBox.Show(err.Message);
        }
    }



        int StdId = 0;

        private void StdGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            StdId = Convert.ToInt32(StdGrid.Rows[e.RowIndex].Cells[0].Value);
            IpFirstName.Text = StdGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            IpLastName.Text = StdGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            IpContact.Text = StdGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            IpEmail.Text = StdGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            IpRegNo.Text = StdGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            CbStatus.SelectedValue = StdGrid.Rows[e.RowIndex].Cells[6].Value;
        }
        private bool ValidateEmail(string email)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Match match = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                //provide format is correct
                errorLName.SetError(IpEmail, "");
                return true;
            }
            else
            {
                //show correct format
                errorLName.SetError(IpEmail, "xzy@gmail.com");
                return false;
            }
        }
        private bool ValidateContact(string contact)
        {
            string pattern = @"^([0-9]{11})$";
            Match match = Regex.Match(contact, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                //provide format is correct
                errorLName.SetError(IpContact, "");
                return true;
            }
            else
            {
                //show correct format
                errorLName.SetError(IpContact, "03001234567");
                return false;
            }
        }
        private bool ValidateRegNo(string regno)
        {
            string pattern = @"^\d{4}-\w{2}-\d{2}$";
            Match match = Regex.Match(regno, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                //provide format is correct
                errorLName.SetError(IpRegNo, "");
                return true;
            }
            else
            {
                //show correct format
                errorLName.SetError(IpRegNo, "2023-CS-15");
                return false;
            }
        }

 

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // empty value check will be added in future
                if (!ValidateEmail(IpEmail.Text))
                {
                    return;
                }
                if (!ValidateContact(IpContact.Text))
                {
                    return;
                }
                if (!ValidateRegNo(IpRegNo.Text))
                {
                    return;
                }

                string Name = IpFirstName.Text;
                string LastName = IpLastName.Text;
                string Contact = IpContact.Text;
                string Email = IpEmail.Text;

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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
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
        catch (Exception err)
        {
            MessageBox.Show(err.Message);
        }
        }
    }
}
