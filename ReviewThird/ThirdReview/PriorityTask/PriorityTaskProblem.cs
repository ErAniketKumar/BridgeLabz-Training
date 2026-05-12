using System.Reflection;
using System.ComponentModel.DataAnnotations;


[AttributeUsage(AttributeTargets.Method)]
public class TaskInfo : Attribute
{
    public string Priority { get; set; }
    public string AssignedTo { get; set; }

    public TaskInfo(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

public class TaskManager
{


    [TaskInfo("High", "Aniket")]
    void WorkOne()
    {
        System.Console.WriteLine("work one");
    }

    [TaskInfo("Medium", "Kumar")]
    void WorkTwo()
    {
        System.Console.WriteLine("Work two");
    }

    [TaskInfo("Low", "Amit")]
    void WorkThree()
    {
        System.Console.WriteLine("Work three");
    }
    public void PriorityTaskHandlerFun()
    {
        Type type = typeof(TaskManager);
        
        MethodInfo[] methods = type.GetMethods(
        BindingFlags.NonPublic |
        BindingFlags.Instance |
        BindingFlags.DeclaredOnly
        );

        foreach (MethodInfo method in methods)
        {
            TaskInfo taskInfo =
                (TaskInfo)Attribute.GetCustomAttribute(
                    method,
                    typeof(TaskInfo)
                );

            if (taskInfo != null)
            {
                Console.WriteLine($"Method Name : {method.Name}");
                Console.WriteLine($"Priority    : {taskInfo.Priority}");
                Console.WriteLine($"Assigned To : {taskInfo.AssignedTo}");
                Console.WriteLine();
            }
        }
    }
}
