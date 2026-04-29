using UnitTestingPractice.Core;

namespace UnitTestingPractice.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Test]
    public void Add_ReturnsSum()
    {
        Assert.That(_calculator.Add(10, 5), Is.EqualTo(15));
    }

    [Test]
    public void Subtract_ReturnsDifference()
    {
        Assert.That(_calculator.Subtract(10, 5), Is.EqualTo(5));
    }

    [Test]
    public void Multiply_ReturnsProduct()
    {
        Assert.That(_calculator.Multiply(10, 5), Is.EqualTo(50));
    }

    [Test]
    public void Divide_ReturnsQuotient()
    {
        Assert.That(_calculator.Divide(10, 5), Is.EqualTo(2));
    }

    [Test]
    public void Divide_WhenDividingByZero_ThrowsArithmeticException()
    {
        Assert.Throws<ArithmeticException>(() => _calculator.Divide(10, 0));
    }
}

public class StringUtilsTests
{
    private readonly StringUtils _stringUtils = new();

    [Test]
    public void Reverse_ReturnsReversedString()
    {
        Assert.That(_stringUtils.Reverse("hello"), Is.EqualTo("olleh"));
    }

    [TestCase("madam", true)]
    [TestCase("Race car", true)]
    [TestCase("hello", false)]
    public void IsPalindrome_ReturnsExpectedResult(string input, bool expected)
    {
        Assert.That(_stringUtils.IsPalindrome(input), Is.EqualTo(expected));
    }

    [Test]
    public void ToUpperCase_ReturnsUppercaseString()
    {
        Assert.That(_stringUtils.ToUpperCase("hello"), Is.EqualTo("HELLO"));
    }
}

public class ListManagerTests
{
    private readonly ListManager _listManager = new();

    [Test]
    public void AddElement_AddsElementToList()
    {
        List<int> numbers = [1, 2];

        _listManager.AddElement(numbers, 3);

        Assert.That(numbers, Is.EqualTo(new[] { 1, 2, 3 }));
    }

    [Test]
    public void RemoveElement_RemovesElementFromList()
    {
        List<int> numbers = [1, 2, 3];

        bool removed = _listManager.RemoveElement(numbers, 2);

        Assert.Multiple(() =>
        {
            Assert.That(removed, Is.True);
            Assert.That(numbers, Is.EqualTo(new[] { 1, 3 }));
        });
    }

    [Test]
    public void GetSize_ReturnsUpdatedListSize()
    {
        List<int> numbers = [1, 2];

        _listManager.AddElement(numbers, 3);
        _listManager.RemoveElement(numbers, 1);

        Assert.That(_listManager.GetSize(numbers), Is.EqualTo(2));
    }
}

public class DatabaseConnectionTests
{
    private DatabaseConnection _databaseConnection = null!;

    [SetUp]
    public void SetUp()
    {
        _databaseConnection = new DatabaseConnection();
        _databaseConnection.Connect();
    }

    [TearDown]
    public void TearDown()
    {
        _databaseConnection.Disconnect();
        Assert.That(_databaseConnection.IsConnected, Is.False);
    }

    [Test]
    public void SetUp_ConnectsBeforeEachTest()
    {
        Assert.That(_databaseConnection.IsConnected, Is.True);
    }
}

public class NumberUtilsTests
{
    private readonly NumberUtils _numberUtils = new();

    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_ReturnsExpectedResult(int number, bool expected)
    {
        Assert.That(_numberUtils.IsEven(number), Is.EqualTo(expected));
    }

    [Test]
    [Explicit("Demonstrates NUnit Timeout by failing because LongRunningTask sleeps for 3 seconds.")]
    [Timeout(2000)]
    public void LongRunningTask_WithTwoSecondTimeout_FailsWhenRunExplicitly()
    {
        Assert.That(_numberUtils.LongRunningTask(), Is.EqualTo("Completed"));
    }
}

public class FileProcessorTests
{
    private readonly FileProcessor _fileProcessor = new();
    private string _testDirectory = null!;

    [SetUp]
    public void SetUp()
    {
        _testDirectory = Path.Combine(TestContext.CurrentContext.WorkDirectory, "FileProcessorTests");
        Directory.CreateDirectory(_testDirectory);
    }

    [TearDown]
    public void TearDown()
    {
        if (Directory.Exists(_testDirectory))
        {
            Directory.Delete(_testDirectory, recursive: true);
        }
    }

    [Test]
    public void WriteToFile_ThenReadFromFile_ReturnsSameContent()
    {
        string filePath = Path.Combine(_testDirectory, "sample.txt");
        const string content = "NUnit file test";

        _fileProcessor.WriteToFile(filePath, content);
        string result = _fileProcessor.ReadFromFile(filePath);

        Assert.That(result, Is.EqualTo(content));
    }

    [Test]
    public void WriteToFile_CreatesFile()
    {
        string filePath = Path.Combine(_testDirectory, "created.txt");

        _fileProcessor.WriteToFile(filePath, "created");

        Assert.That(File.Exists(filePath), Is.True);
    }

    [Test]
    public void ReadFromFile_WhenFileDoesNotExist_ThrowsIOException()
    {
        string filePath = Path.Combine(_testDirectory, "missing.txt");

        Assert.Throws<IOException>(() => _fileProcessor.ReadFromFile(filePath));
    }
}

public class BankAccountTests
{
    [Test]
    public void Deposit_IncreasesBalance()
    {
        BankAccount account = new(100);

        account.Deposit(50);

        Assert.That(account.GetBalance(), Is.EqualTo(150));
    }

    [Test]
    public void Withdraw_DecreasesBalance()
    {
        BankAccount account = new(100);

        account.Withdraw(40);

        Assert.That(account.GetBalance(), Is.EqualTo(60));
    }

    [Test]
    public void Withdraw_WhenFundsAreInsufficient_ThrowsInvalidOperationException()
    {
        BankAccount account = new(100);

        Assert.Throws<InvalidOperationException>(() => account.Withdraw(150));
    }
}

public class PasswordValidatorTests
{
    private readonly PasswordValidator _validator = new();

    [Test]
    public void IsValid_WithStrongPassword_ReturnsTrue()
    {
        Assert.That(_validator.IsValid("Strong123"), Is.True);
    }

    [TestCase("Short1")]
    [TestCase("lowercase1")]
    [TestCase("NoDigitsHere")]
    [TestCase("")]
    public void IsValid_WithInvalidPassword_ReturnsFalse(string password)
    {
        Assert.That(_validator.IsValid(password), Is.False);
    }
}

public class TemperatureConverterTests
{
    private readonly TemperatureConverter _converter = new();

    [TestCase(0, 32)]
    [TestCase(100, 212)]
    [TestCase(-40, -40)]
    public void CelsiusToFahrenheit_ReturnsExpectedValue(double celsius, double expected)
    {
        Assert.That(_converter.CelsiusToFahrenheit(celsius), Is.EqualTo(expected).Within(0.001));
    }

    [TestCase(32, 0)]
    [TestCase(212, 100)]
    [TestCase(-40, -40)]
    public void FahrenheitToCelsius_ReturnsExpectedValue(double fahrenheit, double expected)
    {
        Assert.That(_converter.FahrenheitToCelsius(fahrenheit), Is.EqualTo(expected).Within(0.001));
    }
}

public class DateFormatterTests
{
    private readonly DateFormatter _formatter = new();

    [Test]
    public void FormatDate_WithValidDate_ReturnsDateInDayMonthYearFormat()
    {
        Assert.That(_formatter.FormatDate("2026-04-29"), Is.EqualTo("29-04-2026"));
    }

    [TestCase("29-04-2026")]
    [TestCase("2026/04/29")]
    [TestCase("not-a-date")]
    public void FormatDate_WithInvalidDate_ThrowsFormatException(string input)
    {
        Assert.Throws<FormatException>(() => _formatter.FormatDate(input));
    }
}

public class UserRegistrationTests
{
    private readonly UserRegistration _registration = new();

    [Test]
    public void RegisterUser_WithValidInputs_ReturnsTrue()
    {
        Assert.That(_registration.RegisterUser("erani", "erani@example.com", "Strong123"), Is.True);
    }

    [TestCase("", "erani@example.com", "Strong123")]
    [TestCase("erani", "invalid-email", "Strong123")]
    [TestCase("erani", "erani@example.com", "weak")]
    public void RegisterUser_WithInvalidInputs_ThrowsArgumentException(
        string username,
        string email,
        string password)
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser(username, email, password));
    }
}
