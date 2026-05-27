public class EmailService()
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Email Sent: " + message);
    }

}


public class SmsService()
{
    public void SendSms(string message)
    {
        Console.WriteLine("Sms Sent: " + message);
    }
}