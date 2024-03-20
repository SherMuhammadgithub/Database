
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Required for SqlConnection
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void LoadRbrcs()
        {
            string query = "SELECT * FROM Rubric";
            DataTable dt = Connection.GetData(query);
            CbRbrcs.DisplayMember = "Id"; 
            CbRbrcs.ValueMember = "Id"; 
            CbRbrcs.DataSource = dt;
        }

        private void LoadAssessments()
        {
            string query = "SELECT * FROM Assessment";
            DataTable dt = Connection.GetData(query);
            CbAssmnt.DisplayMember = "Title";
            CbAssmnt.ValueMember = "Id";
            CbAssmnt.DataSource = dt;
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
                    string name = InputName.Text;
                    int rubricId = Convert.ToInt32(CbRbrcs.SelectedValue);
                    int totalMarks = Convert.ToInt32(InputTMarks.Text);
                    DateTime dateCreated = DateTime.Now;
                    DateTime dateUpdated = DateTime.Now;
                    int assessmentId = Convert.ToInt32(CbAssmnt.SelectedValue);

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

        private void LoadAssessmentComp()
        {
            string query = "SELECT * FROM AssessmentComponent";
            DataTable dt = Connection.GetData(query);
            AssmntCompGrid.DataSource = dt;

        }
    }
}