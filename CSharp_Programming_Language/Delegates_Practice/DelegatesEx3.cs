public class DelegatesEx3
{

    public void BuiltinDelegates()
    {

        // Action: No return value, up to 16 parameters
        Action<string> notification = message => System.Console.WriteLine(message);
        notification("hello alert notification");

        // Func: Returns value, last type parameter is return type
        Func<int, int, int, int> Add = (int x, int y, int z) => x + y + z;
        System.Console.WriteLine(Add(10, 30, 40));

        // Predicate: Returns bool, one parameter

        Predicate<int> IsEven = (int x) => x % 2 == 0;
        System.Console.WriteLine(IsEven(20));

        Action<int, int, string> action = (x, y, msg) => System.Console.WriteLine($"{msg} {x}+{y}={x + y}");

        action(10, 5, "Sum");

    }

}