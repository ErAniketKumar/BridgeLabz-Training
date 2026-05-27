// using System;
// using System.IO;
// using System.Collections.Generic;

// namespace CSharp_Programming_Language.DesignPrinciple.SRP
// {
//     // 1. Entity class - ONLY holds data
//     public class EmployeeG
//     {
//         public int Id { get; set; }
//         public string Name { get; set; }
//         public string Email { get; set; }
//         public decimal Salary { get; set; }
//         public string Department { get; set; }
//     }

//     // 2. Business logic - ONLY calculates bonuses
//     public class BonusCalculator
//     {
//         public decimal CalculateBonus(EmployeeG employeeG)
//         {
//             if (employeeG == null)
//                 throw new ArgumentNullException(nameof(employeeG));

//             switch (employeeG.Department)
//             {
//                 case "Sales":
//                     return employeeG.Salary * 0.2m;
//                 case "Engineering":
//                     return employeeG.Salary * 0.15m;
//                 default:
//                     return employeeG.Salary * 0.1m;
//             }
//         }
//     }

//     // 3. Data persistence - ONLY database operations
//     public class EmployeeGRepository
//     {
//         private readonly List<EmployeeG> _database = new List<EmployeeG>();

//         public void Save(EmployeeG employeeG)
//         {
//             _database.Add(employeeG);
//             Console.WriteLine($"Saved: {employeeG.Name}");
//         }

//         public EmployeeG FindById(int id)
//         {
//             return _database.Find(e => e.Id == id);
//         }

//         public void Delete(int id)
//         {
//             var emp = FindById(id);
//             if (emp != null)
//                 _database.Remove(emp);
//         }
//     }

//     // 4. Email service - ONLY email operations
//     public class EmailService
//     {
//         private readonly string _smtpServer;
//         private readonly int _port;

//         public EmailService(string smtpServer = "smtp.company.com", int port = 587)
//         {
//             _smtpServer = smtpServer;
//             _port = port;
//         }

//         public void SendWelcomeEmail(EmployeeG employeeG)
//         {
//             if (string.IsNullOrWhiteSpace(employeeG.Email))
//                 throw new ArgumentException("Email is required");

//             var subject = "Welcome to the company!";
//             var body = $"Dear {employeeG.Name},\n\nWelcome to our team!";

//             // Actual email sending logic
//             Console.WriteLine($"Sending email to {employeeG.Email}");
//             Console.WriteLine($"Using SMTP: {_smtpServer}:{_port}");
//             Console.WriteLine($"Subject: {subject}");
//             Console.WriteLine($"Body: {body}\n");
//         }

//         public void SendNotification(EmployeeG employeeG, string message)
//         {
//             Console.WriteLine($"Notification to {employeeG.Email}: {message}");
//         }
//     }

//     // 5. Report generation - ONLY report operations
//     public class ReportGenerator
//     {
//         private readonly BonusCalculator _bonusCalculator;

//         public ReportGenerator(BonusCalculator bonusCalculator)
//         {
//             _bonusCalculator = bonusCalculator;
//         }

//         public string GenerateEmployeeGReport(EmployeeG employeeG)
//         {
//             var bonus = _bonusCalculator.CalculateBonus(employeeG);

//             var report = new System.Text.StringBuilder();
//             report.AppendLine("=== EmployeeG Report ===");
//             report.AppendLine($"ID: {employeeG.Id}");
//             report.AppendLine($"Name: {employeeG.Name}");
//             report.AppendLine($"Email: {employeeG.Email}");
//             report.AppendLine($"Salary: ${employeeG.Salary:N2}");
//             report.AppendLine($"Department: {employeeG.Department}");
//             report.AppendLine($"Bonus: ${bonus:N2}");
//             report.AppendLine("=====================");

//             return report.ToString();
//         }

//         public void SaveReportToFile(EmployeeG employeeG, string filePath)
//         {
//             var report = GenerateEmployeeGReport(employeeG);
//             File.WriteAllText(filePath, report);
//             Console.WriteLine($"Report saved to {filePath}");
//         }
//     }

//     // 6. Validation - ONLY validation rules
//     public class EmployeeGValidator
//     {
//         public bool IsValid(EmployeeG employeeG, out List<string> errors)
//         {
//             errors = new List<string>();

//             if (employeeG == null)
//             {
//                 errors.Add("EmployeeG cannot be null");
//                 return false;
//             }

//             if (string.IsNullOrWhiteSpace(employeeG.Name))
//                 errors.Add("Name is required");

//             if (string.IsNullOrWhiteSpace(employeeG.Email) || !employeeG.Email.Contains("@"))
//                 errors.Add("Valid email is required");

//             if (employeeG.Salary <= 0)
//                 errors.Add("Salary must be greater than 0");

//             if (string.IsNullOrWhiteSpace(employeeG.Department))
//                 errors.Add("Department is required");

//             return errors.Count == 0;
//         }
//     }

//     // 7. Orchestrator - brings everything together (still has single responsibility: process new employeeG)
//     public class EmployeeGOnboardingService
//     {
//         private readonly EmployeeGValidator _validator;
//         private readonly EmployeeGRepository _repository;
//         private readonly EmailService _emailService;
//         private readonly BonusCalculator _bonusCalculator;
//         private readonly ReportGenerator _reportGenerator;

//         public EmployeeGOnboardingService(
//             EmployeeGValidator validator,
//             EmployeeGRepository repository,
//             EmailService emailService,
//             BonusCalculator bonusCalculator,
//             ReportGenerator reportGenerator)
//         {
//             _validator = validator;
//             _repository = repository;
//             _emailService = emailService;
//             _bonusCalculator = bonusCalculator;
//             _reportGenerator = reportGenerator;
//         }

//         public void OnboardNewEmployeeG(EmployeeG employeeG)
//         {
//             // Validate
//             if (!_validator.IsValid(employeeG, out var errors))
//             {
//                 Console.WriteLine("Validation failed:");
//                 foreach (var error in errors)
//                     Console.WriteLine($"- {error}");
//                 return;
//             }

//             // Calculate bonus (just to show during onboarding)
//             var bonus = _bonusCalculator.CalculateBonus(employeeG);
//             Console.WriteLine($"Calculated bonus: ${bonus:N2}");

//             // Save to database
//             _repository.Save(employeeG);

//             // Send welcome email
//             _emailService.SendWelcomeEmail(employeeG);

//             // Generate report
//             var report = _reportGenerator.GenerateEmployeeGReport(employeeG);
//             Console.WriteLine(report);

//             Console.WriteLine($"EmployeeG {employeeG.Name} onboarded successfully!\n");
//         }
//     }

//     // Usage
//     class Program
//     {
//         static void Main()
//         {
//             // Create instances of each specialized class
//             var validator = new EmployeeGValidator();
//             var repository = new EmployeeGRepository();
//             var emailService = new EmailService();
//             var bonusCalculator = new BonusCalculator();
//             var reportGenerator = new ReportGenerator(bonusCalculator);

//             // Create orchestrator
//             var onboarding = new EmployeeGOnboardingService(
//                 validator, repository, emailService, bonusCalculator, reportGenerator);

//             // Create employeeG
//             var employeeG = new EmployeeG
//             {
//                 Id = 1,
//                 Name = "Jane Smith",
//                 Email = "jane@company.com",
//                 Salary = 75000,
//                 Department = "Sales"
//             };

//             // Onboard (everything works together but each class has single responsibility)
//             onboarding.OnboardNewEmployeeG(employeeG);

//             // Now each class can be used independently
//             // 1. Just validate an employeeG
//             bool isValid = validator.IsValid(employeeG, out _);

//             // 2. Just send an email
//             emailService.SendNotification(employeeG, "Your profile has been updated");

//             // 3. Just generate a report
//             string report = reportGenerator.GenerateEmployeeGReport(employeeG);

//             // 4. Just calculate bonus
//             decimal bonus = bonusCalculator.CalculateBonus(employeeG);
//         }
//     }
// }