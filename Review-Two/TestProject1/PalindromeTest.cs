namespace TestProject1;

[TestFixture]
public class PalindromeTest
{
    [Test]
    public void TestPalindromeValid()
    {
        PalindromeChecker checker = new PalindromeChecker();
        bool result = checker.CheckPalindrome("racecar");
        Assert.That(result, Is.True);
    }

    [Test]
    public void TestPalindromeNotValid()
    {
        var checker = new PalindromeChecker();
        bool result = checker.CheckPalindrome("hello");
        Assert.That(result, Is.False);
    }
}

