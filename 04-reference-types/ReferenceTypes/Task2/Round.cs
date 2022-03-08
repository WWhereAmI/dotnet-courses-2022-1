using System;

namespace Task2
{
    internal class Round
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
        public double Circumference { get => 2 * Math.PI * radius; }

        /// <summary>
        /// Area of the circle
        /// </summary>
        public double Area { get => Math.PI * Math.Pow(radius, 2); }

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
        public Round(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override string ToString()
        {
            return $"Координаты: ({X}:{Y}) Радиус: {radius} Длина окружности: {Circumference} Площадь окружности: {Area}";
        }

    }
}
