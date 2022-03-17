using System;
using System.Linq;

namespace Task1
{
    internal class DynamicArray<T>
        where T : new()
    {
        private T[] data;

        /// <summary>
        /// Gets the total number of the elements contained in the array
        /// </summary>
        public int Lenght 
        {
            get => data.Where(x => !x.Equals(default(T))).Count();                   
        }

        /// <summary>
        /// Gets or sets the total number of the elements the data structure can hold without resizing
        /// </summary>
        public int Capacity
        {
            get => data.Length;
            private set { }
        }

        #region Constructors
        public DynamicArray()
        {
            data = new T[8];
        }

        public DynamicArray(int capacity)
        {
            data = new T[capacity];
        }

        public DynamicArray(params T[] sequence)
        {
            data = sequence;
        }
        #endregion

        public void Add(T item)
        {
            while(Lenght >= Capacity)
            {
                Array.Resize(ref data, Capacity * 2);
            }
            data[Lenght] = item;
        }

        public void AddRange(T[] items)
        {
            if (items.Length > Capacity)
            {
                Array.Resize(ref data, Capacity + items.Length);
            }
        }







    }
}
