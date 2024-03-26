using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace DatabaseProject
{
    public partial class Reports : Form
    {
        Functions Connection;
        StudentResult StudentResult;
        public Reports()
        {
            InitializeComponent();
            Connection = new Functions();
            StudentResult = new StudentResult();
        }

      

        public DataTable LoadStudentResult()
        {

            DataTable NewData = new DataTable();
            NewData.Columns.Add("StudentId", typeof(int));
            NewData.Columns.Add("StudentName", typeof(string));
            NewData.Columns.Add("RubricLevel", typeof(double));
            NewData.Columns.Add("AssessmentComponentId", typeof(int));
            NewData.Columns.Add("ObtainedMarks", typeof(double));
            NewData.Columns.Add("AssessmentName", typeof(string));
            // Assessement Name 
            string query = "Select * from StudentResult";
            DataTable dt = Connection.GetData(query);
            if (dt.Rows.Count > 0) // Check if DataTable is not empty
            {

                foreach (DataRow row in dt.Rows)
                {
                    int stdId = Convert.ToInt32(row["StudentId"]);
                    string stdName = StudentResult.GetStudentName(stdId);
                    int stdRubricLevelId = Convert.ToInt32(row["RubricMeasurementId"]);
                    double stdRubricLevel = StudentResult.GetRubricLevel(stdRubricLevelId);
                    int assComId = Convert.ToInt32(row["AssessmentComponentId"]);
                    string assName = GetAssessmentName(assComId);
                    int rubricId = StudentResult.GetRubricId(stdRubricLevelId);
                    // Perform calculations on marks
                    double obtainedMarks = StudentResult.CalculateMarks(stdRubricLevel, assComId, rubricId);
                    // add rows to new DataTable
                    NewData.Rows.Add(stdId, stdName, stdRubricLevel, assComId, obtainedMarks, assName);
                }
                return GetCompleteReportData(NewData);
            }
            return null;
        }
        private string GetAssessmentName(int assComId)
        {
            string query = "Select * from AssessmentComponent";
            DataTable dt = Connection.GetData(query);
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["Id"]) == assComId)
                {
                    int assId = Convert.ToInt32(row["AssessmentId"]);
                    string query2 = "Select * from Assessment";
                    DataTable dt2 = Connection.GetData(query2);
                    foreach (DataRow row2 in dt2.Rows)
                    {
                        if (Convert.ToInt32(row2["Id"]) == assId)
                        {
                            return row2["Title"].ToString(); // return assessment name
                        }
                    }
                }
            }
            return null;
        }
        private double GetTotalAssessmentMarks(DataTable NewData, int stdId, string assName)
        {
            double totalAssessmentMarks = 0;

            // implement the logic to calculate total marks of an assessment
            for (int i = 0; i < NewData.Rows.Count; i++)
            {
                DataRow row = NewData.Rows[i];
                //  MessageBox.Show($"{row["StudentId"].ToString()} == {stdId.ToString()} && {row["AssessmentName"].ToString()} == {assName} ");
                if (row["StudentId"].ToString() == stdId.ToString() && row["AssessmentName"].ToString() == assName)
                {
                    totalAssessmentMarks += Convert.ToDouble(row["ObtainedMarks"]);
                }
            }

            return totalAssessmentMarks;
        }

        private int GetTMarks(string assName)
        {
            string query = "Select * from Assessment";
            DataTable dt = Connection.GetData(query);
            foreach (DataRow row in dt.Rows)
            {
                if (row["Title"].ToString() == assName)
                {
                    return Convert.ToInt32(row["TotalMarks"]);
                }
            }
            return 0;
        }
        private DataTable GetCompleteReportData(DataTable NewData)    // stdId, stdName, stdRubricLevel, assComName, obtainedMarks
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StudentName", typeof(string));
            dataTable.Columns.Add("AssessmentName", typeof(string));
            dataTable.Columns.Add("TotalMarks", typeof(int));
            dataTable.Columns.Add("ObtainedMarks", typeof(double));
            if (NewData == null) return null;
            for (int j = 0; j < NewData.Rows.Count; j++)
            {
                // check if the row is removed
                DataRow row1 = NewData.Rows[j];
                if (row1 == null) continue;
                int stdId = Convert.ToInt32(row1["StudentId"]);
                string stdName = StudentResult.GetStudentName(stdId);
                string assName = row1["AssessmentName"].ToString();
                double totalAssessmentMarks = GetTotalAssessmentMarks(NewData, stdId, assName);

                int OutOfMarks = GetTMarks(assName);
                // add new row to new DataTable
                dataTable.Rows.Add(stdName, assName, OutOfMarks, totalAssessmentMarks);
                // after getting total marks remove all the rows with same student id and assessment name
                for (int i = 0; i < NewData.Rows.Count; i++)
                {
                    DataRow row2 = NewData.Rows[i];
                    // Remove the row if it has the same student id and assessment name
                    if (row2["StudentId"].ToString() == stdId.ToString() && row2["AssessmentName"].ToString() == assName)
                    {
                        NewData.Rows[i].Delete();
                    }
                }
            }
            return dataTable;
        }

        private void LoadReport_Click(object sender, EventArgs e)
        {
           
           
        }
        private void CreateStudentReportPDF(DataTable studentReport)
        {
            try
            {
                // Create a new PDF document
                Document doc = new Document(PageSize.A4); // Set page size
                PdfWriter.GetInstance(doc, new FileStream("StudentReport.pdf", FileMode.Create));
                doc.Open();

                // Add report header (similar to previous code)
                Paragraph header = new Paragraph("Student Assessement Wise Reports"); // Create a new paragraph
                header.Alignment = Element.ALIGN_CENTER;
               header.Font = FontFactory.GetFont(FontFactory.HELVETICA, 20, BaseColor.BLACK);
                doc.Add(header);

                // Create a PDF table
                PdfPTable table = CreateStudentReportTable(studentReport); // Create a table with student report data
                // get some space between header and table
                table.SpacingBefore = 20f; // 
               
                doc.Add(table);

                // **Close the PDF document**
                doc.Close();

                MessageBox.Show("Loaded");
                // after generating pdf open the file
                System.Diagnostics.Process.Start("StudentReport.pdf");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private PdfPTable CreateStudentReportTable(DataTable studentReport)
        {
            PdfPTable table = new PdfPTable(4); // Four columns for student name, assessment name, total marks, obtained marks
            var tableHeader = FontFactory.GetFont(FontFactory.TIMES_BOLD, 13, BaseColor.BLACK);
            // Add table headers
            // arrange the alignment of the table to center
            table.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell cell = new PdfPCell(new Phrase("Student Name", tableHeader));
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);
            // set alignment to center
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell = new PdfPCell(new Phrase("Assessment Name", tableHeader));
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Total Marks", tableHeader));
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Obtained Marks", tableHeader));
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            // Add data rows
            foreach (DataRow row in studentReport.Rows)
            {
                string studentName = row["StudentName"].ToString();
                string assessmentName = row["AssessmentName"].ToString();
                int totalMarks = Convert.ToInt32(row["TotalMarks"]);
                double obtainedMarks = Convert.ToDouble(row["ObtainedMarks"]);

                cell = new PdfPCell(new Phrase(studentName));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(assessmentName));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(totalMarks.ToString()));
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase(obtainedMarks.ToString()));
                table.AddCell(cell);
            }

            return table;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }


        private void Reports_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("I am here");
            DataTable StudentReport = LoadStudentResult();
            CreateStudentReportPDF(StudentReport);
            // hide this form
            this.Hide();
        }
    }
}

