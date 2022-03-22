using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    internal class DynamicArray<T> : IEnumerable<T>
        where T : new()
    {
        private T[] data;
        private int lenght;

        /// <summary>
        /// Gets the total number of the elements contained in the array
        /// </summary>
        public int Length => lenght;

        /// <summary>
        /// Gets or sets the total number of the elements the data structure can hold without resizing
        /// </summary>
        public int Capacity => data.Length;
       
        public T this[int index]
        {
            get
            {
                if (index > lenght || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index is out of the range");
                }

                return data[index];
            }
            set
            {
                if (index > lenght || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index is out of the range");
                }

                data[index] = value;
            }
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

        public DynamicArray(T[] array)
        {
            data = array;
            lenght = array.Length;
        }

        public DynamicArray(IEnumerable<T> collection)
        {

            #region Without Linq
            //int count = 0;
            //foreach (var item in collection)
            //{
            //    count++;
            //}
            //data = new T[count];

            //int i = 0;
            //foreach (var item in collection)
            //{
            //    data[i++] = item;               
            //}

            //lenght = count;
            #endregion

            data = collection.ToArray();
            lenght = collection.Count();
        }

        #endregion

        /// <summary>
        /// Adds a new item to the end of the list
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            while (lenght >= Capacity)
            {
                Array.Resize(ref data, Capacity * 2);
            }

            data[lenght] = item;

            lenght++;
        }

        /// <summary>
        /// Adds range of the items to the end of the list
        /// </summary>
        /// <param name="items"></param>
        public void AddRange(T[] items)
        {
            if (items.Length + lenght > Capacity)
            {
                Array.Resize(ref data, (items.Length + lenght) * 2);
            }
            Array.Copy(items, 0, data, lenght, items.Length);

            lenght += items.Length;
        }

        /// <summary>
        /// Removes the item from collection
        /// </summary>
        /// <param name="item"></param>
        /// <returns>True if removing was successful, otherwise false</returns>
        public bool Remove(T item)
        {
            for (int i = 0; i < lenght; i++)
            {
                if (data[i].Equals(item))
                {
                    for (int j = i; j < lenght - 1; j++)
                    {
                        data[j] = data[j + 1];
                    }

                    data[lenght - 1] = default(T);
                    lenght--;

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
            if (index > lenght)
            {
                throw new ArgumentOutOfRangeException("Index is out of the range");
            }

            if (Capacity == lenght)
            {
                Array.Resize(ref data, Capacity * 2);
            }

            for (int i = lenght; i >= index; i--)
            {
                data[i + 1] = data[i];
            }

            lenght++;
            data[index] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in data)
            {
                yield return item;
            }

            // return new EnumeratorArray<T>(data);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
