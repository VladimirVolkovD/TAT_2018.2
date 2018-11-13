using System;

namespace DEV5
{
    /// <summary>
    /// Average price counter implementins method for command selection of specific type for object being transferred.
    /// </summary>
    class AveragePriceCounter : Icountable 
    {

        /// <summary>
        /// Defined type of object and invokes AveragePriceCounter method for object.
        /// </summary>
        /// <param name="storageOfProduct">Object of ProductStorage class.</param>
        /// <param name="arg">Brand for average price calculation.</param>
        public void Execute(ProductStorage<Product> storageOfProduct, string arg = null)
        {
            try
            {
                storageOfProduct.AveragePriceCounter(arg);                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Build error: " + ex.Message);
            }
        }
    }
}

