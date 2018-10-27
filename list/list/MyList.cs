using System;

namespace Car
{ 
    class MyList
    {
        private Node head;

        public MyList()
        {
            Node headNode = new Node();
            head = headNode;
        }

        public MyList(Car headCar)
        {
            Node headNode = new Node(headCar);
            head = headNode;
        }
        
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

        public void AddHead(Car newCar)
        {
            Node currentNode = new Node(newCar);
            currentNode.nextCar = head;
            head.previous = currentNode;
            head = currentNode;
        }

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
