using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTrianlges
{
    class ArbitraryTriangle : Triangle, ISquare
    {
        public double GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}
