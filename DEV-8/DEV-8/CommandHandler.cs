using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV8
{
    /// <summary>
    /// Command handler implements command processing
    /// and invoking required methods.
    /// </summary>
    class CommandHandler
    {
        VehiclesStorage CarsStorage;
        VehiclesStorage TruckStogare;
        VehiclesStorage CurrentStorage;

        ////////////////////////////////////        
        Stack<ICommand> CommandsHistory = new Stack<ICommand>();
        ////////////////////////////////////

        ICommand Command;

        public CommandHandler(VehiclesStorage _CarsStorage, VehiclesStorage _TruckStogare)
        {
            CarsStorage = _CarsStorage;
            TruckStogare = _TruckStogare;
        }

        /// <summary>
        /// Invokes the required method entered from the keyboard.
        /// </summary>
        /// <param name="storageOfProduct">Object of ProductStorage class.</param>
        public void Show()
        {
            try
            {             
                bool flag = true;
                
                Console.WriteLine("Enter the command for vehicle:\n  -Count_types Car(Truck)\n  -Сount_all Car(Truck)" +
                    "\n  -Averagep_price Car(Truck)\n  -Average_PriceType Car(Truck)\n  -Execute\n  -Exit");
                while (flag)
                {
                    Console.Write(">");
                    string[] inputStrings = Console.ReadLine().Split(' ');
                    Commands commands = GetCommand(inputStrings);
                    Command = null;                                     
                    switch (commands)
                    {
                        case Commands.Count_types:                            
                            Command = new BrandsCounter(CurrentStorage);                           
                            break;
                        case Commands.Count_all:
                            Command = new AllCounter(CurrentStorage);
                            break;
                        case Commands.Average_price:
                            Command = new AveragePriceCounter(CurrentStorage);
                            break;
                        case Commands.Average_PriceType:
                            Command = new AveragePriceCounter(CurrentStorage, inputStrings[2]);
                            break;                        
                        case Commands.Execute:
                            Stack<ICommand> CommandsHistoryBuffer = new Stack<ICommand>(CommandsHistory);                            
                            while (CommandsHistoryBuffer.Count > 0)
                            {                                
                                CommandsHistoryBuffer.Pop().Execute();
                            }
                            break;
                        case Commands.Exit:
                            flag = false;
                            break;
                        case Commands.UnknownCommand:
                           Console.Write("Unknown command. Try again.");
                           break;
                    }
                    Command?.Execute();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private Commands GetCommand(string[] str)
        {
            if ( (str.Length == 1) && (str[0].Equals("Execute")) )
            {               
                return Commands.Execute;
            }
            else if ((str.Length == 1) && (str[0].Equals("Exit")))
            {
                return Commands.Exit;
            }
            else if ( (str.Length == 2) && (str[0].Equals("Count_types")) && ((str[1].Equals("Car")) || (str[1].Equals("Truck")) ))
            {
                CurrentStorage = str[1].Equals("Car") ? CarsStorage : TruckStogare;                              
                CommandsHistory.Push(new BrandsCounter(CurrentStorage));                
                return Commands.Count_types;
            }
            else if ((str.Length == 2) && (str[0].Equals("Count_all")) && ((str[1].Equals("Car")) || (str[1].Equals("Truck"))))
            {
                CurrentStorage = str[1].Equals("Car") ? CarsStorage : TruckStogare;
                CommandsHistory.Push(new AllCounter(CurrentStorage));
                return Commands.Count_all;
            }
            else if ((str.Length == 2) && (str[0].Equals("Average_price")) && ((str[1].Equals("Car")) || (str[1].Equals("Truck"))))
            {
                CurrentStorage = str[1].Equals("Car") ? CarsStorage : TruckStogare;
                CommandsHistory.Push(new BrandsCounter(CurrentStorage));
                return Commands.Average_price;
            }
            else if ((str.Length == 3) && (str[0].Equals("Average_price")) )
            {
                CurrentStorage = str[1].Equals("Car") ? CarsStorage : TruckStogare;
                CommandsHistory.Push(new BrandsCounter(CurrentStorage));
                return Commands.Average_PriceType;
            }
            else
            {
                return Commands.UnknownCommand;
            }
        }
    }
}





