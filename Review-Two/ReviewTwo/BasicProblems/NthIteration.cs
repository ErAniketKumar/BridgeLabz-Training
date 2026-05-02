public class NthIteration
{
    public void NthIterationPrint(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                System.Console.Write(i);
            }
            System.Console.Write(" ");
        }
    }
}