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

// StudentInformation student = new StudentInformation();
// int n = Convert.ToInt32(Console.ReadLine());


// for (int i = 0; i < n; i++)
// {
//     System.Console.WriteLine("Enter Name!");
//     string name = Console.ReadLine();
//     System.Console.WriteLine("Enter Age!");
//     int age = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Enter RollNumber");
//     int rollnumber = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Enter Grade!");
//     char grade = Convert.ToChar(Console.ReadLine());

//     student.AddStudentAtBegin(rollnumber, name, age, grade);
// }

// Student node = student.GetStudentNode();

// student.PrintStudentsDetails(node);
// student.FindStudentDetailByRollNumber(1054);

// student.UpdateStudentDetaiByRollNumber(1054);

// student.PrintStudentsDetails(student.GetStudentNode());




// DelegatesEx1 delegatesEx1 = new DelegatesEx1();
// delegatesEx1.DeligatesDemostrate();

// DelegatesEx2 delegatesEx2 = new DelegatesEx2();

// delegatesEx2.DemonstrateMulticast();

// DelegatesEx3 delegatesEx3 = new DelegatesEx3();
// delegatesEx3.BuiltinDelegates();

// LamdbaExp1 lamdbaExp1 = new LamdbaExp1();

// lamdbaExp1.LambdaExpressionExample();

// Closure1 closure1 = new Closure1();

// closure1.OuterFun();

// closure1.OuterFun2();


// Publisher publisher = new Publisher();
// Subscriber subscriber = new Subscriber();

// publisher.OneNotify += subscriber.ReceivedNotification;

// publisher.DoSomthing();

// Publisher2 publisher2 = new Publisher2();








// Console.WriteLine("=== OCP Demo - Shapes ===");
// var calculator = new AreaCalculator();

// var shapes = new List<IShape>
//             {
//                 new Circle { Radius = 5 },
//                 new Rectangle { Width = 4, Height = 6 },
//                 new Triangle { Base = 3, Height = 4 },
//                 new Square { Side = 5 },
//                 new Pentagon { Side = 4 }  // Added without modifying any existing code!
//             };

// foreach (var shape in shapes)
// {
//     Console.WriteLine($"{shape.GetType().Name} area: {calculator.CalculateArea(shape):F2}");
// }

// Console.WriteLine($"\nTotal area: {calculator.CalculateTotalArea(shapes):F2}");

// Console.WriteLine("\n=== OCP Demo - Discount Strategies ===");
// var product = new Product
// {
//     Name = "Laptop",
//     Price = 1000m,
//     DiscountStrategy = new PercentageDiscountStrategy(20)
// };

// Console.WriteLine($"Product: {product.Name}");
// Console.WriteLine($"Original price: ${product.Price}");
// Console.WriteLine($"Strategy: {product.DiscountStrategy.StrategyName}");
// Console.WriteLine($"Final price: ${product.GetFinalPrice()}");

// // Change strategy dynamically - OCP allows this!
// product.DiscountStrategy = new SeasonalDiscountStrategy();
// Console.WriteLine($"\nNew strategy: {product.DiscountStrategy.StrategyName}");
// Console.WriteLine($"Final price: ${product.GetFinalPrice()}");

// // Add loyalty discount - new class, no existing code changes
// product.DiscountStrategy = new LoyaltyPointsDiscountStrategy(250);
// Console.WriteLine($"\nLoyalty strategy: {product.DiscountStrategy.StrategyName}");
// Console.WriteLine($"Final price: ${product.GetFinalPrice()}");

// Console.WriteLine("\n=== OCP Demo - Specification Pattern ===");
// var products = new List<Product>
//             {
//                 new Product { Name = "HP Laptop", Price = 800m },
//                 new Product { Name = "Dell Laptop", Price = 1200m },
//                 new Product { Name = "MacBook Pro", Price = 1500m },
//                 new Product { Name = "Lenovo Mouse", Price = 30m }
//             };

// var filter = new ProductFilter();
// var priceSpec = new PriceSpecification(500, 1000);
// var nameSpec = new NameContainsSpecification("laptop");
// var combinedSpec = new AndSpecification<Product>(priceSpec, nameSpec);

// Console.WriteLine("Laptops between $500-$1000:");
// foreach (var p in filter.Filter(products, combinedSpec))
// {
//     Console.WriteLine($"- {p.Name}: ${p.Price}");
// }


// DirectoryHandling directoryHandling = new DirectoryHandling();
// directoryHandling.DirFileOpr();

FileHandling fileHandling = new FileHandling();

fileHandling.FileHandlingOpr();
