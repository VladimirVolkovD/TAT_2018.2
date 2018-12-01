using System;

namespace DEV8
{
    /// <summary>
    ///Brands counter implementins method for command selection of specific type for object being transferred.
    /// </summary>
    class BrandsCounter : ICommand
    {
        private VehiclesStorage VehiclesStorage;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_VehiclesStorage"></param>
        public BrandsCounter(VehiclesStorage _VehiclesStorage)
        {
            VehiclesStorage = _VehiclesStorage;
        }

        /// <summary>
        ///  Defined type of object and invokes BrandsCounter method for object.
        /// </summary>       
        public void Execute()
        {         
                VehiclesStorage.BrandsCounter();               
        }       
    }
}
