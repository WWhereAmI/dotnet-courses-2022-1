using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа определяет прощадь прямоугольника со сторонами a и b");
            Console.WriteLine("Поочередно введите эти стороны");

            int a;
            int b;

            while (true)
            {
                Console.Write("Введите сторону a: ");

                if (int.TryParse(Console.ReadLine(), out a) && a > 0) break;           
                else Console.WriteLine("Введено неккоректное значение стороны прямоугольника. Повторите попытку...");
               
            }

            while (true)
            {
                Console.Write("Введите сторону b: ");

                if (int.TryParse(Console.ReadLine(), out b) && b > 0) break;              
                else Console.WriteLine("Введено неккоректное значение стороны прямоугольника. Повторите попытку...");
                
            }

            Console.Write($"Площадь прямоугольника: {a * b}");

        }
    }
}
