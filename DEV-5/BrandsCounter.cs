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
        /// <param name="arg"></param>
        public void Count(List<Car> cars, string arg = null)
        {
            if (cars.Any())
            {
                HashSet<string> brands = new HashSet<string>();
                foreach (var product in cars)
                {
                    brands.Add(product.brand);
                }
                Console.Write("Number of car brands: " + brands.Count +"\n");                
            }
            else
            {
                throw new ArgumentNullException();
            }            
        }
    }
}
