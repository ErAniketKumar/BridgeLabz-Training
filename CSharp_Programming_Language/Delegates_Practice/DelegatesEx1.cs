// declare
public delegate int MathOperation(int x, int y);

public class DelegatesEx1
{
    public int Add(int x, int y) => x + y;
    public int Sub(int x, int y) => x - y;
    public int Mul(int x, int y) => x * y;

    public void DeligatesDemostrate()
    {
        MathOperation operation = Add;

        System.Console.WriteLine(operation(10, 5));

        operation = Mul;
        System.Console.WriteLine(operation(10, 5));
        operation = Sub;
        System.Console.WriteLine(operation(10, 5));
    }
}