using System;

namespace DEV5
{
    /// <summary>
    ///Brands counter implementins method for command selection of specific type for object being transferred.
    /// </summary>
    class BrandsCounter : Icountable
    {
        /// <summary>
        ///  Defined type of object and invokes AveragePriceCounter method for object.
        /// </summary>
        /// <param name="cars">Object of ProductStorage class.</param>
        /// <param name="arg">Unused parameter remaining after inheritance.</param>
        public void Execute(ProductStorage cars, string arg = null)
        {
            try
            {
                if (cars is CarsStorage)
                {
                    cars.BrandsCounter();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Build error: " + ex.Message);
            }
        }
    }
}
