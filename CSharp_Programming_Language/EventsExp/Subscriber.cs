public class Subscriber
{
    public void ReceivedNotification(string message)
    {
        Console.WriteLine("Subscriber received: " + message);
    }
}