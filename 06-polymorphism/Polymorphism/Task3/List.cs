using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal class List : IIndexableSeries
    {
        private double[] data;
        private int index;

        public double this[int index] => data[index];

        public double GetCurrent()
        {
            return data[index];
        }

        public bool MoveNext()
        {
            index = index < data.Length - 1 ? ++index : 0;
            return true;
        }

        public void Reset()
        {
            index = 0;
        }

        //Constructors
        public List(double[] data)
        {
            this.data = data;
            index = 0;
        }

        public List(int capacity)
        {
            data = new double[capacity];

            Random rnd = new Random();
            
            for (int i = 0; i < capacity; i++)
            {
                data[i] = rnd.Next(50);
            }

            index = 0;
        }
    }
}
