
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Employee(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }

}

public class EmployeeOpr
{

    List<Employee> emp = new List<Employee>();
    public void Add(int Id, string Name)
    {
        emp.Add(new Employee(Id, Name));
    }

    public void Remove(int Id)
    {
        for (int i = 0; i < emp.Count; i++)
        {
            if (emp[i].Id == Id)
            {
                emp.Remove(emp[i]);
                break;
            }
        }
    }

    public void Search(int Id)
    {
        for (int i = 0; i < emp.Count; i++)
        {
            if (emp[i].Id == Id)
            {
                System.Console.WriteLine(emp[i].Id + " " + emp[i].Name);
                break;
            }
        }
    }


    public void PrintEmpDetails()
    {
        for (int i = 0; i < emp.Count; i++)
        {
            System.Console.WriteLine(emp[i].Id + " " + emp[i].Name);
        }
    }
}

