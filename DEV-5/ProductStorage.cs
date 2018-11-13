using System.Collections.Generic;

namespace DEV5
{
    /// <summary>
    /// Determines the function for Storage classes.
    /// </summary>
    public class ProductStorage<T>
    {
        public List<Product> storageOfProduct;
        virtual public void AllCarsCounter() {}
        virtual public void AveragePriceCounter(string arg = null) {}
        virtual public void BrandsCounter() {}
    }
}
