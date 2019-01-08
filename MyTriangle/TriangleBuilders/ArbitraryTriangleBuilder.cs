using MyTriangle.Triangles;
using MyTrianlges;

namespace MyTriangle.TriangleBuilders
{
    /// <summary>
    ///  Represent entity of arbitrary triangle builder.    
    /// </summary>
    class ArbitraryTriangleBuilder : TriangleBuilder
    {
        /// <summary>
        /// Сonstructor for arbitrary triangle builder.
        /// </summary>
        /// <param name="nextBuilder">Next triangle builder object.</param>
        public ArbitraryTriangleBuilder(TriangleBuilder nextBuilder)
        {
            this.nextBuilder = nextBuilder;            
        }

        /// <summary>
        /// Creates arbitrary triangle.
        /// </summary>
        public override Triangle CreateTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return new ArbitraryTriangle(firstPoint, secondPoint, thirdPoint);
        }
    }
}
