
public class Closure1
{
    public void OuterFun()
    {
        int count = 0;
        int InnerFun()
        {
            return count++;
        }
        System.Console.WriteLine(InnerFun());
        System.Console.WriteLine(InnerFun());
        System.Console.WriteLine(InnerFun());
    }



    public void OuterFun2()
    {
        int count = 0;
        Func<int> increment = () =>
        {
            // count++;
            return count++;
        };

        System.Console.WriteLine(increment());
        System.Console.WriteLine(increment());
        System.Console.WriteLine(increment());
    }
}

