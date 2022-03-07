using System;
using System.Diagnostics;
using System.Text;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringAnalysis());

            Console.WriteLine(StringBuilderAnalysis());

        }

        /// <summary>
        /// Measuring the speed of work of string type
        /// </summary>
        /// <param name="N"></param>
        /// <returns>Result of the speed test</returns>
        static string StringAnalysis(int N = 100000)
        {
            Stopwatch sw = new Stopwatch();

            string str = "";

            sw.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            sw.Stop();

            return $"String: {sw.Elapsed.TotalMilliseconds}";
        }

        /// <summary>
        /// Measuring the speed of work of StringBuilder type
        /// </summary>
        /// <param name="N"></param>
        /// <returns>Result of the speed test</returns>
        static string StringBuilderAnalysis(int N = 100000)
        {
            Stopwatch sw = new Stopwatch();

            StringBuilder sb = new StringBuilder();

            sw.Restart();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            sw.Stop();

            return $"StringBuilder: {sw.Elapsed.TotalMilliseconds}";
        }




    }
}
