// using System;
// using System.Collections.Generic;


// // This class MUST be modified every time we add a new shape
// public class AreaCalculator
// {
//     public double CalculateArea(object shape)
//     {
//         // Circle check
//         if (shape is Circle circle)
//         {
//             return Math.PI * circle.Radius * circle.Radius;
//         }
//         // Rectangle check
//         else if (shape is Rectangle rectangle)
//         {
//             return rectangle.Width * rectangle.Height;
//         }
//         // Triangle - OH NO! We have to MODIFY this method!
//         else if (shape is Triangle triangle)
//         {
//             return (triangle.Base * triangle.Height) / 2;
//         }
//         // Square - Have to modify again!
//         else if (shape is Square square)
//         {
//             return square.Side * square.Side;
//         }
//         // Every new shape requires a new if statement here!

//         throw new ArgumentException("Unknown shape");
//     }
// }

// public class Circle
// {
//     public double Radius { get; set; }
// }

// public class Rectangle
// {
//     public double Width { get; set; }
//     public double Height { get; set; }
// }

// public class Triangle
// {
//     public double Base { get; set; }
//     public double Height { get; set; }
// }

// public class Square
// {
//     public double Side { get; set; }
// }

// // Usage
// class Program
// {
//     static void Main()
//     {
//         var calculator = new AreaCalculator();

//         var shapes = new List<object>
//             {
//                 new Circle { Radius = 5 },
//                 new Rectangle { Width = 4, Height = 6 },
//                 new Triangle { Base = 3, Height = 4 },
//                 new Square { Side = 5 }
//             };

//         foreach (var shape in shapes)
//         {
//             var area = calculator.CalculateArea(shape);
//             Console.WriteLine($"Area: {area}");
//         }
//     }
// }
