using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class StudentResult : Form
    {
        private Functions Connection;
       
       private double totalMarks= 0; // Total marks of the assessment component

        public StudentResult()
        {
            InitializeComponent();
            Connection = new Functions();
            LoadStudents();
            LoadAssessemnts();
            // Create the columns for the datagridview
            dataGridViewResults.Columns.Add("Student", "Student");
            dataGridViewResults.Columns["Student"].Width = 200;
            dataGridViewResults.Columns.Add("Component", "Component");
            dataGridViewResults.Columns["Component"].Width = 200;
            dataGridViewResults.Columns.Add("Total Marks", "Total Marks");
            dataGridViewResults.Columns["Total Marks"].Width = 100;
            dataGridViewResults.Columns.Add("Obtained Rubric Level", "Obtained Rubric Level");
            dataGridViewResults.Columns["Obtained Rubric Level"].Width = 150;
            dataGridViewResults.Columns.Add("Obtained Marks", "Obtained Marks");
            dataGridViewResults.Columns["Obtained Marks"].Width = 150;
            LoadStudentResult();
        }
        private void LoadStudents()
        {
            string Query = "Select * from Student";
            DataTable dt = Connection.GetData(Query);
            CbStd.DisplayMember = "RegistrationNumber";
            CbStd.ValueMember = "Id";
            CbStd.DataSource = dt;
        }
        private void LoadAssessemnts()
        {
            string Query = "Select * from Assessment";
            DataTable dt = Connection.GetData(Query);
            CbAss.DisplayMember = "Title";
            CbAss.ValueMember = "Id";
            CbAss.DataSource = dt;
        }
        public void LoadAssessmentComponents()
        {
           
           string Query = "Select * from AssessmentComponent where AssessmentId = " + CbAss.SelectedValue;
           DataTable dt = Connection.GetData(Query);
           CbAssComp.DisplayMember = "Name";
           CbAssComp.ValueMember = "Id";
           CbAssComp.DataSource = dt;
            
        }
        public void LoadRubrics()
        {
            string Query = "Select * from Rubric where Id = {0}";
            Query = String.Format(Query, GetRubricId());
            DataTable dt = Connection.GetData(Query);
            CbRbrcs.DisplayMember = "Details";
            CbRbrcs.ValueMember = "Id";
            CbRbrcs.DataSource = dt;
        }
        public void LoadRubricLevels()
        {
            string Query = "Select * from RubricLevel where RubricId = " + CbRbrcs.SelectedValue;
            DataTable dt = Connection.GetData(Query);
            CbRbrcsScore.DisplayMember = "MeasurementLevel";
            CbRbrcsScore.ValueMember = "Id";
            CbRbrcsScore.DataSource = dt;
        }
        public int GetRubricId()
        {
            string Query = "Select RubricId from AssessmentComponent where Id = " + CbAssComp.SelectedValue;
            DataTable dt = Connection.GetData(Query);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
       
        public double GetHighestRubricLevel(int rbrcId)
        {
            string Query = "Select MAX(MeasurementLevel) from RubricLevel where RubricId = " + rbrcId;
            DataTable dt = Connection.GetData(Query);
            if (dt.Rows[0][0] == DBNull.Value)
            {
                return 0;
            }
            return Convert.ToDouble(dt.Rows[0][0]);
            
        }
     
        public double GetAssComTMarks(int assComId)
        {
            string Query = "Select * from AssessmentComponent where Id = " + assComId;
            DataTable dt = Connection.GetData(Query);
            return  Convert.ToDouble(dt.Rows[0]["TotalMarks"]);
        }
        public double CalculateMarks(double stdRubricLevel, int assComId,int rbrcId)
        {
            
            totalMarks = GetAssComTMarks(assComId);
            double HighestRubrcLevel = DefiningScores(GetHighestRubricLevel(rbrcId));
            double obtainedRbrcLevel = DefiningScores(stdRubricLevel);
            return totalMarks * obtainedRbrcLevel / HighestRubrcLevel;
        }
        public double DefiningScores(double measurementLevel)
        {
            double score = 0;
            if(measurementLevel == 4)
            {
                score = totalMarks;
            }
            else if(measurementLevel == 3)
            {
                score = totalMarks * 0.75;
            }
            else if(measurementLevel == 2)
            {
                score = totalMarks * 0.5;
            }
            else if(measurementLevel == 1)
            {
                score = totalMarks * 0.25;
            }
            return score;
        }
        public string GetStudentName(int id)
        {
            string Query = "Select FirstName from Student where Id = " + id;
            DataTable dt = Connection.GetData(Query);
            return dt.Rows[0][0].ToString();
        }
        public double GetRubricLevel(int id)
        {
            string Query = "Select MeasurementLevel from RubricLevel where Id = " + id;
            DataTable dt = Connection.GetData(Query);
            return Convert.ToDouble(dt.Rows[0][0]);
        }
        public bool IsEvaluated()
        {
            int stdId = Convert.ToInt32(CbStd.SelectedValue);
            int assComId = Convert.ToInt32(CbAssComp.SelectedValue);
            string Query = "Select * from StudentResult where StudentId = {0} and AssessmentComponentId = {1}";
            Query = String.Format(Query, stdId, assComId);
            DataTable dt = Connection.GetData(Query);
            if (dt.Rows.Count == 0) // if no row is returned then student is not evaluated
            {
                return false;
            }
            else
            {
                return true;
            }
        }
      
        public int GetRubricId(int id)
        {
            string Query = "Select RubricId from RubricLevel where Id = " + id;
            DataTable dt = Connection.GetData(Query);
            return Convert.ToInt32(dt.Rows[0][0]); // return the rubric id
        }
        public void LoadStudentResult()
        {
            string Query = "Select * from StudentResult";
            DataTable dt = Connection.GetData(Query);
            if (dt.Rows.Count > 0) // Check if DataTable is not empty
            {

                foreach (DataRow row in dt.Rows)
                {
                    int stdId = Convert.ToInt32(row["StudentId"]);
                    string stdName = GetStudentName(stdId);
                    int stdRubricLevelId = Convert.ToInt32(row["RubricMeasurementId"]); 
                    double stdRubricLevel = GetRubricLevel(stdRubricLevelId);
                    int assComId = Convert.ToInt32(row["AssessmentComponentId"]);
                    string assComName = GetAssComName(assComId);
                    int rubricId = GetRubricId(stdRubricLevelId);
                    // Perform calculations on marks
                    double obtainedMarks = CalculateMarks(stdRubricLevel, assComId, rubricId);
                    dataGridViewResults.Rows.Add(stdName, assComName, totalMarks, stdRubricLevel, obtainedMarks);
                }
            }
        }
        public string GetAssComName(int id)
        {
            string Query = "Select Name from AssessmentComponent where Id = " + id;
            DataTable dt = Connection.GetData(Query);
            return dt.Rows[0][0].ToString();
        }
        private void CbAss_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAssessmentComponents();
        }

   
        private void CbAssComp_SelectedIndexChanged(object sender, EventArgs e)
        {
               LoadRubrics();
        }

        private void CbRbrcs_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRubricLevels();
        }

       

        private void EvaluateBt_Click(object sender, EventArgs e)
        {
            try
            {
                int rubricId = Convert.ToInt32(CbRbrcs.SelectedValue);
                int stdId = Convert.ToInt32(CbStd.SelectedValue);
                string stdName = GetStudentName(stdId);
                int assComId = Convert.ToInt32(CbAssComp.SelectedValue);
                string assComName = GetAssComName(assComId);
                int stdRubricLevelId = Convert.ToInt32(CbRbrcsScore.SelectedValue);
                double stdRubricLevel = GetRubricLevel(stdRubricLevelId);
                double obtainedMarks = CalculateMarks(stdRubricLevel, assComId, rubricId);
                DateTime date = DateTime.Now;
                // check if the student has already been evaluated
                bool studentEvaluated = IsEvaluated();
                if (studentEvaluated)
                {
                    MessageBox.Show("Student has already been evaluated");
                    return;
                }

                dataGridViewResults.Rows.Add(stdName, assComName, totalMarks, stdRubricLevel, obtainedMarks);
                string Query = "Insert into StudentResult(StudentId, AssessmentComponentId, RubricMeasurementId,EvaluationDate) Values({0},{1},{2},'{3}')";
                Query = String.Format(Query, stdId, assComId, stdRubricLevelId, date);
                int i = Connection.SetData(Query);
                if (i == 1)
                {
                    MessageBox.Show("Result Added");

                }
                else
                {
                    MessageBox.Show("Error");
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ReportBt_Click(object sender, EventArgs e)
        {
            // show reports form 
            Reports reports = new Reports();
            reports.Show();
        }
    }
}
