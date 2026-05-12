

using System.ComponentModel.DataAnnotations;

public class Student
{
    [Required]
    public string Name { get; set; }
    [Range(18, 24)]
    public int Age { get; set; }

    public Student(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    internal void Student_Details()
    {
        System.Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class AnotationBasic
{
    public void AnotationOpr()
    {
        Student student1 = new Student("Aniket", 20);

        Student student2 = new Student("Aniket", 30);
        Student student3 = new Student("", 30);
        student1.Student_Details();
        student2.Student_Details();
        student3.Student_Details();
    }
}