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
        Functions Connection;

        public Rubric()
        {
            InitializeComponent();
            Connection = new Functions();
            CloData();
            Rubric_Load();
        }

        private void CloData()
        {
            string query = "SELECT * FROM Clo";
            DataTable dt = Connection.GetData(query);
            CLOsCb.DisplayMember = "Name";
            CLOsCb.ValueMember = "id";
            CLOsCb.DataSource = dt;
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

                    string Query = "INSERT INTO Rubric(Id, Details, CloId) VALUES ({0}, '{1}', {2})";
                    Query = string.Format(Query, rubricId, details, cloId);

                    int rowsAffected = Connection.SetData(Query);

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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
       }
        }
        private void Rubric_Load()
        {
            string query = "SELECT * FROM Rubric";
            DataTable dt = Connection.GetData(query);
            RbrcDataGrid.DataSource = dt;
        }
    }
}
