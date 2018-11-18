using System;

namespace MyTrianlges
{
    /// <summary>
    /// Represent entity of equilateral triangle with method for calculate area of equilateral triangle.
    /// </summary>
    class EquilateralTriangle : Triangle
    {
        Point firstPoint;
        Point secondPoint;
        Point thirdPoint;

        /// <summary>
        ///  Сonstructor for equilateral triangle.
        /// </summary>
        /// <param name="firstPoint">First vertex of the triangle.</param>
        /// <param name="secondPoint">Second vertex of the triangle.</param>
        /// <param name="thirdPoint">Third vertex of the triangle.</param>
        public EquilateralTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.thirdPoint = thirdPoint;            
        }

        /// <summary>
        /// Realizes calculation the area of the equilateral triangle.
        /// </summary>
        /// <returns>Area of the equilateral triangle.</returns>      
        public override double GetSquare()
        {
            return (Math.Pow(firstPoint.GetDistance(secondPoint),2)* Math.Sqrt(3))/4;
        }
    }
}
