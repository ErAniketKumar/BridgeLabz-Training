using System;
using Microsoft.Data.SqlClient;

namespace ADONETLEARN.ADONETLEARN.ADONET
{
    public class CRUDOperation
    {
        public string connection_str = "Server=aniket;Database=school_db;Trusted_Connection=True;Encrypt=false;";

        public void DataRead(SqlCommand cmd)
        {
            using SqlDataReader reader = cmd.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                System.Console.Write(reader.GetName(i) + " ");
            }

            System.Console.WriteLine();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    System.Console.Write(reader[i] + " ");
                }
                System.Console.WriteLine();
            }
        }

        public void CRUDFUN(SqlConnection con)
        {
            string readquerry = "SELECT * FROM students";

            SqlCommand cmd = new SqlCommand(readquerry, con);



            DataRead(cmd);

            string insertquerry = @"INSERT INTO students (name, age)
            values ('Sunil', 22),
                   ('deepak', 24),
                   ('Rahul',25)
            ";

            cmd.CommandText = insertquerry;
            cmd.ExecuteNonQuery();
            // cmd.CommandText = readquerry;
            // DataRead(cmd);


            // drop table
            // cmd.CommandText = "DROP TABLE students";
            // cmd.ExecuteNonQuery();


            // create new table 
            // cmd.CommandText = @"CREATE TABLE students
            //                 (
            //                     sid INT PRIMARY KEY IDENTITY(1,1),
            //                     name varchar(50) NOT NULL,
            //                     age INT CHECK(age>=18) NOT NULL
            //                 )";
            // cmd.ExecuteNonQuery();

            // cmd.CommandText = @"INSERT INTO students(name, age)
            //                  VALUES ('aniket', 21),
            //                         ('kumar', 22),
            //                         ('soni', 23),
            //                         ('anup', 24),
            //                         ('anamika', 25)
            //                         ";
            // cmd.ExecuteNonQuery();

            //read
            // cmd.CommandText = readquerry;
            // DataRead(cmd);

            // update data

            // cmd.CommandText = @"UPDATE students
            //                 SET name='Jivan' WHERE sid=5";

            // cmd.ExecuteNonQuery();

            cmd.CommandText = readquerry;
            // DataRead(cmd);

            // Delete

            // cmd.CommandText = @"DELETE FROM students
            //                      WHERE sid=2";
            // cmd.ExecuteNonQuery();

            // cmd.CommandText = readquerry;
            // DataRead(cmd);
        }
        public void ConnectionHandler()
        {
            using SqlConnection con = new SqlConnection(connection_str);
            con.Open();

            System.Console.WriteLine("Connection Stablished Successfully!");

            CRUDFUN(con);

        }
    }
}