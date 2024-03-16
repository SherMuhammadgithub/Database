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
    public partial class CLO : Form
    {
        Functions Connection;
        public CLO()
        {
            Connection = new Functions();
            InitializeComponent();
            CLO_Load();
        }
        // showing all the Clo in the grid view
        private void CLO_Load()
        {
            string Query = "SELECT * FROM Clo";
            DataTable dt = Connection.GetData(Query);
            CloDataGrid.DataSource = dt;
        }
        private void AddClo_Click(object sender, EventArgs e)
        {
            try
            {
                if(InputClo.Text == "")
                {
                    MessageBox.Show("Please enter the CLO");
                }
                else
                {
                    string Query = "INSERT INTO Clo(Name, DateCreated, DateUpdated) VALUES('" + InputClo.Text + "', '" + DateTime.Now + "', '" + DateTime.Now + "')";
                    int i = Connection.SetData(Query);
                    if(i == 1) // means 1 row is affected
                    {
                        CLO_Load();
                        MessageBox.Show("CLO Added Successfully");
                        InputClo.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void UpdateClo_Click(object sender, EventArgs e)
        {
            try
            {
                if(InputClo.Text == "")
                {
                    MessageBox.Show("Please enter the CLO");
                }
                else
                {
                    string Query = "UPDATE Clo SET Name = '" + InputClo.Text + "', DateUpdated = '" + DateTime.Now + "' WHERE Id = '" + cloIndexKey + "'";
                    int i = Connection.SetData(Query);
                    if(i == 1) // means 1 row is affected
                    {
                        CLO_Load();
                        MessageBox.Show("CLO Updated Successfully");
                        InputClo.Text = "";
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        int cloIndexKey = 0;
        private void CloDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cloIndexKey = Convert.ToInt32(CloDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()); // cell one has cloId
                InputClo.Text = CloDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString(); 
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message); 
            }
        }

        private void DeleteClo_Click(object sender, EventArgs e)
        {
            try
            {
                if(InputClo.Text == "")
                {
                    MessageBox.Show("Plz Select the data to delete");
                }
                else
                {
                    string Query = "DELETE FROM Clo WHERE Id = '" + cloIndexKey + "'";
                    int i = Connection.SetData(Query);
                    if(i == 1) // means 1 row is affected
                    {
                        CLO_Load();
                        MessageBox.Show("CLO Deleted Successfully");
                        InputClo.Text = "";
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
