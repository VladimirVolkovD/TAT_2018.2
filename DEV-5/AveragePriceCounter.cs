using System;
using System.Collections.Generic;

namespace DEV5
{
    /// <summary>
    /// Average price counter implementins method for calculate price of product.
    /// Can calculate price of product for only one brand.
    /// </summary>
    class AveragePriceCounter : Icountable 
    {
        public void Execute(ProductStorage cars, string arg = null)
        {
            if (cars is CarsStorage)
            {
                cars.AveragePriceCounter(arg);
            }
        }
    }
}

