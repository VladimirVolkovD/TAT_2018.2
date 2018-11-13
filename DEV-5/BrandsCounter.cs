using System;

namespace DEV5
{
    /// <summary>
    ///Brands counter implementins method for command selection of specific type for object being transferred.
    /// </summary>
    class BrandsCounter : Icountable
    {
        /// <summary>
        ///  Defined type of object and invokes AveragePriceCounter method for object.
        /// </summary>
        /// <param name="storageOfProduct">Object of ProductStorage class.</param>
        /// <param name="arg">Unused parameter remaining after inheritance.</param>
        public void Execute(ProductStorage<Product> storageOfProduct, string arg = null)
        {
            try
            {
                storageOfProduct.BrandsCounter();               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Build error: " + ex.Message);
            }
        }
    }
}
