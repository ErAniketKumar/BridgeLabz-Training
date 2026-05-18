
public class EmployeeAlReadyExist : Exception
{
    public EmployeeAlReadyExist(string message) : base(message)
    {
        System.Console.WriteLine(message);
    }
}

public class EmployeeNotFoundExcaption : Exception
{
    public EmployeeNotFoundExcaption(string message) : base(message)
    {
        System.Console.WriteLine(message);
    }
}

internal class Employee
{
    public int EmpID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    Dictionary<int, Employee> dict = new Dictionary<int, Employee>();

    public void AddEmp(int EmpID, string Name, int Age, double Salary)
    {
        try
        {
            if (dict.ContainsKey(EmpID))
            {
                throw new EmployeeAlReadyExist("Employee already exist with this id!");
            }
            else
            {
                this.EmpID = EmpID;
                this.Name = Name;
                this.Age = Age;
                this.Salary = Salary;
                dict.Add(EmpID, this);
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
    public void DeleteEmp(int EmpID)
    {
        try
        {
            if (dict.ContainsKey(EmpID))
            {
                dict.Remove(EmpID);
            }
            else
            {
                throw new EmployeeNotFoundExcaption("Employee not found!");
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    public void UpdateEmp(int EmpID, string name, int age, double salary)
    {
        try
        {
            if (dict.ContainsKey(EmpID))
            {
                dict[EmpID].Name = name;
                dict[EmpID].Age = age;
                dict[EmpID].Salary = salary;
            }
            else
            {
                throw new EmployeeNotFoundExcaption("Employee Not Found!");
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    public void ViewEmp(int EmpID)
    {
        try
        {
            if (dict.ContainsKey(EmpID))
            {
                System.Console.WriteLine($"ID: {dict[EmpID].EmpID}\nName: {dict[EmpID].Name}\nAge: {dict[EmpID].Age}\nSalary: {dict[EmpID].Salary}");
            }
            else
            {
                throw new EmployeeNotFoundExcaption("Employee Not Found!");
            }

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }

        System.Console.WriteLine();
    }
}
public class EmployeeManagement
{
    public void EmployeeHandlerFun()
    {
        Employee emp = new Employee();


        while (true)
        {
            System.Console.WriteLine("Enter the choice\n1. Add Employee\n2. Delete Employee\n3. Update Employee\n4. View Employee Details\n5. Exist.");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 5) break;
            switch (choice)
            {
                case 1:
                    {
                        System.Console.WriteLine("Enter Employee ID");
                        int id = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter Employee Name");
                        string name = Console.ReadLine();
                        System.Console.WriteLine("Enter the Age");
                        int age = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter the Salary!");
                        double salary = double.Parse(Console.ReadLine());
                        emp.AddEmp(id, name, age, salary);
                        break;
                    }
                case 2:
                    {
                        System.Console.WriteLine("Enter Employee ID");
                        int id = int.Parse(Console.ReadLine());
                        emp.DeleteEmp(id);
                        break;
                    }
                case 3:
                    {
                        System.Console.WriteLine("Enter Employee ID");
                        int id = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter Employee Name");
                        string name = Console.ReadLine();
                        System.Console.WriteLine("Enter the Age");
                        int age = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter the Salary!");
                        double salary = double.Parse(Console.ReadLine());
                        emp.UpdateEmp(id, name, age, salary);
                        break;
                    }

                case 4:
                    {
                        System.Console.WriteLine("Enter Employee ID");
                        int id = int.Parse(Console.ReadLine());
                        emp.ViewEmp(id);
                        break;
                    }
                default:
                    System.Console.WriteLine("Enter Valid Choise");
                    break;
            }
        }
    }
}