using System.Linq.Expressions;

public class LamdbaExp1
{

    void PrintList<T>(List<T> list)
    {
        foreach (var ele in list)
        {
            System.Console.Write(ele + " ");
        }
        System.Console.WriteLine();
    }
    public void LambdaExpressionExample()
    {
        var isOdd = (int x) => x % 2 != 0;
        System.Console.WriteLine(isOdd(5));

        var isEven = (int x) => x % 2 == 0;
        System.Console.WriteLine(isEven(20));

        Func<int, bool> isTrue = (int x) => x > 0;
        System.Console.WriteLine(isTrue(-10));
        List<int> list = new List<int>() { 1, 3, 4, 5, 6, 8, 9, 10, 23, 22, 44, 99 };

        List<int> oddList = list.Where((int ele) => ele % 2 == 1).ToList();
        List<int> evenList = list.Where((int x) => x % 2 == 0).ToList();

        PrintList(oddList);
        PrintList(evenList);

        var sum = list.Aggregate((acc, curr) => acc + curr);

        System.Console.WriteLine(sum);

        List<int> descList = list.OrderBy((num) => (-num)).ToList();

        PrintList(descList);

        List<int> squaresList = list.Select((int x) => x * x).ToList();

        PrintList(squaresList);

    }
}