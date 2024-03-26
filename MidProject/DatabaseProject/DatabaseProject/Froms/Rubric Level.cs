using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Rubric_Level : Form
    {
        Functions Connection;
        public Rubric_Level()
        {
            InitializeComponent();
            Connection = new Functions();
            RubricList();
            LoadRubricLevel();
        }
        // Load available rubrics in the combobox
        private void RubricList()
        {
            try
            {
                string Query = "SELECT * FROM Rubric";
                CbRbrcs.DisplayMember = "id";
                CbRbrcs.ValueMember = "id";
                DataTable dt = Connection.GetData(Query);
                CbRbrcs.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void LoadRubricLevel()
        {
            try
            {
                string Query = "SELECT * FROM RubricLevel";
                DataTable dt = Connection.GetData(Query);
                RbrcLvlGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int GetRubricLevelInteger()
        {
            int level = -1;
            if(CbRbrcLvl.Text == "Exceptional")
            {
                level = 4;
            }
            else if (CbRbrcLvl.Text == "Good")
            {
                level = 3;
            }
            else if (CbRbrcLvl.Text == "Fair")
            {
                level = 2;
            }
            else if (CbRbrcLvl.Text == "Unsatisfactory")
            {
                level = 1;
            }
            return level;
        }
        int RbrcLvlKey = 0;
        private void RbrcLvlGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RbrcLvlKey = Convert.ToInt32(RbrcLvlGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            InputDetails.Text = RbrcLvlGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            CbRbrcs.Text = RbrcLvlGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            CbRbrcLvl.Text = RbrcLvlGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

        }


       


        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputDetails.Text == "" || CbRbrcs.Text == "" || CbRbrcs.Text == "")
                {
                    MessageBox.Show("Please enter all the fields");
                }
                else
                {
                    int rbrcId = Convert.ToInt32(CbRbrcs.SelectedValue);
                    int rbrcLvl = GetRubricLevelInteger();
                    string Query = "INSERT INTO RubricLevel(RubricId, Details, MeasurementLevel) VALUES({0},'{1}',{2})"; // CbRbrcLvl.SelectedValue confirmation from sir
                    Query = string.Format(Query, rbrcId, InputDetails.Text, rbrcLvl);
                    int i = Connection.SetData(Query);
                    if (i == 1) // means 1 row is affected
                    {
                        LoadRubricLevel();
                        MessageBox.Show("Rubric Level Added Successfully");
                        InputDetails.Text = "";
                        CbRbrcs.Text = "";
                        CbRbrcLvl.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RbrcLvlKey == 0)
                {
                    MessageBox.Show("Please select a record to delete");
                    return;
                }
                string Query = "DELETE FROM RubricLevel WHERE Id = {0}";
                Query = string.Format(Query, RbrcLvlKey);
                int i = Connection.SetData(Query);
                if (i == 1) // means 1 row is affected
                {
                    LoadRubricLevel();
                    MessageBox.Show("Rubric Level Deleted Successfully");
                    InputDetails.Text = "";
                    CbRbrcs.Text = "";
                    CbRbrcLvl.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to delete rubric level.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RbrcLvlKey == 0)
                {
                    MessageBox.Show("Please select a record to update");
                    return;
                }

                int rbrcId = Convert.ToInt32(CbRbrcs.SelectedValue);
                int rbrcLvl = GetRubricLevelInteger();
                string Query = "UPDATE RubricLevel SET RubricId = {0}, Details = '{1}', MeasurementLevel = {2} WHERE Id = {3}";
                Query = string.Format(Query, rbrcId, InputDetails.Text, rbrcLvl, RbrcLvlKey);
                int i = Connection.SetData(Query);
                if (i == 1) // means 1 row is affected
                {
                    LoadRubricLevel();
                    MessageBox.Show("Rubric Level Updated Successfully");
                    InputDetails.Text = "";
                    CbRbrcs.Text = "";
                    CbRbrcLvl.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to update rubric level.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Rubric_Level_Load(object sender, EventArgs e)
        {

        }
    }
}
