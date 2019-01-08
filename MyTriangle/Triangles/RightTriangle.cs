using MyTrianlges;

namespace MyTriangle.Triangles
{
    /// <summary>
    /// Represent entity of right triangle with method for calculate area of right triangle.
    /// </summary>
    class RightTriangle : Triangle
    {
        /// <summary>
        ///  Сonstructor for right triangle.
        /// </summary>
        /// <param name="firstPoint">First vertex of the triangle.</param>
        /// <param name="secondPoint">Second vertex of the triangle.</param>
        /// <param name="thirdPoint">Third vertex of the triangle.</param>
        public RightTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
             firstDistance = firstPoint.GetDistance(secondPoint);
             secondDistance = secondPoint.GetDistance(thirdPoint);
             thirdDistance = thirdPoint.GetDistance(firstPoint);
        }

        /// <summary>
        /// Realizes calculation the area of the right triangle.
        /// </summary>
        /// <returns>Area of the right triangle.</returns>
        public override double GetSquare()
        {
            if (firstDistance > secondDistance)
            {
                if (firstDistance > thirdDistance)
                {
                    return (0.5) * secondDistance * thirdDistance;
                }
                else
                {
                    return (0.5) * firstDistance * secondDistance;
                }
            }
            else
            {
                if (secondDistance > thirdDistance)
                {
                    return (0.5) * firstDistance * thirdDistance;
                }
                else
                {
                    return (0.5) * firstDistance * secondDistance;
                }
            }           
        }
    }
}
