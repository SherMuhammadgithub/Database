using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
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
            conStr = @"Server=localhost\SQLEXPRESS02;Database=ProjectB;Trusted_Connection=True";
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
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = query;
            cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }
        public List<Dictionary<string, object>> GetAssessmentComponents(int assessmentId)
        {
            List<Dictionary<string, object>> components = new List<Dictionary<string, object>>();

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                string query = "SELECT Id, Name, TotalMarks FROM AssessmentComponent WHERE AssessmentId = @AssessmentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AssessmentId", assessmentId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> component = new Dictionary<string, object>();
                        component["Id"] = reader.GetInt32(0);
                        component["Name"] = reader.GetString(1);
                        component["TotalMarks"] = reader.GetInt32(2);

                        components.Add(component);
                    }
                }
            }

            return components;
        }

        public int GetStudentRubricLevel(int studentId, int componentId)
        {
            int rubricLevel = 0; // Default value

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                string query = "SELECT MeasurementLevel FROM StudentResult " +
                               "INNER JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id " +
                               "WHERE StudentId = @StudentId AND AssessmentComponentId = @ComponentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@ComponentId", componentId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rubricLevel = reader.GetInt32(0); // Assuming MeasurementLevel is an integer column
                    }
                }
            }

            return rubricLevel;
        }

        public int GetMaxRubricLevel()
        {
            int maxRubricLevel = 0; // Default value

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                string query = "SELECT MAX(MeasurementLevel) FROM RubricLevel"; // Assuming MeasurementLevel stores the maximum level
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        maxRubricLevel = reader.GetInt32(0); // Assuming MeasurementLevel is an integer column
                    }
                }
            }

            return maxRubricLevel;
        }



    }
}
