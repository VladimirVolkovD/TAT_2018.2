using System;

namespace DEV8
{
    /// <summary>
    /// AllCounter implements method for command selection of specific type for object being transferred.
    /// </summary>
    class AllCounter : ICommand
    {
        private VehiclesStorage VehiclesStorage;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="vehiclesStorage">Vehicle storage.</param>
        public AllCounter(VehiclesStorage vehiclesStorage)
        {
            VehiclesStorage = vehiclesStorage;
        }

        /// <summary>
        ///  Execute this instance.
        /// </summary>       
        public void Execute()
        {
            VehiclesStorage.AllCounter();
        }
    }
}
