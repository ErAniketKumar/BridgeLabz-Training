using System.Runtime.ConstrainedExecution;

namespace CSharp_Programming_Language.Linkedlist
{

    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public char Grade { get; set; }
        public Student next;

        public Student(int RollNumber, string Name, int Age, char Grade)
        {
            this.RollNumber = RollNumber;
            this.Name = Name;
            this.Age = Age;
            this.Grade = Grade;
            this.next = null;
        }
    }
    public class StudentInformation
    {
        Student head;

        public void AddStudentAtEnd(int RollNumber, string Name, int Age, char Grade)
        {
            Student new_student = new Student(RollNumber, Name, Age, Grade);

            if (head == null)
            {
                head = new_student;
                return;
            }

            Student temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new_student;
            return;
        }

        public void AddStudentAtBegin(int RollNumber, string Name, int Age, char Grade)
        {
            Student new_student = new Student(RollNumber, Name, Age, Grade);

            if (head == null)
            {
                head = new_student;
                return;
            }
            new_student.next = head;
            head = new_student;
            return;
        }

        public void FindStudentDetailByRollNumber(int RollNumber)
        {
            Student temp = head;

            while (temp != null)
            {
                if (temp.RollNumber == RollNumber)
                {
                    System.Console.WriteLine($"Name: {temp.Name}\nAge: {temp.Age}\nRollNumber: {temp.RollNumber}\nGrade: {temp.Grade}");
                    return;
                }
                temp = temp.next;
            }
        }

        public void DeleteStudentDetaiByRollNumber(int RollNumber)
        {
            Student temp = head;

            while (temp != null)
            {
                if (temp.next.RollNumber == RollNumber)
                {
                    break;
                }
                temp = temp.next;
            }
            temp.next = temp.next.next;
        }

        public void UpdateStudentDetaiByRollNumber(int RollNumber)
        {
            Student temp = head;
            while (temp != null)
            {
                if (temp.RollNumber == RollNumber)
                {
                    System.Console.WriteLine("enter name");
                    string name = Console.ReadLine();
                    System.Console.WriteLine("enter age");
                    int age = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("enter grade");
                    char grade = Convert.ToChar(Console.ReadLine());

                    temp.Name = name != "" ? name : temp.Name;
                    temp.Age = age != 0 ? age : temp.Age;
                    temp.Grade = grade != '\n' ? grade : temp.Grade;
                    System.Console.WriteLine("updated successfully!");
                    System.Console.WriteLine($"Name: {temp.Name}\nAge: {temp.Age}\nRollNumber: {temp.RollNumber}\nGrade: {temp.Grade}");
                    return;
                }

                temp = temp.next;
            }
        }

        public Student GetStudentNode()
        {
            return this.head;
        }

        public void PrintStudentsDetails(Student node)
        {
            while (node != null)
            {
                System.Console.WriteLine($"Name: {node.Name}\nAge: {node.Age}\nRollNumber: {node.RollNumber}\nGrade: {node.Grade}");
                node = node.next;
            }
        }
        
    }
}