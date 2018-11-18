using System;

namespace Car
{
    /// <summary>
    /// MyList class represents  list of objects.
    /// Provides methods to search,  and manipulate list.
    /// </summary>
    class MyList
    {
        /// <summary>
        /// Store for the first element of list
        /// </summary>
        private Node head;

        /// <summary>
        /// Initialize new list without element
        /// </summary>
        public MyList()
        {
            Node headNode = new Node();
            head = headNode;
        }

        /// <summary>
        /// Initialize new list with head element
        /// </summary>
        /// <param name="headCar">Object for adding in head element of list</param>
        public MyList(Car headCar)
        {
            Node headNode = new Node(headCar);
            head = headNode;
        }

        /// <summary>
        ///  Add new element in head of list
        /// </summary>
        /// <param name="newCar">Object for adding in head element of list</param>
        public void AddHead(Car newCar)
        {
            Node currentNode = new Node(newCar);
            currentNode.nextCar = head;
            head.previous = currentNode;
            head = currentNode;
        }

        /// <summary>
        /// Add new element in list
        /// </summary>
        /// <param name="newCar">Object for adding in list</param>
        public void Add(Car newCar)
        {
            if (head.Car == null)
            {
                head = new Node(newCar);
            }
            else
            {
                Node tempNode = head;
                Node newNode = new Node(newCar);
                while (tempNode.nextCar != null)
                {
                    tempNode = tempNode.nextCar;
                }   
                
                tempNode.nextCar = newNode;
                newNode.previous = tempNode;
            }
        }

        /// <summary>
        /// Searches for objects with similar fields to passed object
        /// </summary>
        /// <param name="Car">The fields of this object will be used to search for similar objects.</param>
        /// <returns>List of found objects</returns>
        public MyList Search(Car Car)
        {
            Node currentNode = head;
            MyList SearchResult = new MyList();
            while (currentNode != null)
            {
                if ((currentNode.Car.Brand == Car.Brand) || (currentNode.Car.Color == Car.Color) || (currentNode.Car.Model == Car.Model))
                {
                    SearchResult.Add(new Car(currentNode.Car));
                    currentNode = currentNode.nextCar;
                }
            }

            return SearchResult;
        }

        /// <summary>
        /// display list elements 
        /// </summary>
        public void Out()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine("you car is "+ currentNode.Car.Brand + " model " + currentNode.Car.Model + " color "+ currentNode.Car.Color);
                currentNode = currentNode.nextCar;
            }
        }   
    }
}
