using System;

namespace Task1
{
    internal class Rectangle : Figure
    {
        private int a;
        private int b;

        public override string FigureType => "Rectangle";

        /// <summary>
        /// A side
        /// </summary>
        public int A
        {
            get => a;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect side lenght");
                }
                a = value;
            }
        }

        /// <summary>
        /// B side
        /// </summary>
        public int B
        {
            get => b;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect side lenght");
                }
                b = value;
            }
        }

        /// <summary>
        /// Area of the Rectangle
        /// </summary>
        public int Area { get => a * b; }

        /// <summary>
        /// Perimeter of the Rectangle
        /// </summary>
        public int Perimeter { get => 2 * (a + b); }

        //Constructor
        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public override void Draw()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Фигура: {FigureType} Стороны: {A} и {B} Площадь: {Area} Периметр: {Perimeter}";
        }
    }
}
