using System.Text.RegularExpressions;

public class PasswordSraingthChecker
{
    public void PasswordCheck(string pass)
    {
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&^#()[\]{}|\\/\-+_.:;=,~`])[^\s<>]{8,}$";

        System.Console.WriteLine(Regex.IsMatch(pass, pattern));

    }
}