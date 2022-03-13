using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class GeometricProgression : ISeries
    {
        private double start;
        private double step;
        private int index;
   
        public double GetCurrent()
        {
            return start * Math.Pow(step, index - 1);
        }
        
        public bool MoveNext()
        {
            index++;
            return true;
        }

        public void Reset()
        {
            index = 1;
        }

        //Constructor
        public GeometricProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.index = 1;
        }
    }
}
