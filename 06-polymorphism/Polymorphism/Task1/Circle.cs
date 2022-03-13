using System;

namespace Task1
{
    internal class Circle : Figure
    {
        private int radius;

        /// <summary>
        /// X coordinate
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Y coordinate
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Circumference of the circle
        /// </summary>
        public virtual double Circumference { get => 2 * Math.PI * radius; }

        public override string FigureType => "Circle";

        /// <summary>
        /// Radius of the circle
        /// </summary>
        public int Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect radius");
                }
                radius = value;
            }
        }

        //Constructor
        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Фигура: {FigureType} " +
                $"Координаты: ({X}:{Y}) " +
                $"Радиус: {radius} " +
                $"Длина окружности: {Circumference}";
        }
    }
}
