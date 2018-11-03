using System;

namespace DEV5
{
    /// <summary>
    /// Average price counter implementins method for command selection of specific type for object being transferred.
    /// </summary>
    class AveragePriceCounter : Icountable 
    {

        /// <summary>
        /// Defined type of object and invokes AveragePriceCounter method for object.
        /// </summary>
        /// <param name="cars">Object of ProductStorage class.</param>
        /// <param name="arg">Brand for average price calculation.</param>
        public void Execute(ProductStorage cars, string arg = null)
        {
            try
            {
                if (cars is CarsStorage)
                {
                    cars.AveragePriceCounter(arg);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Build error: " + ex.Message);
            }
        }
    }
}

