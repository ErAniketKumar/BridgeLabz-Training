
public class NegativeIndexException : Exception
{
    public NegativeIndexException(string message) : base(message)
    {
        System.Console.WriteLine(message);
    }
}

public class ArrayException
{
    public void CheckArrayIdxVal(int[] arr, int idx)
    {
        try
        {
            if (arr.Length == 0)
            {
                throw new NullReferenceException("Array is not initialized!");
            }

            else if (arr.Length <= idx)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            else if (idx < 0)
            {
                throw new NegativeIndexException("Index cannot be -ve!");
            }
            System.Console.WriteLine($"Value: at {idx}: {arr[idx]}");
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
    public void ArrayHandle()
    {
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        CheckArrayIdxVal(arr, -1);
    }
}