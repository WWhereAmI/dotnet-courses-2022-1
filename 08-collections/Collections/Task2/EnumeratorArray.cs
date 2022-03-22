using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    internal class EnumeratorArray<T> : IEnumerator<T>
    {
        private int index = -1;
        private T[] data;

        public T Current => data[index];

        object IEnumerator.Current => Current;

        public EnumeratorArray(T[] data)
        {
            this.data = data;
        }


        public bool MoveNext()
        {
            return ++index < data.Length;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Dispose()
        {
        }

    }
}
