using System;

namespace Task1
{
    internal class Round : Circle
    {
        /// <summary>
        /// Area of the circle
        /// </summary>
        public virtual double Area { get => Math.PI * Math.Pow(Radius, 2); }

        //Constructor
        public Round(int x, int y, int radius) : base(x, y, radius) { }

        public override void Draw()
        {
            Console.WriteLine($"Фигура: {nameof(Round)} " +
                $"Координаты: ({X}:{Y}) " +
                $"Радиус: {Radius} " +
                $"Длина окружности круга: {Circumference} " +
                $"Площадь круга: {Area}");
        }




    }
}
