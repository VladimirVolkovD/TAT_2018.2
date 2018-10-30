using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV5
{
    class TypesCounter : Icountable
    {
        public void Count(List<Car> Cars, string arg = null)
        {
            if (Cars.Any())
            {
                HashSet<string> types = new HashSet<string>();
                foreach (var product in Cars)
                {
                    types.Add(product.brand);
                }
                Console.WriteLine("\nNumber of car brands: " + types.Count);                
            }
            else
            {
                throw new ArgumentNullException();
            }            
        }
    }
}
