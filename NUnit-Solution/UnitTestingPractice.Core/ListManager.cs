namespace UnitTestingPractice.Core;

public class ListManager
{
    public void AddElement(List<int> list, int element)
    {
        ArgumentNullException.ThrowIfNull(list);

        list.Add(element);
    }

    public bool RemoveElement(List<int> list, int element)
    {
        ArgumentNullException.ThrowIfNull(list);

        return list.Remove(element);
    }

    public int GetSize(List<int> list)
    {
        ArgumentNullException.ThrowIfNull(list);

        return list.Count;
    }
}
