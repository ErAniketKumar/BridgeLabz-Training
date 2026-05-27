namespace UnitTestingPractice.Core;

public class NumberUtils
{
    public bool IsEven(int number) => number % 2 == 0;

    public string LongRunningTask()
    {
        Thread.Sleep(TimeSpan.FromSeconds(3));
        return "Completed";
    }
}
