using System;

namespace MyTrianlges
{
    /// <summary>
    ///  Represent entity of right triangle builder with some methods.
    /// </summary>
    class RightTriangleBuilder : TriangleBuilder
    {
        /// <summary>
        /// Сonstructor for right triangle builder.
        /// </summary>
        /// <param name="nextBuilder">Next triangle builder object.</param>
        public RightTriangleBuilder(TriangleBuilder nextBuilder)
        {
            NextBuilder = nextBuilder;           
        }

        /// <summary>
        /// Creates right triangle if the vertices satisfy the conditions of right triangle.
        /// </summary>
        /// <param name="firstPoint">First vertex of the triangle.</param>
        /// <param name="secondPoint">Second vertex of the triangle.</param>
        /// <param name="thirdPoint">Third vertex of the triangle.</param>
        /// <returns>Right triangle object.</returns>
        public override Triangle CreateTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            double firstDistance = firstPoint.GetDistance(secondPoint);
            double secondDistance = secondPoint.GetDistance(thirdPoint);
            double thirdDistance = thirdPoint.GetDistance(firstPoint);

            if (ValidationOfCoordinates(firstDistance, secondDistance, thirdDistance))
            {
                if ((Math.Pow(firstDistance, 2) + (Math.Pow(secondDistance, 2)) - Math.Pow(thirdDistance, 2) < ACCURACY) ||
                    (Math.Pow(firstDistance, 2) + (Math.Pow(thirdDistance, 2)) - Math.Pow(secondDistance, 2) < ACCURACY) ||
                    (Math.Pow(thirdDistance, 2) + (Math.Pow(secondDistance, 2)) - Math.Pow(firstDistance, 2) < ACCURACY))
                {
                    return new RightTriangle(firstPoint, secondPoint, thirdPoint);
                }
                else
                {
                    return NextBuilder.CreateTriangle(firstPoint, secondPoint, thirdPoint);
                }
            }
            else
            {
                throw new Exception("Wrong points for creating triangle.");
            }     
        }

        /// <summary>
        /// Checks the vertices satisfy the conditions of right triangle
        /// </summary>
        /// <param name="firstDistance">Length of the First side of the triangle.</param>
        /// <param name="secondDistance">Length of the Second side of the triangle.</param>
        /// <param name="thirdDistance">Length of the Third side of the triangle.</param>
        /// <returns>Bool value.</returns>
        bool ValidationOfCoordinates(double firstDistance, double secondDistance, double thirdDistance)
        {       
            if (10E-4 < (firstDistance - secondDistance + thirdDistance) && 10E-4 < (secondDistance - firstDistance + thirdDistance)
                && 10E-4 < (thirdDistance - firstDistance + secondDistance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
