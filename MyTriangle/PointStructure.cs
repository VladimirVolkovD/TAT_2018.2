using System;

namespace MyTriangle
{
    /// <summary>
    /// Represent Point on a plane, consist of 2 coordinates(x and y).
    /// </summary>
    struct Point
    {
        public double x;
        public double y;

        /// <summary>
        /// Сonstructor for Point structure. 
        /// </summary>
        /// <param name="x">First coordinate.</param>
        /// <param name="y">Seconds coordinate.</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Returns distance between two points.
        /// Second point is taken as parameter.
        /// </summary>
        /// <param name="second">Point until which you need to find the distance.</param>
        /// <returns>Distance between two points.</returns>
        public double GetDistance(Point second)
        {
            return Math.Sqrt(Math.Pow((second.x - x), 2) + Math.Pow((second.y - y), 2));
        }
    }
}
