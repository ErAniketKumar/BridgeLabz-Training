namespace ReviewFIRST.Basic;

public class SwapNumber
{
    public List<int> SwapTwoNum(int x, int y)
    {
        List<int> list = new List<int>();
        x = x + y;
        y = x - y;
        x = x - y;

        list.Add(x);
        list.Add(y);

        return list;
    }
}