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
    public partial class ClassSessions : Form
    {
        Functions Connection;
        public ClassSessions()
        {
            InitializeComponent();
            Connection = new Functions();
        }

       

        private void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {

                DateTime date = DatePick.Value.Date;
                // check if the date is already in the database
                string Query1 = "SELECT * FROM ClassAttendance WHERE AttendanceDate = '{0}'";
                Query1 = String.Format(Query1, date);
                DataTable dt = Connection.GetData(Query1);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Class Session Already Exists");
                    return;
                }
                string Query2 = "INSERT INTO ClassAttendance(AttendanceDate) VALUES('{0}')";
                Query2 = String.Format(Query2, date);
                int i = Connection.SetData(Query2);
                if (i == 1)
                {
                    MessageBox.Show("Class Session Added");
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
    }
}
