namespace DEV8
{
    /// <summary>
    /// Average price counter implements method for command selection of specific type for object being transferred.
    /// </summary>
    class AveragePriceCounter : ICommand
    {
        private readonly VehiclesStorage _vehiclesStorage;
        private readonly string _brand;

        /// <summary>
        /// Constructor.
        /// </summary>     
        /// <param name="vehiclesStorage">Vehicle storage.</param>
        /// <param name="brand">Brand, if necessary</param>
        public AveragePriceCounter(VehiclesStorage vehiclesStorage, string brand = null)
        {
            _vehiclesStorage = vehiclesStorage;
            _brand = brand;
        }

        /// <summary>
        ///  Execute this instance.
        /// </summary>       
        public void Execute()
        {
            _vehiclesStorage.AveragePriceCounter(_brand);
        }
    }
}

