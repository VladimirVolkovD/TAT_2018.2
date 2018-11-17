using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTrianlges
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            TriangleBuilder builder = new TriangleBuilder();           
            
            Point AB = new Point(double.Parse(Console.ReadLine()), (double.Parse(Console.ReadLine())));
            Point BC = new Point(double.Parse(Console.ReadLine()), (double.Parse(Console.ReadLine())));
            Point CA = new Point(double.Parse(Console.ReadLine()), (double.Parse(Console.ReadLine())));            

            builder.CreateTriangle(AB, BC, CA);
            System.Console.ReadKey();
        }
    }
}
