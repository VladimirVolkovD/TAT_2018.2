namespace DEV5
{
    /// <summary>
    /// Determines the function of counting.
    /// </summary>
    public interface Icountable
    {
        void Execute(ProductStorage<Product> storageOfProduct, string arg = null);
    }
}
