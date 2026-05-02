public class LongestCommonPrefix
{
    public int find_match_count(string a, string b)
    {
        int count = 0;

        for (int i = 0; i < int.Min(a.Length, b.Length); i++)
        {
            if (a[i] == b[i])
            {
                count++;
            }
            else return count;
        }
        return count;
    }
    public void LCP(List<string> list)
    {
        string temp = list[0];
        int mini = int.MaxValue;

        for (int i = 1; i < list.Count; i++)
        {
            int count = find_match_count(temp, list[i]);

            mini = int.Min(mini, count);
        }

        for (int i = 0; i < mini; i++)
        {
            System.Console.Write(temp[i]);
        }
        System.Console.WriteLine();
    }
}