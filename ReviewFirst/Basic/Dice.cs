namespace ReviewFIRST.Basic;

public class Dice
{
    public void DiceThrow()
    {
        Random random = new Random();

        int num = random.Next(1, 7);
        System.Console.WriteLine(num);
    }
}

