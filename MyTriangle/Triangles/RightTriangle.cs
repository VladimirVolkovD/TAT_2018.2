namespace MyTrianlges
{
    class RightTriangle : Triangle
    {     
        public RightTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
             firstDistance = firstPoint.GetDistance(secondPoint);
             secondDistance = secondPoint.GetDistance(thirdPoint);
             thirdDistance = thirdPoint.GetDistance(firstPoint);
        }

        public override double GetSquare()
        {
            if (firstDistance > secondDistance)
            {
                if (firstDistance > thirdDistance)
                {
                    return (0.5) * secondDistance * thirdDistance;
                }
                else
                {
                    return (0.5) * firstDistance * secondDistance;
                }
            }
            else
            {
                if (secondDistance > thirdDistance)
                {
                    return (0.5) * firstDistance * thirdDistance;
                }
                else
                {
                    return (0.5) * firstDistance * secondDistance;
                }
            }           
        }
    }
}
