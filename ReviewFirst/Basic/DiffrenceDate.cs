
namespace ReviewFIRST.Basic;

public class DiffrenceDate
{
    public TimeSpan DateTimeDiff(DateTime d1, DateTime d2)
    {
        TimeSpan diff = d1 - d2;
        return diff;
    }
}