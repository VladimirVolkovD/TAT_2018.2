namespace DEV8
{
    /// <summary>
    /// AllCounter implements method for command selection of specific type for object being transferred.
    /// </summary>
    class AllCounter : ICommand
    {
        private readonly VehiclesStorage _vehiclesStorage;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="vehiclesStorage">Vehicle storage.</param>
        public AllCounter(VehiclesStorage vehiclesStorage)
        {
            _vehiclesStorage = vehiclesStorage;
        }

        /// <summary>
        ///  Execute this instance.
        /// </summary>       
        public void Execute()
        {
            _vehiclesStorage.AllCounter();
        }
    }
}
