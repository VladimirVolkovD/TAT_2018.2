using System;

namespace MyTrianlges
{
    class RightTriangleBuilder : TriangleBuilder
    {
        public RightTriangleBuilder(TriangleBuilder nextBuilder)
        {
            NextBuilder = nextBuilder;           
        }

        public override Triangle CreateTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            double firstDistance = firstPoint.GetDistance(secondPoint);
            double secondDistance = secondPoint.GetDistance(thirdPoint);
            double thirdDistance = thirdPoint.GetDistance(firstPoint);

            if (ValidationOfCoordinates(firstDistance, secondDistance, thirdDistance))
            {
                if ((Math.Pow(firstDistance, 2) + (Math.Pow(secondDistance, 2)) == Math.Pow(thirdDistance, 2)) ||
                    (Math.Pow(firstDistance, 2) + (Math.Pow(thirdDistance, 2)) == Math.Pow(secondDistance, 2)) ||
                    (Math.Pow(thirdDistance, 2) + (Math.Pow(secondDistance, 2)) == Math.Pow(firstDistance, 2)))
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
