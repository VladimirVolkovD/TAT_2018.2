using System;
using System.Collections.Generic;

namespace DEV8
{
    /// <summary>
    /// Command handler implements command processing
    /// and invoking required methods.
    /// </summary>
    class CommandHandler
    {
        private ICommand _command;
        private readonly VehiclesStorage _carsStorage;
        private readonly VehiclesStorage _truckStogare;
        private VehiclesStorage _currentStorage;
        private readonly Stack<ICommand> _commandsHistory = new Stack<ICommand>();

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="carsStorage">Cars storage.</param>
        /// <param name="truckStogare">Trucks storage.</param>
        public CommandHandler(VehiclesStorage carsStorage, VehiclesStorage truckStogare)
        {
            _carsStorage = carsStorage;
            _truckStogare = truckStogare;
        }

        /// <summary>
        /// Shows the commands and invokes the required method entered from the keyboard.
        /// </summary>
        public void Show()
        {
            Console.Write("Enter the command for vehicle:\n  -Count_types Car(Truck)\n  -Сount_all Car(Truck)" +
                    "\n  -Average_price Car(Truck)\n  -Average_price 'Type' Car(Truck)\n  -Execute\n  -Exit\n");
            var flag = true;
            while (flag)
            {
                Console.Write(">");
                _command = null;
                var inputStrings = Console.ReadLine()?.Split(' ');
                var commands = GetCommand(inputStrings);  
                switch (commands)
                {
                    case Commands.Count_types:
                        _commandsHistory.Push(new BrandsCounter(_currentStorage));
                        break;
                    case Commands.Count_all:
                        _commandsHistory.Push(new AllCounter(_currentStorage));
                        break;
                    case Commands.Average_price:
                        _commandsHistory.Push(new AveragePriceCounter(_currentStorage));
                        break;
                    case Commands.Average_priceType:
                        _commandsHistory.Push(new AveragePriceCounter(_currentStorage, inputStrings[2]));
                        break;
                    case Commands.Execute:
                        var commandsHistoryBuffer = new Stack<ICommand>(_commandsHistory);
                        while (commandsHistoryBuffer.Count > 0)
                        {
                            commandsHistoryBuffer.Pop().Execute();
                        }
                        break;
                    case Commands.Exit:
                        flag = false;
                        break;
                    case Commands.UnknownCommand:
                        Console.Write("Unknown command. Try again.");
                        break;
                }
            }          
        }

        /// <summary>
        ///  Gets the command.
        /// </summary>
        /// <param name="str">Inputed array of strings.</param>
        /// <returns>The command.</returns>
        private Commands GetCommand(string[] str)
        {
            switch (str.Length)
            {
                case 1 when (str[0].Equals("Execute")):
                    return Commands.Execute;

                case 1 when (str[0].Equals("Exit")):
                    return Commands.Exit;

                case 2 when (str[0].Equals("Count_types")) && ((str[1].Equals("Car")) || (str[1].Equals("Truck")) ):
                    _currentStorage = str[1].Equals("Car") ? _carsStorage : _truckStogare;               
                    return Commands.Count_types;

                case 2 when (str[0].Equals("Count_all")) && ((str[1].Equals("Car")) || (str[1].Equals("Truck"))):
                    _currentStorage = str[1].Equals("Car") ? _carsStorage : _truckStogare;
                    return Commands.Count_all;

                case 2 when (str[0].Equals("Average_price")) && ((str[1].Equals("Car")) || (str[1].Equals("Truck"))):
                    _currentStorage = str[1].Equals("Car") ? _carsStorage : _truckStogare;
                    return Commands.Average_price;

                case 3 when (str[0].Equals("Average_price")):
                    _currentStorage = str[1].Equals("Car") ? _carsStorage : _truckStogare;
                    return Commands.Average_priceType;

                default:
                    return Commands.UnknownCommand;
            }
        }
    }
}





