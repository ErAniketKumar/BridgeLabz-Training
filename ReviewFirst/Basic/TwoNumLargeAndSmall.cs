namespace ReviewFIRST.Basic;


public class TwoNumLargeAndSmall
{
    public void LargeSmall(int x, int y)
    {

        if (x > y)
        {
            System.Console.WriteLine($"num1 is large : {x}\nAnd num2 is small {y}");
        }
        else
        {
            System.Console.WriteLine($"num2 is large : {y}\nAnd num1 is small {x}");
        }
    }
}