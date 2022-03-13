using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Board
{
    internal class Rock : MapObjects
    {
        public override double Width { get; set; }
        public override double Height { get; set; }

        public Rock()
        {
            Width = 200;
            Height = 200;
        }
    }
}
