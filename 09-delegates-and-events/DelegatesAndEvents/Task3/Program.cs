using System;
using System.Threading;



namespace Task3
{
    internal class Program
    {
        delegate void SortEvent(string message, Thread currentThread);
        static event SortEvent SortEnded;

        static Thread sortAcyncThread;
        static Thread sortAcyncThread2;
        static Thread sortAcyncThread3;

        static void Main(string[] args)
        {
            string[] stringList = { "Hello", "hello", "hellw", "world", "session", "callstack" };
            string[] stringList2 = { "Hello", "hello", "hellw", "world", "session", "callstack" };
            string[] stringList3 = { "Hello", "hello", "hellw", "world", "session", "callstack" };

            SortEnded += OnSortEnded;
  
            sortAcyncThread = SortAsync(stringList, CompareStrings);
            sortAcyncThread2 = SortAsync(stringList2, CompareStrings);
            sortAcyncThread3 = SortAsync(stringList3, CompareStrings);

            sortAcyncThread.Name = "Первый поток";
            sortAcyncThread2.Name = "Второй поток";
            sortAcyncThread3.Name = "Третий поток";


            Console.WriteLine($"Состояние первого потока {sortAcyncThread.ThreadState}");
            Console.WriteLine($"Состояние второго потока {sortAcyncThread2.ThreadState}");
            Console.WriteLine($"Состояние третьего потока {sortAcyncThread3.ThreadState}");
            Console.WriteLine($"Состояние главного потока {Thread.CurrentThread.ThreadState}");

            sortAcyncThread.Start();
            sortAcyncThread2.Start();
            sortAcyncThread3.Start();


            //sortAcyncThread.Start();
            //sortAcyncThread.Join();

            //sortAcyncThread2.Start();
            //sortAcyncThread2.Join();

            //sortAcyncThread3.Start();
            //sortAcyncThread3.Join();
        }

        private static void OnSortEnded(string message, Thread currentThread)
        {
            Console.WriteLine($"Состояние первого потока {sortAcyncThread.ThreadState}");
            Console.WriteLine($"Состояние второго потока {sortAcyncThread2.ThreadState}");
            Console.WriteLine($"Состояние третьего потока {sortAcyncThread3.ThreadState}");
            Console.WriteLine($"Состояние главного потока {Thread.CurrentThread.ThreadState}");

            Console.WriteLine($"{message} потоком {currentThread.Name}");
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
            SortEnded?.Invoke($"Метод закончил работу", Thread.CurrentThread);           
        }

        public static Thread SortAsync(string[] stringList, Func<string, string, int> sortLogic)
        {         
            return new Thread(() => Sort(stringList, sortLogic));
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
