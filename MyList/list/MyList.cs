using System;
using Car;

namespace list
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
        private Node _head;

        /// <summary>
        /// Initialize new list without element
        /// </summary>
        public MyList()
        {
            var headNode = new Node();
            _head = headNode;
        }

        /// <summary>
        /// Initialize new list with head element
        /// </summary>
        /// <param name="headCar">Object for adding in head element of list</param>
        public MyList(Car.Car headCar)
        {
            var headNode = new Node(headCar);
            _head = headNode;
        }

        /// <summary>
        ///  Add new element in head of list
        /// </summary>
        /// <param name="newCar">Object for adding in head element of list</param>
        public void AddHead(Car.Car newCar)
        {
            var currentNode = new Node(newCar);
            currentNode.NextCar = _head;
            _head.Previous = currentNode;
            _head = currentNode;
        }

        /// <summary>
        /// Add new element in list
        /// </summary>
        /// <param name="newCar">Object for adding in list</param>
        public void Add(Car.Car newCar)
        {
            if (_head.Car == null)
            {
                _head = new Node(newCar);
            }
            else
            {
                Node tempNode = _head;
                var newNode = new Node(newCar);
                while (tempNode.NextCar != null)
                {
                    tempNode = tempNode.NextCar;
                }   
                
                tempNode.NextCar = newNode;
                newNode.Previous = tempNode;
            }
        }

        /// <summary>
        /// Searches for objects with at least one similar fields to passed object.
        /// </summary>
        /// <param name="Car">The fields of this object will be used to search for similar objects.</param>
        /// <returns>List of found objects</returns>
        public MyList Search(Car.Car Car)
        {
            Node currentNode = _head;
            var searchResult = new MyList();
            while (currentNode != null)
            {
                if ((currentNode.Car.Brand == Car.Brand) || (currentNode.Car.Color == Car.Color) || (currentNode.Car.Model == Car.Model))
                {
                    searchResult.Add(new Car.Car(currentNode.Car));
                }
                currentNode = currentNode.NextCar;
            }

            return searchResult;
        }

        /// <summary>
        /// display list elements 
        /// </summary>
        public void Out()
        {
            Node currentNode = _head;
            while (currentNode != null)
            {
                Console.WriteLine("you car is "+ currentNode.Car.Brand + " model " + currentNode.Car.Model + " color "+ currentNode.Car.Color);
                currentNode = currentNode.NextCar;
            }
        }   
    }
}
