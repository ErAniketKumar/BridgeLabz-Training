namespace UnitTestingPractice.Core;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            return false;
        }

        return password.Any(char.IsUpper) && password.Any(char.IsDigit);
    }
}
