public class LambdaEvolution
{
    public void ShowEvolution()
    {
        // C# 1.0: Explicit delegate
        Func<int, int, int> add1 = delegate (int a, int b) { return a + b; };

        // C# 2.0: Anonymous method with simplified syntax
        Func<int, int, int> add2 = delegate (int a, int b) { return a + b; };

        // C# 3.0+: Lambda expressions
        Func<int, int, int> add3 = (int a, int b) => { return a + b; };

        // Even simpler: type inference
        Func<int, int, int> add4 = (a, b) => a + b;

        // Single parameter: parentheses optional
        Func<int, int> square = x => x * x;

        // No parameters: empty parentheses
        Action greet = () => Console.WriteLine("Hello");

        // Statement lambda (multiple lines)
        Func<int, int, int> complexOperation = (a, b) =>
        {
            int temp = a * b;
            int result = temp + (a - b);
            return result;
        };
    }
}