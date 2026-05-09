using System;
using System.IO;
using System.Text.Json;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class ProgramP
{
    static void Main()
    {
        Student s = new Student()
        {
            Id = 1,
            Name = "Aniket"
        };

        // Object -> JSON
        string json =
            JsonSerializer.Serialize(s);

        // Save file
        File.WriteAllText("student.json", json);

        // Read file
        string readJson =
            File.ReadAllText("student.json");

        // JSON -> Object
        Student data =
            JsonSerializer.Deserialize<Student>(readJson);

        Console.WriteLine(data.Name);
    }
}