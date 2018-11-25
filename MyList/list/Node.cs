namespace Car
{
    /// <summary>
    /// Represents a list element
    /// </summary>
    class Node
    {
        public Car Car { get; set; }
        public Node nextCar {get;  set;}
        public Node previous {get;  set;}

        /// <summary>
        /// Initialize new node with empty fields
        /// </summary>
        public Node()
        {
        }

        /// <summary>
        /// Initialize new node with field Car
        /// </summary>
        /// <param name="newCar">Object to add like value for field car</param>
        public Node(Car newCar)
        {
            Car = newCar;
        }
    }
}
