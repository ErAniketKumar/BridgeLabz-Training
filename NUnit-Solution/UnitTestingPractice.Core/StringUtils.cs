namespace UnitTestingPractice.Core;

public class StringUtils
{
    public string Reverse(string str)
    {
        ArgumentNullException.ThrowIfNull(str);

        return new string(str.Reverse().ToArray());
    }

    public bool IsPalindrome(string str)
    {
        ArgumentNullException.ThrowIfNull(str);

        string normalized = str.Replace(" ", string.Empty, StringComparison.Ordinal).ToUpperInvariant();
        return normalized == Reverse(normalized);
    }

    public string ToUpperCase(string str)
    {
        ArgumentNullException.ThrowIfNull(str);

        return str.ToUpperInvariant();
    }
}
