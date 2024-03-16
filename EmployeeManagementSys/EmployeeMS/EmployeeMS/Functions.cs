using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS
{
    internal class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private SqlDataAdapter sda;
        private DataTable dt;
        private string conStr;

        public Functions()
        {
            conStr = @"Server=localhost\SQLEXPRESS02;Database=EMS;Trusted_Connection=True";
            Con = new SqlConnection(conStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        public DataTable GetData(string query)
        {
            sda = new SqlDataAdapter(query, Con);
            dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public int SetData(string query)
        {
            int cnt = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = query;
             cnt  = Cmd.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }
    }
}
