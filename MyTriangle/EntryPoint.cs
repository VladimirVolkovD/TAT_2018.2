using System;

namespace MyTrianlges
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                TriangleBuilder builder = new RightTriangleBuilder(new EquilateralTriangleBuilder(new ArbitraryTriangleBuilder(null)));
                Point AB = new Point(double.Parse(Console.ReadLine()), (double.Parse(Console.ReadLine())));
                Point BC = new Point(double.Parse(Console.ReadLine()), (double.Parse(Console.ReadLine())));
                Point CA = new Point(double.Parse(Console.ReadLine()), (double.Parse(Console.ReadLine())));

                Triangle myTriangle = builder.CreateTriangle(AB, BC, CA);                
                System.Console.WriteLine("square = " + myTriangle.GetSquare());
                System.Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
                System.Console.ReadKey();
            }
        }
    }
}
