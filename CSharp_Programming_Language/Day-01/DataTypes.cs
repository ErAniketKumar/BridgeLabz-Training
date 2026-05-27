using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace CSharp_Programming_Language.Day_01
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    // Enum definition
    enum Days
    {
        Monday,     // 0
        Tuesday,    // 1
        Wednesday,  // 2
        Thursday,   // 3
        Friday,     // 4
        Saturday,   // 5
        Sunday      // 6
    }

    // Class definition
    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }
    }

    internal class DataTypes
    {
      internal void DType()
        {
            int number = 10;           // 32-bit integer
            float price = 99.99f;      // 32-bit floating point
            double pi = 3.14159;       // 64-bit floating point
            decimal salary = 50000.50m; // 128-bit precise decimal
            bool isActive = true;       // Boolean
            char grade = 'A';           // Single character
            byte level = 255;           // 8-bit unsigned integer
            short count = 32000;        // 16-bit integer
            long population = 7800000000L; // 64-bit integer

            char ch = 'A';

            Console.WriteLine(ch.GetType());

            // REFERENCE TYPES - Stored on Heap (reference on Stack)
            string name = "John Doe";    // String
            object obj = new object();    // Object
            int[] array = new int[5];    // Array
            Person person = new Person(); // Custom class

            // DEMONSTRATING THE DIFFERENCE
            Console.WriteLine("=== Value Types vs Reference Types ===");

            // Value Type - Creates a COPY
            int originalValue = 42;
            int copiedValue = originalValue;  // Copies the value
            copiedValue = 100;
            Console.WriteLine($"Original: {originalValue}, Copied: {copiedValue}"); // Original unchanged

            // Reference Type - Shares REFERENCE
            Person originalPerson = new Person { Name = "Alice", Age = 30 };
            Person copiedPerson = originalPerson;  // Copies the reference
            copiedPerson.Name = "Bob";
            Console.WriteLine($"Original Name: {originalPerson.Name}"); // Changed to "Bob"



            // non prevetive data types

            // 1. STRINGS
            Console.WriteLine("=== STRINGS ===");
            string str1 = "Hello";
            string str2 = "World";
            string concatenated = str1 + " " + str2;
            Console.WriteLine($"Concatenated: {concatenated}");

            // String interpolation
            string nameA = "Alice";
            int age = 25;
            string message = $"My name is {name} and I'm {age} years old";
            Console.WriteLine(message);

            // Verbatim strings (ignore escape sequences)
            string path = @"C:\Users\Documents\file.txt";
            string multiLine = @"Line 1 
Line 2
Line 3";
            Console.WriteLine($"Path: {path}");
            Console.WriteLine($"Multi-line:\n{multiLine}");

            // 2. ARRAYS
            Console.WriteLine("\n=== ARRAYS ===");

            // Single-dimensional array
            int[] numbers = new int[5];  // Declaration with size
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            // Array initialization
            int[] initialized = new int[] { 1, 2, 3, 4, 5 };
            string[] names = { "John", "Jane", "Bob" };

            // Multi-dimensional array (rectangular)
            int[,] matrix = new int[3, 4];  // 3 rows, 4 columns
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;

            int[,] predefined = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            // Jagged array (array of arrays)
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 3, 4, 5 };
            jagged[2] = new int[] { 6, 7, 8, 9 };

            // 3. STRUCTS (Value Type)
            Console.WriteLine("\n=== STRUCTS ===");
            Point p1 = new Point(10, 20);
            Point p2 = p1;  // Creates a copy
            p2.X = 100;
            Console.WriteLine($"p1: ({p1.X}, {p1.Y})");  // Still (10, 20)
            Console.WriteLine($"p2: ({p2.X}, {p2.Y})");  // (100, 20)

            // 4. ENUMS
            Console.WriteLine("\n=== ENUMS ===");
            Days today = Days.Wednesday;
            Console.WriteLine($"Today is {today}");
            Console.WriteLine($"Value: {(int)today}");

            // 5. CLASSES (Reference Type)
            Console.WriteLine("\n=== CLASSES ===");
            Car car1 = new Car("Toyota", 2022);
            Car car2 = car1;  // References same object
            car2.Model = "Honda";
            Console.WriteLine($"car1 model: {car1.Model}");  // Changed to Honda
        }
    }
}
