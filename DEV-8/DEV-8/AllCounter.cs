using System;

namespace DEV8
{
    /// <summary>
    /// AllCounter implements method for command selection of specific type for object being transferred.
    /// </summary>
    class AllCounter : ICommand
    {
        private VehiclesStorage VehiclesStorage;


        public AllCounter(VehiclesStorage _VehiclesStorage)
        {
            VehiclesStorage = _VehiclesStorage;
        }

        /// <summary>
        ///  Defined type of object and invokes AveragePriceCounter method for object.
        /// </summary>       
        public void Execute()
        {
            VehiclesStorage.AllCounter();
        }
    }
}
