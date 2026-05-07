using System;
using System.IO;
using System.Text.Json;

namespace CSharp_Programming_Language.DesignPrinciple.SRP
{
    // This class has 4 different responsibilities!
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        
        // Responsibility 1: Business logic (calculate bonus)
        public decimal CalculateBonus()
        {
            // Different bonus logic for different departments
            if (Department == "Sales")
                return Salary * 0.2m;
            else if (Department == "Engineering")
                return Salary * 0.15m;
            else
                return Salary * 0.1m;
        }
        
        // Responsibility 2: Database operations
        public void SaveToDatabase()
        {
            try
            {
                // Database connection logic
                Console.WriteLine($"Saving employee {Name} to database...");
                // Assume actual SQL here
                // UPDATE Employees SET ... WHERE Id = ...
                Console.WriteLine("Employee saved successfully!");
            }
            catch (Exception ex)
            {
                // Responsibility 3: Error logging
                File.WriteAllText("error.log", $"{DateTime.Now}: {ex.Message}");
                Console.WriteLine("Error logged to file");
            }
        }
        
        // Responsibility 4: Email sending
        public void SendWelcomeEmail()
        {
            // Email configuration
            string smtpServer = "smtp.company.com";
            int port = 587;
            
            // Building email content
            string subject = "Welcome to the company!";
            string body = $"Dear {Name},\n\nWelcome to our team!";
            
            // Sending logic
            Console.WriteLine($"Sending email to {Email}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Body: {body}");
            
            // Log this action (more responsibilities!)
            File.AppendAllText("email_log.txt", $"{DateTime.Now}: Email sent to {Email}\n");
        }
        
        // Responsibility 5: Report generation
        public string GenerateEmployeeReport()
        {
            // Formatting report
            string report = $"=== Employee Report ===\n";
            report += $"ID: {Id}\n";
            report += $"Name: {Name}\n";
            report += $"Email: {Email}\n";
            report += $"Salary: ${Salary}\n";
            report += $"Department: {Department}\n";
            report += $"Bonus: ${CalculateBonus()}\n";
            report += $"=====================\n";
            
            // Saving report to file (yet another responsibility!)
            File.WriteAllText($"Report_{Id}.txt", report);
            
            return report;
        }
        
        // Responsibility 6: Validation
        public bool ValidateEmployee()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return false;
            if (!Email.Contains("@"))
                return false;
            if (Salary <= 0)
                return false;
            return true;
        }
    }
    
    // Usage
    class Program
    {
        static void Main()
        {
            var emp = new Employee
            {
                Id = 1,
                Name = "John Doe",
                Email = "john@company.com",
                Salary = 50000,
                Department = "Engineering"
            };
            
            // This single class is doing EVERYTHING!
            emp.ValidateEmployee();
            emp.CalculateBonus();
            emp.SaveToDatabase();
            emp.SendWelcomeEmail();
            emp.GenerateEmployeeReport();
        }
    }
}