using System;
using System.Collections.Generic;

namespace MyGenericClass
{
    public class Guarda3<T>
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
    }
}