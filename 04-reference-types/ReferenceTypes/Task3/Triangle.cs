using System;

namespace Task3
{
    internal class Triangle
    {
        private int a;
        private int b;
        private int c;
        private double semiPerimeter;

        /// <summary>
        /// A side of triagle
        /// </summary>
        public int A
        {
            get => a;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect length value");
                }
                a = value;
            }
        }

        /// <summary>
        /// B side of triagle
        /// </summary>
        public int B
        {
            get => b;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect length value");
                }
                b = value;
            }
        }

        /// <summary>
        /// C side of triagle
        /// </summary>
        public int C
        {
            get => c;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect length value");
                }
                c = value;
            }
        }

        //Constructor
        public Triangle(int a, int b, int c)
        {
            if (IsExist(a, b, c))
            {
                A = a;
                B = b;
                C = c;
                semiPerimeter = (double)GetPerimeter() / 2;
            }
            else
            {
                throw new ArgumentException("Cannot create triagle with this sides");
            }
        }

        /// <summary>
        /// Checks the possibility of creating a triangle on the input sides
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>True if it possible, otherwise false</returns>
        private bool IsExist(int a, int b, int c)
        {
            if (a + b > c && a + c > b && a + c > a)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Calculates Perimeter of the triangle 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Perimeter</returns>
        public int GetPerimeter()
        {
            return a + b + c;
        }

        /// <summary>
        /// Calculates Area of the triangle 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Area</returns>
        public double GetArea()
        {
            return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
        }

        public override string ToString()
        {
            return $"Треугольник со сторонами: ({A},{B},{C}) Периметр: {GetPerimeter()} Площадь: {GetArea()}";
        }



    }
}
