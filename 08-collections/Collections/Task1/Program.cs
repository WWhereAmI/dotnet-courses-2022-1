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

            List<int> vs = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            RemoveEachSecondItem(ls);
            RemoveEachSecondItem(vs);
        }

        static void RemoveEachSecondItem(ICollection<int> collection)
        {
            var tempArray = new int[collection.Count];

            collection.CopyTo(tempArray, 0);

            int collectionCurrentLength = collection.Count;
            int i = 1;

            while (collection.Count > 1)
            {               
                if (i  >= collectionCurrentLength)
                {
                    i %= collectionCurrentLength;

                    tempArray = new int[collection.Count];

                    collection.CopyTo(tempArray, 0);

                    collectionCurrentLength = collection.Count;
                }

                collection.Remove(tempArray[i]);
                                  
                i += 2;

            }
        }
    }
}

