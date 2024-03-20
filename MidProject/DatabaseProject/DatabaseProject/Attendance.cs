using System;
using System.Collections.Generic;                           //not completed yet
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Attendance : Form
    {
        Functions Connection;
        public Attendance()
        {
            InitializeComponent();
            Connection = new Functions();
            LoadStatus();
            LoadStudent();
        }
        private void LoadStatus()
        {
            String Query = "Select * from Lookup Where Category = 'ATTENDANCE_STATUS'";
            DataTable dt = Connection.GetData(Query);
            CbStatus.DisplayMember = "Name";
            CbStatus.ValueMember = "LookupId";
            CbStatus.DataSource = dt;
        }
        private void LoadStudent()
        {
            String Query = "Select * from Student";
            DataTable dt = Connection.GetData(Query);
            CbRegNo.DisplayMember = "RegistrationNumber";
            CbRegNo.ValueMember = "StudentId";
            CbRegNo.DataSource = dt;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                // empty value check will be added in future
                int StudentId = Convert.ToInt32(CbRegNo.SelectedValue);
                DateTime Date = DatePick.Value.Date;
                int Status = Convert.ToInt32(CbStatus.SelectedValue);
                string Query = "Insert into Attendance (StudentId, AttendanceDate, AttendanceStatus) Values({0},{1},{2}))";
                Query = String.Format(Query, StudentId, Date, Status);
               int i = Connection.SetData(Query);
                if (i == 1)
                {
                    MessageBox.Show("Attendance Added");
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch (Exception err)

            {

            }
        }
    }
}
