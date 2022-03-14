using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Ring : Round
    {
        private int innerRadius;

        /// <summary>
        /// Inner radius of the ring
        /// </summary>
        public int InnerRadius
        {
            get => innerRadius;
            set
            {
                if (value < 0 || value > Radius)
                {
                    throw new ArgumentException("Incorrect InnerRadius");
                }
                innerRadius = value;
            }
        }

        /// <summary>
        /// Circumference of the ring
        /// </summary>
        public override double Circumference { get => base.Circumference + (2 * Math.PI * InnerRadius); }

        /// <summary>
        /// Area of the ring
        /// </summary>
        public override double Area { get => Math.PI * (Math.Pow(Radius, 2) - Math.Pow(InnerRadius, 2)); }

        //Constructors
        public Ring(int x, int y, int radius, int innerRadius) : base(x, y, radius)
        {
            InnerRadius = innerRadius;
        }
        
        public override void Draw()
        {
            Console.WriteLine($"Фигура: {nameof(Ring)} " +
                $"Координаты: ({X}:{Y}) " +
                $"Радиус: {Radius} " +
                $"Внутренний радиус: {InnerRadius} " +
                $"Длины окружностей кольца: {Circumference} " +
                $"Площадь кольца: {Area}");
        }
    }
}
