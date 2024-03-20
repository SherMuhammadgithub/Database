
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
        private string connectionString; // Replace with your actual connection string

        public AssessmentComp(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString; // Store connection string in constructor
            LoadRbrcs();
            LoadAssessments();
            LoadAssessmentComp();
        }

        private void LoadRbrcs()
        {
            string query = "SELECT * FROM Rubric";
            CbRbrcs.DisplayMember = "Id"; // Assuming "Id" is a column containing rubrics' IDs
            CbRbrcs.ValueMember = "Id"; // This seems like a mistake, likely should be "CbRbrcs.ValueMember"

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    CbRbrcs.DataSource = dt;
                }
            }
        }

        private void LoadAssessments()
        {
            string query = "SELECT * FROM Assessment";
            CbAssmnt.DisplayMember = "Title";
            CbAssmnt.ValueMember = "Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    CbAssmnt.DataSource = dt;
                }
            }
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

                    string query = "INSERT INTO AssessmentComponent(Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) VALUES (@Name, @RubricId, @TotalMarks, @DateCreated, @DateUpdated, @AssessmentId)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@RubricId", rubricId);
                            command.Parameters.AddWithValue("@TotalMarks", totalMarks);
                            command.Parameters.AddWithValue("@DateCreated", dateCreated);
                            command.Parameters.AddWithValue("@DateUpdated", dateUpdated);
                            command.Parameters.AddWithValue("@AssessmentId", assessmentId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected == 1)
                            {
                                LoadAssessmentComp();
                                MessageBox.Show("Assessment Component Added Successfully");
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());  // This line was missing
                    AssmntCompGrid.DataSource = dt;
                }
            }
        }
    }
}