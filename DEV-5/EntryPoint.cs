namespace DEV5
{
    /// <summary>
    /// It's an entry point in the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            CarsStorage carsStorage = new CarsStorage();
            CommandHandler newCommandHandler = new CommandHandler(carsStorage);            
        }
    }
}
