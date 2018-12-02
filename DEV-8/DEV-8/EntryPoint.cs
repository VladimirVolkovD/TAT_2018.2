﻿namespace DEV8
{
    /// <summary>
    /// It's an entry point in the program.
    /// </summary>
    class EntryPoint
    {    
        static void Main(string[] args)
        {
            ParserOfVehicle parser =  ParserOfVehicle.GetInstance();
            VehiclesStorage carsStorage = new VehiclesStorage("Cars",parser.GetVehicleList(args[0]));
            VehiclesStorage truckStogare = new VehiclesStorage("Trucks",parser.GetVehicleList(args[1]));
            CommandHandler commandHandler = new CommandHandler(carsStorage, truckStogare);
            commandHandler.Show();
        }
    }
}
