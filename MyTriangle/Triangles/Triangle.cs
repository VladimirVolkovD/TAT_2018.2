using System;

namespace MyTrianlges
{
    abstract class Triangle
    {
        public double firstDistance;
        public double secondDistance;
        public double thirdDistance;     

        public virtual double GetSquare()
        {
            double semiPerimeter = (firstDistance + secondDistance + thirdDistance) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - firstDistance) * (semiPerimeter - secondDistance) * (semiPerimeter - thirdDistance));
        }
    }
}
