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
    public partial class Rubric : Form
    {
        private string connectionString; 

        public Rubric(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString; // Store connection string in constructor
            CloData();
            Rubric_Load();
        }

        private void CloData()
        {
            string query = "SELECT * FROM Clo";
            CLOsCb.DisplayMember = "Name";
            CLOsCb.ValueMember = "id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    CLOsCb.DataSource = dt;
                }
            }
        }

        private void AddRubrc_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputRubDetail.Text == "" || InputRbrcId.Text == "")
                {
                    MessageBox.Show("Please enter all the fields");
                }
                else
                {
                    int rubricId = int.Parse(InputRbrcId.Text.ToString());
                    string details = InputRubDetail.Text;
                    int cloId = Convert.ToInt32(CLOsCb.SelectedValue);

                    string query = "INSERT INTO Rubric(Id, Details, CloId) VALUES (@RubricId, @Details, @CloId)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@RubricId", rubricId);
                            command.Parameters.AddWithValue("@Details", details);
                            command.Parameters.AddWithValue("@CloId", cloId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected == 1)
                            {
                                MessageBox.Show("Rubric Added Successfully");
                                Rubric_Load();
                                InputRbrcId.Text = "";
                                InputRubDetail.Text = "";
                                CLOsCb.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Failed to add rubric.");
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

        private void Rubric_Load()
        {
            string query = "SELECT * FROM Rubric";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    RbrcDataGrid.DataSource = dt;
                }
            }
        }
    }
}
