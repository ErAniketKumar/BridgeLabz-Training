namespace UnitTestingPractice.Core;

public class BankAccount
{
    private double _balance;

    public BankAccount(double openingBalance = 0)
    {
        if (openingBalance < 0)
        {
            throw new ArgumentException("Opening balance cannot be negative.", nameof(openingBalance));
        }

        _balance = openingBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
        }

        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.", nameof(amount));
        }

        if (amount > _balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        _balance -= amount;
    }

    public double GetBalance() => _balance;
}
