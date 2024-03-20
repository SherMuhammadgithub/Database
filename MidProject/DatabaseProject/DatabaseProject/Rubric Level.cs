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
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if(InputDetails.Text == "" || CbRbrcs.Text == "" || CbRbrcs.Text == "")
                {
                    MessageBox.Show("Please enter all the fields");
                }
                else
                {
                    int rbrcId = Convert.ToInt32(CbRbrcs.SelectedValue);
                    
                    string Query = "INSERT INTO RubricLevel(RubricId, Details, MeasurementLevel) VALUES({0},'{1}',{2})"; // CbRbrcLvl.SelectedValue confirmation from sir
                    Query = string.Format(Query,rbrcId, InputDetails.Text, CbRbrcLvl.SelectedItem);
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
            catch(Exception ex)
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
    }
}
