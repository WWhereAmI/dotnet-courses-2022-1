using System;
using System.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringList = { "Hello", "hello", "hellw", "world", "session", "callstack" };

            //stringList.OrderBy(x => x);

            Sort(stringList, CompareStrings);
        }

        public static void Sort(string[] stringList, Func<string, string, int> sortLogic)
        {
            for (int i = 0; i < stringList.Length; i++)
            {
                for (int j = i + 1; j < stringList.Length; j++)
                {
                    if (sortLogic(stringList[i], stringList[j]) > 0)
                    {
                        var temp = stringList[i];
                        stringList[i] = stringList[j];
                        stringList[j] = temp;
                    }
                }
            }
        }

        public static int CompareStrings(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return 1;
            }
            else if (str1.Length < str2.Length)
            {
                return -1;
            }

            return string.Compare(str1, str2, true);
        }
    }
}
