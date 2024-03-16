using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMS
{
    public partial class Departments : Form
    {
        Functions Con;
        public Departments()
        {
            InitializeComponent();
            Con = new Functions();
            ListDepartments();
        }

        private void Departments_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void UpdtaeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTB.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string DepName = DepNameTB.Text;
                   string Query = "Update DepartmentTbl set DepName = '"+DepName+"' where DepId = "+key+"";
                    Con.SetData(Query);
                    ListDepartments();
                    MessageBox.Show("Updated Successfully");
                    DepNameTB.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ListDepartments()
        {
            string Query = "Select * from DepartmentTbl";
           // DepList. = Con.GetData(Query);
           DepData.DataSource = Con.GetData(Query);
            DataTable Departments = Con.GetData(Query);
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(DepNameTB.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }else
                {
                    string DepName = DepNameTB.Text;
                    string Query = "Insert into DepartmentTbl(DepName) Values('"+DepName+"')";
                    Con.SetData(Query);
                    ListDepartments();
                    MessageBox.Show("Department Added Successfully");
                    DepNameTB.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        int key = 0;
        private void DepData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                key = Convert.ToInt32(DepData.Rows[e.RowIndex].Cells[0].Value.ToString());
                DepNameTB.Text = DepData.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTB.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string DepName = DepNameTB.Text;
                    string Query = "Delete from DepartmentTbl where DepId = " + key + "";
                    Con.SetData(Query);
                    ListDepartments();
                    MessageBox.Show("Department Deleted Successfully");
                    DepNameTB.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void EmpLb_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show(); // shows the Employees form
            this.Hide(); // Hides the Departments form
        }

        private void SalaryLb_Click(object sender, EventArgs e)
        {
            Salary Obj = new Salary();
            Obj.Show(); // shows the Salary form
            this.Hide(); // Hides the Salary form
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); // shows the Form1 form
            this.Hide(); // Hides the Departments form
        }
    }
}
