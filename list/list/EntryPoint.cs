using System;

namespace Car
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            MyList test1 = new MyList();
            Car mazerati = new Car("Z5", "mazerati", "Black");
            test1.Add(mazerati);
            
            Car lada = new Car("Z5", "lada", "green");
            test1.Add(lada);

            Car minsk = new Car("m 125", "minsk", "blue");
            test1.AddHead(minsk);
            
            MyList test1Searched = test1.Search(lada);
            test1Searched.Out();
            Console.ReadKey();
        }
    }
}
