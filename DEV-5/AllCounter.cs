using System;

namespace DEV5
{
    /// <summary>
    /// AllCounter implements method for command selection of specific type for object being transferred.
    /// </summary>
    class AllCounter : Icountable
    {
        /// <summary>
        ///  Defined type of object and invokes AveragePriceCounter method for object.
        /// </summary>
        /// <param name="cars">Object of ProductStorage class.</param>
        /// <param name="arg">unused parameter remaining after inheritance.</param>
        public void Execute(ProductStorage cars, string arg = null)
        {
            try
            {
                if (cars is CarsStorage)
                {
                    cars.AllCarsCounter();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Build error: " + ex.Message);
            }
}        
    }
}
