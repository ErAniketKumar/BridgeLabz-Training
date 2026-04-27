public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal()
    {

    }
    public Animal(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
    public virtual void MakeSound()
    {
        System.Console.WriteLine("Animal make sound!");
    }
}


public class Dog : Animal
{
    public Dog(string Name, int Age) : base(Name, Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public override void MakeSound()
    {
        System.Console.WriteLine("Dog is barking!");
    }
}


public class Cat : Animal
{
    public Cat(string Name, int Age) : base(Name, Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public override void MakeSound()
    {
        System.Console.WriteLine("Cat miao miao");
    }
}