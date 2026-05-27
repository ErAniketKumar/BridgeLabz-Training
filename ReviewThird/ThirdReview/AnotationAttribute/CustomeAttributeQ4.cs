using System;
using System.Reflection;

// Custom Attribute
[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethod : Attribute
{
    public string? Message { get; }

    public ImportantMethod(string? message)
    {
        Message = message;
    }
}

public class CustomeAttributeQ4
{
    [ImportantMethod("HIGH")]
    void Func1()
    {
        Console.WriteLine("Function 1");
    }

    [ImportantMethod("MEDIUM")]
    void Func2(string name)
    {
        Console.WriteLine("Function 2");
        Console.WriteLine(name);
    }

    [ImportantMethod("LOW")]
    void Func3()
    {
        Console.WriteLine("Function 3");
    }

    // Handler Function
    public void CustomeAttriuteHandlerFun()
    {
        Type type = typeof(CustomeAttributeQ4);

        System.Console.WriteLine("type: " + type);

        MethodInfo[] methods = type.GetMethods(

        );

        foreach (MethodInfo method in methods)
        {
            ImportantMethod? attribute =
                method.GetCustomAttribute<ImportantMethod>();

            if (attribute != null)
            {
                Console.WriteLine($"Method Name : {method.Name}");
                Console.WriteLine($"Level       : {attribute.Message}");
                Console.WriteLine();
            }
        }
    }
}