namespace ReviewFIRST.Basic;

public class RandomEven
{
    public void RandomEvenNumber()
    {
        Random random = new Random();

        int num = random.Next(5, 26) * 2;

        System.Console.WriteLine(num);
    }
}