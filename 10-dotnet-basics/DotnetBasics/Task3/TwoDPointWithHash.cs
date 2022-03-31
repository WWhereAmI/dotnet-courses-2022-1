using System;

namespace Task3
{
    internal class TwoDPointWithHash
    {
        readonly int x;
        readonly int y;

        public TwoDPointWithHash(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }
    }
}
