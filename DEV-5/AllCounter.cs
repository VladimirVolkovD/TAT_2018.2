using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV5
{
    class AllCounter : Icountable
    {
        /// <summary>
        /// Method for count all types car.
        /// </summary>
        /// <param name="products">Products.</param>
        /// <param name="arg">Parametr arg.</param>
        public void Count(List<Car> products, string arg = null)
        {
            if (products.Any())
            {
                int count = 0;
                foreach (var product in products)
                {
                    count += product.quantity;
                }
                Console.WriteLine("\nTotal number of cars: " + count);
            }
            else
            {
                throw new ArgumentNullException();
            }    
        }        
    }
}
