using System;
using Car;

namespace list
{
    class EntryPoint
    {
        static void Main()
        {
            var test1 = new MyList();
            var mazerati = new Car.Car("Z5", "mazerati", "Black");
            test1.Add(mazerati);
            
            var lada = new Car.Car("Z5", "lada", "green");
            test1.Add(lada);

            var minsk = new Car.Car("m 125", "minsk", "blue");
            test1.AddHead(minsk);
            
            var test1Searched = test1.Search(lada);
            test1Searched.Out();
            Console.ReadKey();
        }
    }
}
