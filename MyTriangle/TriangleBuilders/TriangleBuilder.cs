namespace MyTrianlges
{
    abstract class TriangleBuilder
    {
        public TriangleBuilder NextBuilder;

        public virtual Triangle CreateTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return null;
        }       
    }
}
