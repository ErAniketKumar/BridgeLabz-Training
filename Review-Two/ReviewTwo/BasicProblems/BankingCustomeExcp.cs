
public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
        System.Console.WriteLine(message);
    }
}


public class BankingCustomeExcp
{
    public int balance { get; set; }

    public void Deposite(int amt)
    {
        if (amt > 0)
            this.balance = balance;
        else
        {
            System.Console.WriteLine("amount must be positive!");
        }
    }
    public void Withdraw(int amt)
    {
        try
        {
            if (balance < amt)
            {
                throw new InsufficientFundsException("Insufficient balance, withdraw amount must be less euql your balance");
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}