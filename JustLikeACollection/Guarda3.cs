using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T g;
        private T a;
        private T y;

        public Guarda3()
        {
            this.g = default;
            this.a = default;
            this.y = default;
        }

        public T GetItem(int i)
        {
            if (i < 0 || i > 2) throw new IndexOutOfRangeException();

            if (i == 0) return g;
            else if (i == 1) return a;
            else return y;

        }

        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2) throw new IndexOutOfRangeException();

            if (i == 0) g = item;
            if (i == 1) a = item;
            if (i == 2) y = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < 3; i++)
            {
                yield return GetItem(i);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            if (EqualityComparer<T>.Default.Equals(g, default))
                g = item;
            else if (EqualityComparer<T>.Default.Equals(a, default))
                a = item;
            else if (EqualityComparer<T>.Default.Equals(y, default))
                y = item;
        }
    }
}