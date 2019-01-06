namespace DEV8
{
    /// <summary>
    ///Brands counter implementns method for command selection of specific type for object being transferred.
    /// </summary>
    class BrandsCounter : ICommand
    {
        private readonly VehiclesStorage _vehiclesStorage;

        /// <summary>
        /// Constructor.
        /// </summary>     
        /// <param name="vehiclesStorage">Vehicle storage.</param>
        public BrandsCounter(VehiclesStorage vehiclesStorage)
        {
            _vehiclesStorage = vehiclesStorage;
        }

        /// <summary>
        ///  Execute this instance.
        /// </summary>        
        public void Execute()
        {         
                _vehiclesStorage.BrandsCounter();               
        }       
    }
}
