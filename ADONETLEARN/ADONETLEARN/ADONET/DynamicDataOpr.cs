using System;
using Microsoft.Data.SqlClient;

namespace ADONETLEARN.ADONETLEARN.ADONET
{
    public interface IEmployeeService
    {
        void AddEmployee(Employee emp);
        void UpdateEmployee(int ID, Employee emp);
        void DeleteEmployee(int ID);
        void ViewEmployee(int ID);
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string Department { get; set; } = "";
        public double Salary { get; set; }
    }

    public class EmployeeManagement : IEmployeeService
    {
        string conStr = "Server=aniket;Database=school_db;Trusted_Connection=True;Encrypt=false;";

        public void CreateEmpTable()
        {
            using SqlConnection con = new(conStr);
            con.Open();
            SqlCommand cmd = new();
            cmd.Connection = con;
            cmd.CommandText = @"
            IF OBJECT_ID('employees','U') IS NULL
            CREATE TABLE employees
            (
                ID INT PRIMARY KEY IDENTITY(1,1),
                Name VARCHAR(50) NOT NULL,
                Age INT CHECK(Age>=18) NOT NULL,
                Department VARCHAR(50) NOT NULL,
                Salary DECIMAL(10,2) NOT NULL
            )";

            cmd.ExecuteNonQuery();
        }

        public void AddEmployee(Employee emp)
        {
            CreateEmpTable();

            using SqlConnection con = new(conStr);
            con.Open();

            SqlCommand cmd = new();
            cmd.Connection = con;

            cmd.CommandText = @"
            INSERT INTO employees(Name,Age,Department,Salary)
            VALUES(@Name,@Age,@Department,@Salary)";

            cmd.Parameters.AddWithValue("@Name", emp.Name);
            cmd.Parameters.AddWithValue("@Age", emp.Age);
            cmd.Parameters.AddWithValue("@Department", emp.Department);
            cmd.Parameters.AddWithValue("@Salary", emp.Salary);

            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Added Successfully!");
        }

        public void UpdateEmployee(int ID, Employee emp)
        {
            using SqlConnection con = new(conStr);
            con.Open();

            string query = @"
            UPDATE employees
            SET Name=@Name,
                Age=@Age,
                Department=@Department,
                Salary=@Salary
            WHERE ID=@ID";

            SqlCommand updateCmd = new(query, con);

            updateCmd.Parameters.AddWithValue("@Name", emp.Name);
            updateCmd.Parameters.AddWithValue("@Age", emp.Age);
            updateCmd.Parameters.AddWithValue("@Department", emp.Department);
            updateCmd.Parameters.AddWithValue("@Salary", emp.Salary);
            updateCmd.Parameters.AddWithValue("@ID", ID);

            int rows = updateCmd.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("Employee Updated Successfully!");
            else
                Console.WriteLine("Employee not found!");
        }

        public void DeleteEmployee(int ID)
        {
            using SqlConnection con = new(conStr);
            con.Open();

            string query = "DELETE FROM employees WHERE ID=@ID";

            SqlCommand cmd = new(query, con);

            cmd.Parameters.AddWithValue("@ID", ID);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("Employee Deleted Successfully!");
            else
                Console.WriteLine("Employee not found!");
        }

        public void ViewEmployee(int ID)
        {
            using SqlConnection con = new(conStr);
            con.Open();

            string query = "SELECT * FROM employees WHERE ID=@ID";

            SqlCommand cmd = new(query, con);

            cmd.Parameters.AddWithValue("@ID", ID);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + " ");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }

        public void EmployeeManagementHandler()
        {
            while (true)
            {
                Console.WriteLine("\n1.Add Employee");
                Console.WriteLine("2.Delete Employee");
                Console.WriteLine("3.Update Employee");
                Console.WriteLine("4.View Employee");
                Console.WriteLine("5.Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                    break;

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Age: ");
                            int age = int.Parse(Console.ReadLine());

                            Console.Write("Enter Department: ");
                            string department = Console.ReadLine();

                            Console.Write("Enter Salary: ");
                            double salary = double.Parse(Console.ReadLine());

                            Employee employee = new()
                            {
                                Name = name,
                                Age = age,
                                Department = department,
                                Salary = salary
                            };

                            AddEmployee(employee);
                            break;
                        }

                    case 2:
                        {
                            Console.Write("Enter ID: ");
                            int id = int.Parse(Console.ReadLine());

                            DeleteEmployee(id);
                            break;
                        }

                    case 3:
                        {
                            Console.Write("Enter ID: ");
                            int id = int.Parse(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Age: ");
                            int age = int.Parse(Console.ReadLine());

                            Console.Write("Enter Department: ");
                            string department = Console.ReadLine();

                            Console.Write("Enter Salary: ");
                            double salary = double.Parse(Console.ReadLine());

                            Employee employee = new()
                            {
                                ID = id,
                                Name = name,
                                Age = age,
                                Department = department,
                                Salary = salary
                            };

                            UpdateEmployee(id, employee);

                            break;
                        }

                    case 4:
                        {
                            Console.Write("Enter ID: ");
                            int id = int.Parse(Console.ReadLine());

                            ViewEmployee(id);

                            break;
                        }

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}