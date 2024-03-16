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
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ListEmployees();
            GetDepartments();
        }
        private void ListEmployees()
        {
            string Query = "Select * from EmployeeTbl";
            DataTable dt = Con.GetData(Query);
            EmpData.DataSource = dt;
        }
        private void GetDepartments()
        {
            string Query = "Select * from DepartmentTbl";
            EmpDepCb.DisplayMember = "DepName";
            EmpDepCb.ValueMember = "DepId";
            EmpDepCb.DataSource = Con.GetData(Query);

        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpDepCb.SelectedIndex == -1 || EmpSalaryTb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string EmpName = EmpNameTb.Text;
                    string EmpGen = EmpGenCb.SelectedItem.ToString();
                    int EmpDep = int.Parse(EmpDepCb.SelectedValue.ToString());//foriegn key
                    string EmpdOB = DOBDateTb.Value.ToString();
                    string EmpDOB = DOBDateTb.Value.Date.ToString();
                    string EmpHireDate = JDateTb.Value.Date.ToString()
                        ;
                    int EmpSalary = int.Parse(EmpSalaryTb.Text);

                    string Query = "insert into EmployeeTbl(EmpName,EmpGen,EmpDep,EmpDOB,EmpJDate,EmpSal) values('" + EmpName + "','" + EmpGen + "'," + EmpDep + ",'" + EmpDOB + "','" + EmpHireDate + "'," + EmpSalary + ")";
                    Con.SetData(Query);
                    ListEmployees();
                    MessageBox.Show("Added Successfully");
                    EmpNameTb.Text = "";
                    EmpGenCb.SelectedIndex = -1;
                    EmpDepCb.SelectedIndex = -1;
                    EmpSalaryTb.Text = "";
                    DOBDateTb.Value = DateTime.Now;
                    JDateTb.Value = DateTime.Now;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // getting the selected row data from the EmployeeTblList
        int key = 0;
        private void EmpData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                key = Convert.ToInt32(EmpData.Rows[e.RowIndex].Cells[0].Value.ToString());
                EmpNameTb.Text = EmpData.Rows[e.RowIndex].Cells[1].Value.ToString();
                EmpGenCb.SelectedItem = EmpData.Rows[e.RowIndex].Cells[2].Value.ToString();
                EmpDepCb.SelectedValue = EmpData.Rows[e.RowIndex].Cells[3].Value.ToString();
                DOBDateTb.Value = Convert.ToDateTime(EmpData.Rows[e.RowIndex].Cells[4].Value.ToString());
                JDateTb.Value = Convert.ToDateTime(EmpData.Rows[e.RowIndex].Cells[5].Value.ToString());
                EmpSalaryTb.Text = EmpData.Rows[e.RowIndex].Cells[6].Value.ToString();
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
                if (EmpNameTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpDepCb.SelectedIndex == -1 || EmpSalaryTb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string EmpName = EmpNameTb.Text;
                    string EmpGen = EmpGenCb.SelectedItem.ToString();
                    int EmpDep = int.Parse(EmpDepCb.SelectedValue.ToString());//foriegn key
                    string EmpdOB = DOBDateTb.Value.ToString();
                    DateTime EmpDOB = DOBDateTb.Value.Date;
                    DateTime EmpHireDate = JDateTb.Value.Date
                        ;
                    int EmpSalary = int.Parse(EmpSalaryTb.Text);

                    string Query = "update EmployeeTbl set EmpName = '" + EmpName + "',EmpGen = '" + EmpGen + "',EmpDep = " + EmpDep + ",EmpDOB = '" + EmpDOB + "',EmpJDate = '" + EmpHireDate + "',EmpSal = " + EmpSalary + " where EmpId = " + key + "";
                    Con.SetData(Query);
                    ListEmployees();
                    MessageBox.Show("Updated Successfully");
                    EmpNameTb.Text = "";
                    EmpGenCb.SelectedIndex = -1;
                    EmpDepCb.SelectedIndex = -1;
                    EmpSalaryTb.Text = "";
                    DOBDateTb.Value = DateTime.Now;
                    JDateTb.Value = DateTime.Now;

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
                if (EmpNameTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpDepCb.SelectedIndex == -1 || EmpSalaryTb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string EmpName = EmpNameTb.Text;
                    string EmpGen = EmpGenCb.SelectedItem.ToString();
                    int EmpDep = int.Parse(EmpDepCb.SelectedValue.ToString());//foriegn key
                    string EmpdOB = DOBDateTb.Value.ToString();
                    DateTime EmpDOB = DOBDateTb.Value.Date;
                    DateTime EmpHireDate = JDateTb.Value.Date
                        ;
                    int EmpSalary = int.Parse(EmpSalaryTb.Text);

                   string Query = "delete from EmployeeTbl where EmpId = " + key + "";
                    Con.SetData(Query);
                    ListEmployees();
                    MessageBox.Show("Deleted Successfully");
                    EmpNameTb.Text = "";
                    EmpGenCb.SelectedIndex = -1;
                    EmpDepCb.SelectedIndex = -1;
                    EmpSalaryTb.Text = "";
                    DOBDateTb.Value = DateTime.Now;
                    JDateTb.Value = DateTime.Now;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            departments.Show();
            this.Hide();
        }

        private void Salary_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
