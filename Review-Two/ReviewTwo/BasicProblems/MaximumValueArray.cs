using System;
using System.Collections.Generic;

public class MaximumValueArray
{
    public T FindMaxValue<T>(List<T> list) where T : IComparable<T>
    {
        return list.Max();
    }
}