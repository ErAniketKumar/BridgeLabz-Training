using System.Text.RegularExpressions;

namespace UnitTestingPractice.Core;

public class UserRegistration
{
    private readonly PasswordValidator _passwordValidator = new();

    public bool RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            throw new ArgumentException("Username is required.", nameof(username));
        }

        if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
        {
            throw new ArgumentException("A valid email is required.", nameof(email));
        }

        if (!_passwordValidator.IsValid(password))
        {
            throw new ArgumentException("Password is not strong enough.", nameof(password));
        }

        return true;
    }

    private static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
}
