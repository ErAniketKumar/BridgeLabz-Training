using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Programming_Language.Day_01
{
    class PersonB
    {
        public string Name { get; set; }
    }
    internal class Operators
    {
        internal void OperatorsFun()
        {
            // 1. ARITHMETIC OPERATORS
            Console.WriteLine("=== ARITHMETIC OPERATORS ===");
            int a = 10, b = 3;
            Console.WriteLine($"Addition: {a} + {b} = {a + b}");        // 13
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");      // 7
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");   // 30
            Console.WriteLine($"Division: {a} / {b} = {a / b}");         // 3 (integer division)
            Console.WriteLine($"Modulus: {a} % {b} = {a % b}");          // 1 (remainder)

            // Division with doubles
            double x = 10.0, y = 3.0;
            Console.WriteLine($"Double division: {x} / {y} = {x / y}");  // 3.333...

            // Increment/Decrement
            int counter = 5;
            Console.WriteLine($"Original: {counter}");
            Console.WriteLine($"Post-increment: {counter++}");  // Returns 5, then increments to 6
            Console.WriteLine($"After post-increment: {counter}");
            Console.WriteLine($"Pre-increment: {++counter}");   // Increments to 7, then returns 7

            // 2. ASSIGNMENT OPERATORS
            Console.WriteLine("\n=== ASSIGNMENT OPERATORS ===");
            int num = 10;
            Console.WriteLine($"Initial: {num}");

            num += 5;  // num = num + 5
            Console.WriteLine($"After += 5: {num}");

            num -= 3;  // num = num - 3
            Console.WriteLine($"After -= 3: {num}");

            num *= 2;  // num = num * 2
            Console.WriteLine($"After *= 2: {num}");

            num /= 4;  // num = num / 4
            Console.WriteLine($"After /= 4: {num}");

            num %= 3;  // num = num % 3
            Console.WriteLine($"After %= 3: {num}");

            // 3. COMPARISON OPERATORS
            Console.WriteLine("\n=== COMPARISON OPERATORS ===");
            int p = 10, q = 20;
            Console.WriteLine($"p = {p}, q = {q}");
            Console.WriteLine($"p == q: {p == q}");   // Equal to
            Console.WriteLine($"p != q: {p != q}");   // Not equal to
            Console.WriteLine($"p > q: {p > q}");     // Greater than
            Console.WriteLine($"p < q: {p < q}");     // Less than
            Console.WriteLine($"p >= q: {p >= q}");   // Greater than or equal
            Console.WriteLine($"p <= q: {p <= q}");   // Less than or equal

            // 4. LOGICAL OPERATORS
            Console.WriteLine("\n=== LOGICAL OPERATORS ===");
            bool isAdult = true;
            bool hasLicense = false;

            Console.WriteLine($"isAdult && hasLicense: {isAdult && hasLicense}");  // AND - both must be true
            Console.WriteLine($"isAdult || hasLicense: {isAdult || hasLicense}");  // OR - at least one true
            Console.WriteLine($"!isAdult: {!isAdult}");  // NOT - reverses boolean

            // Short-circuit evaluation
            Console.WriteLine("\nShort-circuit evaluation:");
            int value = 10;
            bool result = (value > 5) && (++value > 10);
            Console.WriteLine($"Result: {result}, Value: {value}");  // Second expression NOT evaluated

            // 5. BITWISE OPERATORS
            Console.WriteLine("\n=== BITWISE OPERATORS ===");
            int m = 12;  // Binary: 1100
            int n = 10;  // Binary: 1010

            Console.WriteLine($"~m = {~m} (Binary: {Convert.ToString(~m, 2)}");  // NOT
            Console.WriteLine($"m << 2 = {m << 2}");  // Left shift: 110000 (48)
            Console.WriteLine($"m >> 2 = {m >> 2}");  // Right shift: 11 (3)

            // 6. TERNARY OPERATOR (Conditional)
            Console.WriteLine("\n=== TERNARY OPERATOR ===");
            int age = 18;
            string status = (age >= 18) ? "Adult" : "Minor";
            Console.WriteLine($"Age {age}: {status}");

            // Nested ternary (use sparingly)
            int score = 85;
            string grade = (score >= 90) ? "A" : (score >= 80) ? "B" : (score >= 70) ? "C" : "F";
            Console.WriteLine($"Score {score}: Grade {grade}");

            // 7. NULL COALESCING OPERATOR (??)
            Console.WriteLine("\n=== NULL COALESCING OPERATOR ===");
            string name = null;
            string displayName = name ?? "Guest";  // If name is null, use "Guest"
            Console.WriteLine($"Display Name: {displayName}");

            string userName = "John";
            string displayUser = userName ?? "Guest";
            Console.WriteLine($"Display User: {displayUser}");

            // 8. NULL CONDITIONAL OPERATOR (?.)
            Console.WriteLine("\n=== NULL CONDITIONAL OPERATOR ===");
            PersonB person = null;
            int? length = person?.Name?.Length;  // Returns null instead of throwing exception
            Console.WriteLine($"Name length: {length?.ToString() ?? "null"}");

            PersonB person2 = new PersonB { Name = "Alice" };
            int length2 = person2?.Name?.Length ?? 0;
            Console.WriteLine($"Name length: {length2}");

            // 9. TYPE TESTING OPERATORS
            Console.WriteLine("\n=== TYPE TESTING OPERATORS ===");
            object obj = "Hello";

            // 'is' operator
            bool isString = obj is string;
            Console.WriteLine($"obj is string: {isString}");

            // 'as' operator (safe casting)
            string str = obj as string;
            Console.WriteLine($"Cast result: {str ?? "null"}");

            // Type check with pattern matching
            if (obj is string s)
            {
                Console.WriteLine($"Pattern matching: {s.Length}");
            }
        }
    }
}
