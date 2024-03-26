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

        private void Students_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime date = DatePick.Value.Date;
                string Query = "INSERT INTO ClassAttendance(AttendanceDate) VALUES('{0}')";
                Query = String.Format(Query, date);
                int i = Connection.SetData(Query);
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
