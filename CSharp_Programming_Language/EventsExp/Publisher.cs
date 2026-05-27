public class Publisher
{
    public delegate void Notify(string message);

    public event Notify OneNotify;

    public void DoSomthing()
    {
        System.Console.WriteLine("Publisher start working");
        
        OneNotify?.Invoke("Work Complete");
    }
}