
public class TimeSlotCalculator
{
    public void Appointments(List<List<int>> list)
    {
        List<List<int>> available = new List<List<int>>();

        for (int i = 0; i < list.Count; i++)
        {
            List<int> time = list[i];

            if (i == 0)
            {
                available.Add([0, time[0]]);
            }
            else
            {
                List<int> prev = list[i - 1];
                available.Add([prev[1], time[0]]);
            }
        }

        if (list[list.Count - 1][1] != 24)
        {
            int lastidx = list.Count - 1;
            available.Add([list[lastidx][1], 24]);
        }


        for (int i = 0; i < available.Count; i++)
        {
            System.Console.WriteLine(available[i][0] + " " + available[i][1]);
        }
    }
}