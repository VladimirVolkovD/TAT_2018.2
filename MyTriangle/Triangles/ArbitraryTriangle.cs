using System;

namespace MyTrianlges
{
    class ArbitraryTriangle : Triangle
    {       
        public ArbitraryTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            firstDistance = firstPoint.GetDistance(secondPoint);
            secondDistance = secondPoint.GetDistance(thirdPoint);
            thirdDistance = thirdPoint.GetDistance(firstPoint);
        }
        public override double GetSquare()
        {
            double semiPerimeter = (firstDistance + secondDistance + thirdDistance) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - firstDistance) * (semiPerimeter - secondDistance) * (semiPerimeter - thirdDistance));
        }
    }
}
