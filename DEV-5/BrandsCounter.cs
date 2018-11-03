using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV5
{
    /// <summary>
    /// Brands counter implements method for calculate number of cars brands.
    /// </summary>
    class BrandsCounter : Icountable
    {
        /// <summary>
        /// Method for calculate number of cars brands.
        /// </summary>
        /// <param name="cars">Lis of cars.</param>
        public void Execute(ProductStorage cars, string arg = null)
        {
            if (cars is CarsStorage)
            {
                cars.BrandsCounter();
            }
        }
    }
}
