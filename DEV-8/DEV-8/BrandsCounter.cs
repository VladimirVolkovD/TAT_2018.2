namespace DEV8
{
    /// <summary>
    ///Brands counter implementins method for command selection of specific type for object being transferred.
    /// </summary>
    class BrandsCounter : ICommand
    {
        private VehiclesStorage VehiclesStorage;

        /// <summary>
        /// Constructor.
        /// </summary>     
        /// <param name="vehiclesStorage">Vehicle storage.</param>
        public BrandsCounter(VehiclesStorage vehiclesStorage)
        {
            VehiclesStorage = vehiclesStorage;
        }

        /// <summary>
        ///  Execute this instance.
        /// </summary>        
        public void Execute()
        {         
                VehiclesStorage.BrandsCounter();               
        }       
    }
}
