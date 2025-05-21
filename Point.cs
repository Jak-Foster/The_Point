
namespace The_Point
{
    internal class Point
    {
        private int X { get; }
        private int Y { get; }
        public Point (int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Point ()
        {
            X = 0;
            Y = 0;
        }
    }
}
