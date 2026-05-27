namespace ReviewFIRST.Basic;

public class AddDate
{
    public void DateAdd()
    {
        DateTime dateTime = DateTime.Now;

        System.Console.WriteLine(dateTime.AddDays(30));

        System.Console.WriteLine(dateTime.AddMonths(-6));
        System.Console.WriteLine(dateTime.AddYears(1));
    }
}