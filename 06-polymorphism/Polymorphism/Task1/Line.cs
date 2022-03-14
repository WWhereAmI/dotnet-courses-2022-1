using System;

namespace Task1
{
    internal class Line : Figure
    {

        /// <summary>
        /// X coordinate begin
        /// </summary>
        public int X1 { get; set; }
        /// <summary>
        /// Y coordinate begin
        /// </summary>
        public int Y1 { get; set; }
        /// <summary>
        /// X coordinate end
        /// </summary>
        public int X2 { get; set; }
        /// <summary>
        /// Y coordinate end
        /// </summary>
        public int Y2 { get; set; }

        /// <summary>
        /// Lenght of the Line
        /// </summary>
        public double Lenght { get => Math.Sqrt((Math.Pow(X2, 2) - Math.Pow(X1, 2)) + (Math.Pow(Y2, 2) - Math.Pow(Y1, 2))); }

        //Constructor
        public Line(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public override void Draw()
        {
            Console.WriteLine($"Фигура {nameof(Line)} Координаты: ({X1},{Y1}):({X2},{Y2}) Длина отрезка: {Lenght}");
        }
     
    }
}
