using System.Collections.Generic;

namespace DEV5
{
    class CommandHandler 
    {
        public CommandHandler()
        {
        }

        public CommandHandler(List<Car> list)
        {
            AllCounter allCounter = new AllCounter();
            AveragePriceCounter averagePriceCounter = new AveragePriceCounter();
            TypesCounter typesCounter = new TypesCounter();

            allCounter.Count(list);
            averagePriceCounter.Count(list,"lada");
            averagePriceCounter.Count(list);
            typesCounter.Count(list);
            System.Console.ReadKey();
        }
    }
}

