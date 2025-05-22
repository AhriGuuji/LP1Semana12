using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    public class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T thing) where T : IComparable<T>
        {
            foreach (T item in items)
            {
                if (item.CompareTo(thing) < 0)
                {
                    yield return item;
                }
            }
        }
    }
}