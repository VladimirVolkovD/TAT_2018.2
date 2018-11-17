using System;

namespace MyTrianlges
{
    class EquilateralTriangle : Triangle
    {
        Point firstPoint;
        Point secondPoint;
        Point thirdPoint;

        public EquilateralTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.thirdPoint = thirdPoint;            
        }

        public override double GetSquare()
        {
            return (Math.Pow(firstPoint.GetDistance(secondPoint),2)* Math.Sqrt(3))/4;
        }
    }
}
