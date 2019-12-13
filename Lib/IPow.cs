namespace Lib
{
    public abstract class APow
    {
        public APow(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public abstract double Math();
    }
}