namespace Car
{
    class Node
    {
        public Car Car { get; set; }
        public Node nextCar {get;  set;}
        public Node previous {get;  set;}

        public Node()
        {

        }

        public Node(Car newCar)
        {
            Car = newCar;
        }
    }
}
