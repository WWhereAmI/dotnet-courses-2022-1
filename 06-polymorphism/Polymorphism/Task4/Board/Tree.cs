using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Board
{
    internal class Tree : MapObjects
    {
        public override double Width { get; set; }
        public override double Height { get; set; }
        public Tree()
        {
            Width = 50;
            Height = 50;
        }

    }
}
