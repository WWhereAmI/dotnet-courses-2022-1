using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyString str1 = new MyString();
            MyString str2 = new MyString("Hello World!");
            MyString str3 = new MyString("Hello World!");
            MyString str4 = new MyString(new char[] { ' ', 'W', 'o', 'r', 'l', 'd', '!' });

            Console.WriteLine(str1+= str2);
            Console.WriteLine(str2-= str4);
            Console.WriteLine(str1 != null);
            Console.WriteLine(str2 == str3);
        }
    }
}
