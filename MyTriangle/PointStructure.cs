using System;

namespace MyTrianlges
{
    struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetDistance(Point second)
        {
            return Math.Sqrt(Math.Pow((second.x - this.x), 2) + Math.Pow((second.y - this.y), 2));
        }
    }
}
