using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ADONETLEARN.ADONETLEARN.ADONET
{

    public class DataBaseCrud
    {
        public void DBOpr()
        {
            string conStr = "Server=aniket;Database=school_db;Trusted_Connection=True;Encrypt=false;";

            try
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                System.Console.WriteLine("connected successfully!");

                string query = "SELECT * FROM students";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(
                        reader["s_id"] + " " +
                        reader["name"] + " " +
                        reader["age"]
                    );
                }

                con.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}