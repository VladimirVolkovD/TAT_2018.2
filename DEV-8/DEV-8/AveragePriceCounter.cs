using System;

namespace DEV8
{
    /// <summary>
    /// Average price counter implementins method for command selection of specific type for object being transferred.
    /// </summary>
    class AveragePriceCounter : ICommand
    {
        VehiclesStorage VehiclesStorage;
        string Brand;

        /// <summary>
        /// Constructor.
        /// </summary>     
        /// <param name="vehiclesStorage">Vehicle storage.</param>
        /// <param name="brand">Brand, if necessary</param>
        public AveragePriceCounter(VehiclesStorage vehiclesStorage, string brand = null)
        {
            VehiclesStorage = vehiclesStorage;
            Brand = brand;
        }

        /// <summary>
        ///  Execute this instance.
        /// </summary>       
        public void Execute()
        {
            VehiclesStorage.AveragePriceCounter(Brand);
        }
    }
}

