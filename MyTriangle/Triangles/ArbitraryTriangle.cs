using MyTrianlges;

namespace MyTriangle.Triangles
{
    /// <summary>
    /// Represent entity of abitrary triangle.
    /// Uses standard method of calculating the triangle area from Triangle class.
    /// </summary>
    class ArbitraryTriangle : Triangle
    {
        /// <summary>
        ///  Сonstructor for abitrary triangle.
        /// </summary>
        /// <param name="firstPoint">First vertex of the triangle.</param>
        /// <param name="secondPoint">Second vertex of the triangle.</param>
        /// <param name="thirdPoint">Third vertex of the triangle.</param>
        public ArbitraryTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            firstDistance = firstPoint.GetDistance(secondPoint);
            secondDistance = secondPoint.GetDistance(thirdPoint);
            thirdDistance = thirdPoint.GetDistance(firstPoint);
        }        
    }
}
