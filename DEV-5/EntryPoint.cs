using System;
using System.Collections.Generic;

namespace DEV5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            CarCreator CarBuilder = new CarCreator();
            CommandHandler commandHandler = new CommandHandler();
            do
            {
                cars.Add(CarBuilder.Create());
                Console.Write("Press Esc to end input cars, or any key to continue.\n");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            CommandHandler newCommandHandler = new CommandHandler(cars);
        }
    }
}
