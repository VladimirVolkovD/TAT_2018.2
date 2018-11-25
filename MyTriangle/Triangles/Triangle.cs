using System;

namespace MyTrianlges
{
    /// <summary>
    /// Represent entity of triangle.
    /// </summary>
    abstract class Triangle
    {
        public double firstDistance;
        public double secondDistance;
        public double thirdDistance;

        /// <summary>
        /// Realizes calculation the area of the triangle according the formula of Heron.
        /// </summary>
        /// <returns>Area of the triangle.</returns>
        public virtual double GetSquare()
        {
            double semiPerimeter = (firstDistance + secondDistance + thirdDistance) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - firstDistance) * (semiPerimeter - secondDistance) * (semiPerimeter - thirdDistance));
        }
    }
}
