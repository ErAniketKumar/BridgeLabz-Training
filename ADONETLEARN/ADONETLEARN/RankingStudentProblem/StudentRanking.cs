using System;
using Microsoft.Data.SqlClient;

namespace ADONETLEARN.ADONETLEARN.RankingStudentProblem
{

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Grade { get; set; }
    }
    public class StudentRanking
    {
        string conStr = "Server=aniket;Database=school_db;Trusted_Connection=True;Encrypt=false";

        public void RetrieveStudents(SqlConnection con)
        {
            string query = @"SELECT * FROM students";

            using SqlCommand cmd = new SqlCommand(query, con);

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + " ");
                }

                Console.WriteLine();
            }
        }


        public void RankStudents<T>(T based)
        {
            
        }

        public void StudentRandingHandlerFun()
        {
            using SqlConnection con = new SqlConnection(conStr);
            con.Open();

            RetrieveStudents(con);
        }
    }
}