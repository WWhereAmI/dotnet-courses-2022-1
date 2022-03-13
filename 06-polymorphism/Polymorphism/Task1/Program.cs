using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>()
            {
                new Line(1, 1, 5, 5),
                new Rectangle(5, 5),
                new Circle(5, 5, 15),
                new Round(5, 5, 15),
                new Ring(5, 5, 15, 10)
            };

            foreach (Figure figure in figures)
            {
                figure.Draw();
            }

        }
    }
}
