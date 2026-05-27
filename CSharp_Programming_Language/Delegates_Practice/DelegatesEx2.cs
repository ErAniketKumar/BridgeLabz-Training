

public class DelegatesEx2
{

    public delegate void NotificationHandler(string message);

    public void LogToConsole(string message)
    {
        System.Console.WriteLine($"{message}");
    }
    public void LogToFile(string msg)
    {
        File.AppendAllText("log.txt", msg + "\n");
    }
    public void SendEmail(string msg)
    {
        Console.WriteLine($"Email: {msg}");
    }

    public void DemonstrateMulticast()
    {
        NotificationHandler handler = LogToConsole;

        handler += SendEmail;
        handler += LogToFile;
        handler -= SendEmail;
        handler("System started");
    }
}
