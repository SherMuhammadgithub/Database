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
    public partial class Assessment : Form
    {
        Functions Connection;
        public Assessment()
        {
            InitializeComponent();
            Connection = new Functions();
            Assessment_Load();
        }
        private void Assessment_Load()
        {
            string Query = "SELECT * FROM Assessment";
            DataTable dt = Connection.GetData(Query);
            AssessmentDataGrid.DataSource = dt;
        }

        private void AddAssmnt_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputAssTitle.Text == "" || InputAssTMarks.Text == "" || InputAssTWeightage.Text == "")
                {
                    MessageBox.Show("Please enter all the fields");
                }
                else
                {
                    if (!ValidateMarks())
                    {
                        return;
                    }
                    if (!ValidateWeightage())
                    {
                        return;
                    }
                    string Query = "INSERT INTO Assessment(Title, DateCreated, TotalMarks, TotalWeightage) VALUES('" + InputAssTitle.Text + "', '" + DateTime.Now + "', '" + InputAssTMarks.Text + "', '" + InputAssTWeightage.Text + "')";
                    int i = Connection.SetData(Query);
                    if (i == 1) // means 1 row is affected
                    {
                        Assessment_Load();
                        MessageBox.Show("Assessment Added Successfully");
                        InputAssTitle.Text = "";
                        InputAssTMarks.Text = "";
                        InputAssTWeightage.Text = "";
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        int AssmtId;
        private void AssessmentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AssmtId = Convert.ToInt32(AssessmentDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            InputAssTitle.Text = AssessmentDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            InputAssTMarks.Text = AssessmentDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            InputAssTWeightage.Text = AssessmentDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(InputAssTitle.Text == "" || InputAssTitle.Text == "" || InputAssTMarks.Text == "")
                {
                   MessageBox.Show("Please enter all the fields");
                }
                else
                {
                    string Query = "DELETE FROM Assessment WHERE Id = '" + AssmtId + "'";
                    int i = Connection.SetData(Query);
                    if(i == 1) // means 1 row is affected
                    { 
                        Assessment_Load();
                        MessageBox.Show("Assessment Deleted Successfully");
                        InputAssTitle.Text = "";
                        InputAssTMarks.Text = "";
                        InputAssTWeightage.Text = "";
                    }
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
                if (InputAssTitle.Text == "" || InputAssTitle.Text == "" || InputAssTMarks.Text == "")
                {
                    MessageBox.Show("Please enter all the fields");
                }
                else
                {
                    string Query = "UPDATE Assessment SET Title = '" + InputAssTitle.Text + "', DateCreated = '" + DateTime.Now + "', TotalMarks = '" + InputAssTMarks.Text + "', TotalWeightage = '" + InputAssTWeightage.Text + "' WHERE Id = '" + AssmtId + "'";
                    int i = Connection.SetData(Query);
                    if (i == 1) // means 1 row is affected
                    {
                        Assessment_Load();
                        MessageBox.Show("Assessment Updated Successfully");
                        InputAssTitle.Text = "";
                        InputAssTMarks.Text = "";
                        InputAssTWeightage.Text = "";
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }   
        }
        private bool ValidateMarks()
        {
            Regex regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(InputAssTMarks.Text))
            {
                errorProvider.SetError(InputAssTMarks, null);
                return true;
            }
            else
            {
               errorProvider.SetError(InputAssTMarks, "Please enter valid marks");
                return false;
            }
        }
        private bool ValidateWeightage()
        {
            Regex regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(InputAssTWeightage.Text))
            {
                errorProvider.SetError(InputAssTWeightage, null);
                return true;
            }
            else
            {
                errorProvider.SetError(InputAssTWeightage, "Please enter valid weightage");
                return false;
            }
        }

        private void Assessment_Load(object sender, EventArgs e)
        {

        }

        private void GoToComp_Click(object sender, EventArgs e)
        {
            // show the component form
            AssessmentComp comp = new AssessmentComp();
            comp.Show();
        }
    }
}
