using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTrianlges
{
    class TriangleBuilder
    {

        public void CreateTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            double firstDistance = firstPoint.GetDistance(secondPoint);
            double secondDistance = secondPoint.GetDistance(thirdPoint);
            double thirdDistance = thirdPoint.GetDistance(firstPoint);

            ValidationOfCoordinates(firstPoint.GetDistance(secondPoint), secondPoint.GetDistance(thirdPoint), thirdPoint.GetDistance(firstPoint));

        }

        bool ValidationOfCoordinates(double firstDistance, double secondDistance, double thirdDistance)
        {
            if ((firstDistance < secondDistance + thirdDistance) && (secondDistance < firstDistance + thirdDistance)
                && (thirdDistance < firstDistance + secondDistance))
            {
                System.Console.WriteLine("Треугольник существует.");
            }
            else
            {
                System.Console.WriteLine("Треугольник не существует.");
            }

            return false;
        }

    }
}
