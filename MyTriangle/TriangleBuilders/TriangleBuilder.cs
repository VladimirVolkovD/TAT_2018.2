namespace MyTrianlges
{
    /// <summary>
    ///  Represent entity of triangle builder.
    /// </summary>
    abstract class TriangleBuilder
    {
        //Next triangle builder object.
        public TriangleBuilder NextBuilder;

        //Сonstant for calculation accuracy.
        public const double ACCURACY = 10E-4;

        /// <summary>
        /// Method for overriding, realizes creating the triangle.      
        /// </summary>
        /// <param name="firstPoint">First vertex of the triangle.</param>
        /// <param name="secondPoint">Second vertex of the triangle.</param>
        /// <param name="thirdPoint">Third vertex of the triangle.</param>
        /// <returns>Triangle object</returns>
        public virtual Triangle CreateTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return null;
        }       
    }
}
