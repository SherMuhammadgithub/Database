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
            string Query = "SELECT * FROM Clo";
            CLOsCb.DisplayMember = "Name";
            CLOsCb.ValueMember = "id";
            DataTable dt = Connection.GetData(Query);
            CLOsCb.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                   string Query = "INSERT INTO Rubric(Id,Details, CloId) VALUES('" + InputRbrcId.Text + "','" + InputRubDetail.Text + "', '" + CLOsCb.SelectedValue + "')";
                    int i = Connection.SetData(Query);
                    if (i == 1) // means 1 row is affected
                    {
                        MessageBox.Show("Rubric Added Successfully");
                        Rubric_Load();
                        InputRbrcId.Text = "";
                        InputRubDetail.Text = "";
                        CLOsCb.Text = "";
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
            string Query = "SELECT * FROM Rubric";
            DataTable dt = Connection.GetData(Query);
            RbrcDataGrid.DataSource = dt;
        }

        private void RbrcDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // i'll use it in future if needed
        }
    }
}
