using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            LinkedList<int> ls = new LinkedList<int>();
            ls.AddLast(1);
            ls.AddLast(2);
            ls.AddLast(3);
            ls.AddLast(4);
            ls.AddLast(5);
            ls.AddLast(6);
            ls.AddLast(7);
            ls.AddLast(8);
            ls.AddLast(9);
            ls.AddLast(10);
            ls.AddLast(11);
            ls.AddLast(12);
            ls.AddLast(13);
            ls.AddLast(14);
            ls.AddLast(15);



            List<int> vs = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            RemoveEachSecondItem(ls);
            RemoveEachSecondItem(vs);
        }

        static void RemoveEachSecondItem(ICollection<int> collection)
        {

            #region With using index
            //int i = 1;

            //while (collection.Count > 1)
            //{
            //    Console.WriteLine($"{collection[i % collection.Count]} удален");
            //    collection.RemoveAt(i % collection.Count);

            //    i = i >= collection.Count ? 1 : i + 1;

            //}
            #endregion


            int currentIndex = 0;
            int nextToDelete;
            int step = 1;            
            int N = collection.Count;

            if (collection.Count % 2 == 0)
            {
                while (collection.Count > 1)
                {
                    if (currentIndex + 2 * step > N)
                    {
                        nextToDelete = (currentIndex + 2 * step) % (currentIndex - 1);
                        step *= 2;
                        N = currentIndex;
                    }
                    else
                    {
                        nextToDelete = (currentIndex + 2 * step) % N == 0 ? currentIndex + 2 * step : (currentIndex + 2 * step) % N;
                    }
                    currentIndex = nextToDelete;

                    collection.Remove(currentIndex);
                }
            }
            else
            {
                while (collection.Count > 1)
                {
                    if (currentIndex + 2 * step >= N)
                    {
                        nextToDelete = (currentIndex + 2 * step) % (currentIndex + 1);
                        step *= 2;
                        N = currentIndex;
                    }
                    else
                    {
                        nextToDelete = (currentIndex + 2 * step) % N;
                    }
                    currentIndex = nextToDelete;

                    collection.Remove(currentIndex);
                }
            }
        }
    }
}

