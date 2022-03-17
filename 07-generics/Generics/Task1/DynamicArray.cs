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
        public int Length
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

        /// <summary>
        /// Adds a new item to the end of the list
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            while (Length >= Capacity)
            {
                Array.Resize(ref data, Capacity * 2);
            }
            data[Length] = item;
        }

        /// <summary>
        /// Adds range of the items to the end of the list
        /// </summary>
        /// <param name="items"></param>
        public void AddRange(T[] items)
        {
            if (items.Length + Length > Capacity)
            {
                Array.Resize(ref data, (items.Length + Length) * 2);
            }
            Array.Copy(items, 0, data, Length, items.Length);
        }

        /// <summary>
        /// Removes the item from collection
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True if removing was successful, otherwise false</returns>
        public bool Remove(T item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (data[i].Equals(item))
                {
                    for (int j = i; j < Length - 1; j++)
                    {
                        data[j] = data[j + 1];
                    }

                    data[Length - 1] = default(T);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Inserts the item into the index position
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        public void Insert(T item, int index)
        {
            if (index > Length)
            {
                throw new ArgumentOutOfRangeException("Index is out of the range");
            }

            if (Capacity == Length)
            {
                Array.Resize(ref data, Capacity * 2);
            }         
         
            for (int i = Length; i >= index; i--)
            {
                data[i + 1] = data[i];
            }

            data[index] = item;
        }

        public T this[int index]
        {
            get { return data[index]; }
            set 
            { 
                if(index > Length || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index is out of the range");
                }
                
                data[index] = value; 
            }
        }

    }
}
