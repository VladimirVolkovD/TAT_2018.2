using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTrianlges
{
    class RightTriangle : Triangle, ISquare
    {
        public double GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}
