namespace ReviewFIRST.Basic;

public class ArmStrongNum
{
    public bool CheckArmStrongNum(int num)
    {
        int temp = num;
        List<int> list = new List<int>();

        int countDigit = 0;
        while (temp > 0)
        {
            list.Add(temp % 10);
            countDigit++;
            temp /= 10;
        }

        int powSum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            powSum += Convert.ToInt32(Math.Pow(list[i], countDigit));
        }
        return powSum == num;
    }
}