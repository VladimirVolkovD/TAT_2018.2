using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV5
{

    class AllCounter : Icountable
    {
        public void Execute(ProductStorage cars, string arg = null)
        {
            if (cars is CarsStorage)
            {
                cars.AllCarsCounter();
            }
        }        
    }
}
