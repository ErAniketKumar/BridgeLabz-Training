using CSharp_Programming_Language.Day_01;
using CSharp_Programming_Language.Day_02;
using CSharp_Programming_Language.Day_03;
using CSharp_Programming_Language.Ladder_Snake_Game;
using CSharp_Programming_Language.Linkedlist;


//Operators oprator = new Operators();

//DataTypes datatype = new DataTypes();


//oprator.OperatorsFun();
//datatype.DType();

//ArrayMethod arraymethod = new ArrayMethod();

//arraymethod.ArrayOperation();

//StringOpr stringopr = new StringOpr();

//stringopr.StringMethod();

//MultiDimensionArray multiarray = new MultiDimensionArray();

//multiarray.MultiDArray();

// GameScore gc = new GameScore();

// gc.GameLogic();





// LinkedlistImplementation linkedlist = new LinkedlistImplementation();

// int n = Convert.ToInt32(Console.ReadLine());


// for (int i = 0; i < n; i++)
// {
//     int data = Convert.ToInt32(Console.ReadLine());
//     // linkedlist.IntertAtEnd(data);
//     linkedlist.IntertAtHead(data);
// }

// Node head = linkedlist.GetHead();
// linkedlist.PrintLinkedList(head);

StudentInformation student = new StudentInformation();
int n = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < n; i++)
{
    System.Console.WriteLine("Enter Name!");
    string name = Console.ReadLine();
    System.Console.WriteLine("Enter Age!");
    int age = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Enter RollNumber");
    int rollnumber = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Enter Grade!");
    char grade = Convert.ToChar(Console.ReadLine());

    student.AddStudentAtBegin(rollnumber, name, age, grade);
}

Student node = student.GetStudentNode();

student.PrintStudentsDetails(node);
student.FindStudentDetailByRollNumber(1054);

student.UpdateStudentDetaiByRollNumber(1054);

student.PrintStudentsDetails(student.GetStudentNode());



