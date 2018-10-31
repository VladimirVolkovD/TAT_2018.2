using System;
using System.Collections.Generic;

namespace DEV5
{
    /// <summary>
    /// Command handler implements command processing
    /// and invoking required methods.
    /// </summary>
    class CommandHandler
    {
        public CommandHandler()
        {
        } 

        public CommandHandler(List<Car> Cars)
        {
            try
            {               
                bool flag = true;
                Console.WriteLine("\nEnter the command for cars (count brands, count all, average price, average price 'brand', exit)");

                while (flag)
                {
                    Console.Write(">");
                    string caseSwitch = Console.ReadLine();
                    string brand = string.Empty;
                    //find brand for average price brand
                    if (caseSwitch.Length > "average price ".Length)
                    {
                        brand = caseSwitch.Substring("average price ".Length);
                        caseSwitch = caseSwitch.Remove("average price ".Length, caseSwitch.Length - "average price ".Length);
                    }
                    switch (caseSwitch)
                    {
                        case "count brands":
                            BrandsCounter typesCounter = new BrandsCounter();
                            typesCounter.Count(Cars);
                            break;
                        case "count all":
                            AllCounter allCounter = new AllCounter();
                            allCounter.Count(Cars); ;
                            break;
                        case "average price":
                            AveragePriceCounter averagePriceCounter = new AveragePriceCounter();
                            averagePriceCounter.Count(Cars); ;
                            break;
                        case "average price ":
                            AveragePriceCounter averagePriceCounterType = new AveragePriceCounter();
                            averagePriceCounterType.Count(Cars,brand.Trim());
                            break;
                        case "exit":
                            flag = false;
                            break;
                        default:
                            Console.Write("Unknown command. Try again.");
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
        
        
        
