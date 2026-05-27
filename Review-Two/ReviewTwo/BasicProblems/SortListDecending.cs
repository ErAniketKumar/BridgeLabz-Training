public class SortListDecending
{
    public void sortListDesc(List<int> list)
    {
        // list.Sort();
        // list.Reverse();

        list.Sort((a, b) => (b).CompareTo(a));

        for (int i = 0; i < list.Count; i++)
        {
            System.Console.WriteLine(list[i]);
        }
    }
}