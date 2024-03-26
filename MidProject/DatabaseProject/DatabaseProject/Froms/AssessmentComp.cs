
using System;
using System.Collections.Generic;                      
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class AssessmentComp : Form
    {
        Functions Connection;

        public AssessmentComp()
        {
            InitializeComponent();
            Connection = new Functions();
            LoadRbrcs();
            LoadAssessments();
            LoadAssessmentComp();
        }
        // Loading Rubrics
        private void LoadRbrcs()
        {
            string query = "SELECT * FROM Rubric";
            DataTable dt = Connection.GetData(query);
            CbRbrcs.DisplayMember = "Id"; 
            CbRbrcs.ValueMember = "Id"; 
            CbRbrcs.DataSource = dt;
        }
        // Loading Assessments
        private void LoadAssessments()
        {
            string query = "SELECT * FROM Assessment";
            DataTable dt = Connection.GetData(query);
            CbAssmnt.DisplayMember = "Title";
            CbAssmnt.ValueMember = "Id";
            CbAssmnt.DataSource = dt;
        }
        // Loading Assessment Components
        private void LoadAssessmentComp()
        {
            string query = "SELECT * FROM AssessmentComponent";
            DataTable dt = Connection.GetData(query);
            AssmntCompGrid.DataSource = dt;

        }
        private int GetAssessementTMarks(int assessmentId)
        {
            string query = "SELECT * FROM Assessment WHERE Id = " + assessmentId;
            DataTable dt = Connection.GetData(query);
            return Convert.ToInt32(dt.Rows[0]["TotalMarks"]);
        }
        private int GetSumOfAssCompMarks(int assessmentId)
        {
            string query = "SELECT SUM(TotalMarks) as TotalMarks FROM AssessmentComponent WHERE AssessmentId = " + assessmentId;
            DataTable dt = Connection.GetData(query);
            if (dt.Rows[0]["TotalMarks"] == DBNull.Value)
            {
                return 0;
            }
            return Convert.ToInt32(dt.Rows[0]["TotalMarks"]);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputName.Text == "" || CbAssmnt.Text == "" || CbRbrcs.Text == "" || InputTMarks.Text == "")
                {
                    MessageBox.Show("Please enter all the fields");
                }
                else
                {
                    if (!ValidateMarks())
                    {
                        return;
                    }
                    string name = InputName.Text;
                    int rubricId = Convert.ToInt32(CbRbrcs.SelectedValue);
                    int totalMarks = Convert.ToInt32(InputTMarks.Text);
                    DateTime dateCreated = DateTime.Now;
                    DateTime dateUpdated = DateTime.Now;
                    int assessmentId = Convert.ToInt32(CbAssmnt.SelectedValue);
                    int sumOfAssCompMarks = GetSumOfAssCompMarks(assessmentId); // Get Sum of Previous Assessment Component Marks
                    totalMarks += sumOfAssCompMarks;
                    int assTMarks = GetAssessementTMarks(assessmentId); // Get Total Marks of Assessment
                    if(totalMarks > assTMarks)
                    {
                        MessageBox.Show($"Component Marks can't be greater than Assessement Marks {assTMarks}");
                        return;
                    }
                    string query = "INSERT INTO AssessmentComponent(Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId)" +
                        " VALUES ('{0}', {1}, {2}, '{3}', '{4}', {5})";
                    query = string.Format(query, name, rubricId, totalMarks, dateCreated, dateUpdated, assessmentId);
                    int i = Connection.SetData(query);
                            if (i ==  1)
                            {
                                MessageBox.Show("Assessment Component Added Successfully");
                                LoadAssessmentComp();
                                InputName.Text = "";
                                CbAssmnt.Text = "";
                                CbRbrcs.Text = "";
                                InputTMarks.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Failed to add assessment component.");
                            }
                    }
                }
            
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private bool ValidateMarks()
        {
            Regex regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(InputTMarks.Text))
            {
                errorProvider.SetError(InputTMarks, null);
                return true;
            }
            else
            {
                errorProvider.SetError(InputTMarks, "Please enter valid marks");
                return false;
            }
        }
        int AssComKey = 0; 
        private void AssmntCompGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AssComKey = Convert.ToInt32(AssmntCompGrid.Rows[e.RowIndex].Cells[0].Value);
            InputName.Text = AssmntCompGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            CbRbrcs.SelectedValue = AssmntCompGrid.Rows[e.RowIndex].Cells[2].Value;
            InputTMarks.Text = AssmntCompGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            CbAssmnt.SelectedValue = AssmntCompGrid.Rows[e.RowIndex].Cells[6].Value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               if(AssComKey == 0)
                {
                    MessageBox.Show("Please select a record to Update");
                    return;
                }
               string Query  = "UPDATE AssessmentComponent SET Name = '{0}', RubricId = {1}, TotalMarks = {2}, DateUpdated = '{3}', AssessmentId = {4} WHERE Id = {5}";
                Query = string.Format(Query, InputName.Text, CbRbrcs.SelectedValue, InputTMarks.Text, DateTime.Now, CbAssmnt.SelectedValue, AssComKey);
                int i = Connection.SetData(Query);
                if (i == 1) // means 1 row is affected
                {
                    MessageBox.Show("Assessment Component Updated Successfully");
                    LoadAssessmentComp();
                    InputName.Text = "";
                    CbRbrcs.Text = "";
                    InputTMarks.Text = "";
                    CbAssmnt.Text = "";
                }
             
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (AssComKey == 0)
                {
                       MessageBox.Show("Please select a record to delete");
                    return;
                
                }
                string Query = "DELETE FROM AssessmentComponent WHERE Id = {0}";
                Query = string.Format(Query, AssComKey);
                int i = Connection.SetData(Query);
                if (i == 1) // means 1 row is affected
                {
                    MessageBox.Show("Assessment Component Deleted Successfully");
                    LoadAssessmentComp();
                    InputName.Text = "";
                    CbRbrcs.Text = "";
                    InputTMarks.Text = "";
                    CbAssmnt.Text = "";

                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}