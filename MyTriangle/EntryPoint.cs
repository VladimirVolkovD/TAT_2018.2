using System;
using MyTriangle.TriangleBuilders;

namespace MyTriangle
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point of the program, where method accepts coordinates of triangle vertices
        /// and show square of triangle.
        /// </summary>
        static void Main()
        {
            try
            {
                TriangleBuilder builder = new RightTriangleBuilder(new EquilateralTriangleBuilder(new ArbitraryTriangleBuilder(null)));
                var AB = new Point(double.Parse(Console.ReadLine()), (double.Parse(Console.ReadLine())));
                var BC = new Point(double.Parse(Console.ReadLine()), (double.Parse(Console.ReadLine())));
                var CA = new Point(double.Parse(Console.ReadLine()), (double.Parse(Console.ReadLine())));
                var myTriangle = builder.CreateTriangle(AB, BC, CA);                
                Console.WriteLine("you triangle is " + myTriangle .GetType() + ":square = " + myTriangle.GetSquare());
                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
                Console.ReadKey();
            }
        }
    }
}
