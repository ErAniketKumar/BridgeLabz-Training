public class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string Name, int Id)
    {
        this.Name = Name;
        this.Id = Id;
    }

}


public interface Worker
{
    void PerformDuties();
}
public class Chef : Person, Worker
{
    public Chef(string Name, int Id) : base(Name, Id)
    {
        this.Name = Name;
        this.Id = Id;
    }
    public void PerformDuties()
    {
        System.Console.WriteLine($"Chef  {this.Name}  and id: {this.Id} is cooking delicious food");
    }

}

public class Waiter : Person, Worker
{
    public Waiter(string Name, int Id) : base(Name, Id)
    {
        this.Name = Name;
        this.Id = Id;
    }
    public void PerformDuties()
    {

        System.Console.WriteLine($"Waiter {this.Name}  and id: {this.Id} is serving customers");
    }

}

