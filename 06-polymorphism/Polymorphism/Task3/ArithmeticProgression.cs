namespace Task3
{
    internal class ArithmeticProgression : IIndexableSeries
    {
        private double start;
        private double step;
        private int index;

        public double this[int index] => start + step * index;

        public double GetCurrent()
        {
            return start + step * index;
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
        public ArithmeticProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.index = 0;
        }
    }
}
