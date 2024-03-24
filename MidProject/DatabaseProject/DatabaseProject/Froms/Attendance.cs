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
    public partial class Attendance : Form
    {
        Functions Connection;
        public Attendance()
        {
            InitializeComponent();
            Connection = new Functions();
            LoadStatus();
            LoadStudent();
            LoadClassSessions();
        }
        private void LoadClassSessions()
        {
            string Query = "Select * from ClassAttendance";
            DataTable dt = Connection.GetData(Query);
            SessionAttend.DisplayMember = "AttendanceDate";
            SessionAttend.ValueMember = "Id";
            SessionAttend.DataSource = dt;
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
            CbRegNo.ValueMember = "Id";
            CbRegNo.DataSource = dt;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                // empty value check will be added in future
                int AttendanceId = Convert.ToInt32(SessionAttend.SelectedValue);
                int StudentId = Convert.ToInt32(CbRegNo.SelectedValue);
                bool isAlreadyMarked = CheckAttendance(StudentId, AttendanceId);
                if(isAlreadyMarked)
                {
                    MessageBox.Show("The Attedndance is already marked");
                    return;
                }     
                int StatusId = Convert.ToInt32(CbStatus.SelectedValue);
                string Query = "Insert into StudentAttendance (AttendanceId, StudentId, AttendanceStatus) Values({0},{1},{2})";
                Query = String.Format(Query, AttendanceId, StudentId, StatusId);
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
                MessageBox.Show(err.Message);
            }
        }
        private bool CheckAttendance(int stdId, int attendId) // this will check if attendance is already set for the date
        {
            string Query = "Select * from StudentAttendance Where StudentId = {0} and AttendanceId = {1}";
            Query = String.Format(Query, stdId, attendId);
            DataTable dt = Connection.GetData(Query);
            if (dt.Rows.Count == 0) // if no row is returned then attendance is not marked
            {
                return false;
            }
            else
            {
                return true; // if row is returned then attendance is already marked
            }
        }
    }
}
