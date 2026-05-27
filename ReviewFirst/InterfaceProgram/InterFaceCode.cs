namespace ReviewFIRST.InterfaceProgram;

public interface IPayable
{
    double GetSalary();
}

class FullTimeEmployee : IPayable
{
    public double GetSalary()
    {
        return 0;
    }
}

class ContractEmployee : IPayable
{
    public double GetSalary()
    {
        return 0;
    }
}