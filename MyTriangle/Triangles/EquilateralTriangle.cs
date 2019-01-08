using System;
using MyTrianlges;

namespace MyTriangle.Triangles
{
    /// <summary>
    /// Represent entity of equilateral triangle with method for calculate area of equilateral triangle.
    /// </summary>
    class EquilateralTriangle : Triangle
    {
        private Point _firstPoint;
        private Point _secondPoint;
        private Point _thirdPoint;

        /// <summary>
        ///  Сonstructor for equilateral triangle.
        /// </summary>
        /// <param name="firstPoint">First vertex of the triangle.</param>
        /// <param name="secondPoint">Second vertex of the triangle.</param>
        /// <param name="thirdPoint">Third vertex of the triangle.</param>
        public EquilateralTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            _firstPoint = firstPoint;
            _secondPoint = secondPoint;
            _thirdPoint = thirdPoint;            
        }

        /// <summary>
        /// Realizes calculation the area of the equilateral triangle.
        /// </summary>
        /// <returns>Area of the equilateral triangle.</returns>      
        public override double GetSquare()
        {
            return (Math.Pow(_firstPoint.GetDistance(_secondPoint),2)* Math.Sqrt(3))/4;
        }
    }
}
