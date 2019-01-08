using MyTriangle.Triangles;
using MyTrianlges;

namespace MyTriangle.TriangleBuilders
{
    /// <summary>
    ///  Represent entity of equilateral triangle builder.
    /// </summary>
    class EquilateralTriangleBuilder : TriangleBuilder
    {
        /// <summary>
        /// Сonstructor for equilateral triangle builder.
        /// </summary>
        /// <param name="nextBuilder">Next triangle builder object.</param>
        public EquilateralTriangleBuilder(TriangleBuilder nextBuilder)
        {
            this.nextBuilder = nextBuilder;            
        }

        /// <summary>
        /// Creates equilateral triangle if the vertices satisfy the conditions of equilateral triangle.
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

            if ( ((firstDistance - secondDistance) < Accuracy) && ((secondDistance -thirdDistance) < Accuracy) )
            {
                return new EquilateralTriangle(firstPoint, secondPoint, thirdPoint);
            }
            else
            {
                return nextBuilder.CreateTriangle(firstPoint, secondPoint, thirdPoint);
            }
        }
    }
}
