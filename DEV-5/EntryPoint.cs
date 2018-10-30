using System;
using System.Collections.Generic;

namespace DEV5
{
    /// <summary>
    /// It's an entry point in the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            CarCreator CarBuilder = new CarCreator();
            CommandHandler commandHandler = new CommandHandler();
            Console.Write("Press Esc to end input cars after inputting the fields, or any key to continue.\n");
            do
            {
                try
                {
                    cars.Add(CarBuilder.Create());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Build error: " + ex.Message);
                }           
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            CommandHandler newCommandHandler = new CommandHandler(cars);
        }
    }
}
