using NUnit.Framework;

[TestFixture]
public class CalculatorTestNunit
{

    [Test]
    public void TestCalculator()
    {
        CalculatorTest ct = new CalculatorTest();

        int sum = ct.Addition(10, 20);

        int sub = ct.Subtraction(20, 10);

        int mul = ct.Multiplication(5, 10);

        int div = ct.Division(50, 10);


        Assert.That(sum, Is.EqualTo(30));
        Assert.That(sub, Is.EqualTo(10));
        Assert.That(mul, Is.EqualTo(50));
        Assert.That(div, Is.EqualTo(5));

        // Assert.Equals(div, 10);

    }
}