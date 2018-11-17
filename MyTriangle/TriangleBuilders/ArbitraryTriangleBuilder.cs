namespace MyTrianlges
{
    class ArbitraryTriangleBuilder : TriangleBuilder
    {
        public ArbitraryTriangleBuilder(TriangleBuilder nextBuilder)
        {
            NextBuilder = nextBuilder;            
        }

        public override Triangle CreateTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return new ArbitraryTriangle(firstPoint, secondPoint, thirdPoint);
        }

    }
}
