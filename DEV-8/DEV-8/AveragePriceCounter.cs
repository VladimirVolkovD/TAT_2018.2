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


        public AveragePriceCounter(VehiclesStorage vehiclesStorage, string brand = null)
        {
            VehiclesStorage = vehiclesStorage;
            Brand = brand;
        }

        /// <summary>
        ///  Defined type of object and invokes AveragePriceCounter method for object.
        /// </summary>       
        public void Execute()
        {
            VehiclesStorage.AveragePriceCounter(Brand);
        }
    }
}

