
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
}

public class SortListByNameAndAge
{
    List<Student> student = new List<Student>();

    public void AddStudent(string Name, int Age)
    {
        student.Add(new Student(Name, Age));
    }

    public void SortList()
    {
        student.Sort();
        var sortedlist = student.OrderByDescending(s => s.Age)
        .ThenBy(s => s.Name);

        foreach (var std in sortedlist)
        {
            System.Console.WriteLine($"{std.Name} - {std.Age}");
        }
    }
}