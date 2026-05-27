public class Publisher2
{
    public event Action<string> OneNotify;

    public void DoWork()
    {
        System.Console.WriteLine("Publisher start working...");

        OneNotify?.Invoke("Done");
    }
}