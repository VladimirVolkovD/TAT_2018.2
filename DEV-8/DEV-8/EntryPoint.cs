namespace DEV8
{
    /// <summary>
    /// It's an entry point in the program.
    /// </summary>
    internal class EntryPoint
    {    
        private static void Main(string[] args)
        {
            var parser =  ParserOfVehicle.GetInstance();
            var carsStorage = new VehiclesStorage("Cars",parser.GetVehicleList(args[0]));
            var truckStogare = new VehiclesStorage("Trucks",parser.GetVehicleList(args[1]));
            var commandHandler = new CommandHandler(carsStorage, truckStogare);
            commandHandler.Show();
        }
    }
}
