using System;
using System.Reflection;

// Custom Attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class BugReport : Attribute
{
    public string Description { get; set; }

    public BugReport(string description)
    {
        Description = description;
    }
}

public class BugReportQ3
{
    // Applying attribute multiple times
    [BugReport("Button is not working")]
    [BugReport("UI alignment issue")]
    public void BugReportPrint()
    {
        Console.WriteLine("Print all bug reports");
    }

    public void ShowBugReports()
    {
        Type type = typeof(BugReportQ3);

        MethodInfo method =
            type.GetMethod(
                "BugReportPrint",
                BindingFlags.Public |
                BindingFlags.Instance
            );

        // Get ALL BugReport attributes
        object[] bugReports =
            method.GetCustomAttributes(
                typeof(BugReport),
                false
            );

        foreach (BugReport bug in bugReports)
        {
            Console.WriteLine($"Bug Description : {bug.Description}");
        }
    }
}