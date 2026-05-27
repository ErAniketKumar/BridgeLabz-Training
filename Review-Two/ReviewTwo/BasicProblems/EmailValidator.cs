using System.Text.RegularExpressions;
public class EmailValidator
{
    public void IsValidEamilFormat(string email)
    {
        string pattern = @"[\w\.-]+@[\w\.-]+\.\w+";

        System.Console.WriteLine(Regex.IsMatch(email, pattern));
    }
}