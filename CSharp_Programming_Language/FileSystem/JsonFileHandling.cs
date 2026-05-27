using System;
using System.Text.Json;
using System.Text;
using System.IO;
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public char Gender { get; set; }
}

public class JsonFileHandling
{
    Student student = new Student
    {
        Name = "Aniket",
        Age = 20,
        Gender = 'M'
    };
    public void JsonHandleFun()
    {

        // System.Console.WriteLine(student);
        // System.Console.WriteLine(student.Age);

        string CurrDir = Directory.GetCurrentDirectory();

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(student, options);

        File.WriteAllText(CurrDir + @"/FileSystem/student.json", json);

        Student ss = JsonSerializer.Deserialize<Student>(json);

        System.Console.WriteLine(ss.Gender);

    }
}