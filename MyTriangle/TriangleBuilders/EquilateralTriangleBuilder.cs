namespace MyTrianlges
{
    class EquilateralTriangleBuilder : TriangleBuilder
    {

       public EquilateralTriangleBuilder(TriangleBuilder nextBuilder)
        {
            NextBuilder = nextBuilder;            
        }

        public override Triangle CreateTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            double firstDistance = firstPoint.GetDistance(secondPoint);
            double secondDistance = secondPoint.GetDistance(thirdPoint);
            double thirdDistance = thirdPoint.GetDistance(firstPoint);

            if ( ((firstDistance - secondDistance) < 10E-4) && ((secondDistance -thirdDistance) < 10E-4) )
            {
                return new EquilateralTriangle(firstPoint, secondPoint, thirdPoint);
            }
            else
            {
                return NextBuilder.CreateTriangle(firstPoint, secondPoint, thirdPoint);
            }
        }
    }
}
