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
    public partial class Salary : Form
    {
        Functions Con;
        public Salary()
        {
            InitializeComponent();
            Con = new Functions();
            ListSalaries();
            GetEmployees();
        }
        private void ListSalaries()
        {
            string Query = "Select * from SalaryTbl";
            DataTable dt = Con.GetData(Query);
            SalaryData.DataSource = dt;
        }

        //getting the Employees from the database
        private void GetEmployees()
        {
            string Query = "Select * from EmployeeTbl";
            EmpCb.DisplayMember = "EmpName";
            EmpCb.ValueMember = "EmpId";
            EmpCb.DataSource = Con.GetData(Query);

        }
        int DailySalary = 0;
        string Periode = "";
        private void GetSalary()
        {
            string Query = "Select EmpSal from EmployeeTbl where EmpId = " + EmpCb.SelectedValue.ToString() + "";
            DataTable dt = Con.GetData(Query);
            DailySalary = int.Parse(dt.Rows[0][0].ToString());
            SalaryTb.Text = "Rs " + (DailySalary).ToString();

        }

        private void SalaryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalaryTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void EmpCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (EmpCb.SelectedIndex == -1 || AttendDaysTb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                     Periode = PeriodTb.Value.Date.ToString();
                     int AttendedDays = int.Parse(AttendDaysTb.Text);
                    if(AttendedDays > 31)
                    {
                        MessageBox.Show("Attendance Days cannot be more than 31");
                    }
                    else
                    {
                        int TotalSalary = DailySalary * int.Parse(AttendDaysTb.Text);
                        SalaryTb.Text = "RS " + TotalSalary.ToString();
                        string Query = "insert into SalaryTbl(Employee,Attendance,Period,Amount,PayDate) values(" + EmpCb.SelectedValue.ToString() + "," + AttendDaysTb.Text + ",'" + Periode + "'," + TotalSalary + ",'" + DateTime.Now.ToString() + "')";
                        Con.SetData(Query);
                        ListSalaries();
                        MessageBox.Show("Salary Added Successfully");

                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();

        }

        private void DepartmentLb_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            departments.Show();
            this.Hide();
        }
    }
}
