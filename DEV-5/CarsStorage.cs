using System;
using System.Collections.Generic;

namespace DEV5
{
    /// <summary>
    /// Store cars list,
    /// engaged in the addition of new car,
    /// and implements some methods counting.
    /// </summary>
    public class CarsStorage : ProductStorage
    {
        public List<Car> cars { get;}

        /// <summary>
        /// Constructor for CarsStorage class.
        /// Adds new cars to the cars list.
        /// </summary>
        public CarsStorage()
        {
            cars = new List<Car>();
            Console.Write("Press Esc to end input cars after inputting the fields, or any key to continue.\n");
            do
            {
                try
                {
                    Console.Write("\nEnter the brand of product: ");
                    string brand = Console.ReadLine().Trim();

                    Console.Write("Enter the name of product: ");
                    string model = Console.ReadLine().Trim();

                    Console.Write("Enter the quantity of product: ");
                    int quantity = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter the price of product: ");
                    string unitCost = Console.ReadLine();

                    Car currenttCar = new Car(brand, model, quantity, unitCost);
                    cars.Add(currenttCar);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Build error: " + ex.Message);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Method for count all types of cars.
        /// </summary>
        override public void AllCarsCounter()
        {
            if (cars.Count > 0)
            {
                int count = 0;
                foreach (var product in cars)
                {
                    count += product.quantity;
                }
                Console.Write("Total number of cars: " + count + "\n");
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Method for calculate price of cars
        /// or calculate price of cars for only one brand.
        /// </summary>
        /// <param name="arg">Brand for calculate(if necessary).</param>
        override public void AveragePriceCounter(string arg = null)
        {
            double result = 0.0;
            var tempCarsList = cars;
            string returnedString = String.Empty;
            if (!string.IsNullOrEmpty(arg) && cars.Exists(product => product.brand.Equals(arg)))
            {
                returnedString = "Average cost of a car in the brand " + arg.ToString() + ": ";
                tempCarsList = cars.FindAll(product => product.brand.Equals(arg));
            }
            else
            {
                returnedString = "Average cars cost: ";
            }
            foreach (var product in tempCarsList)
            {
                result += product.unitCost;
            }
            Console.Write(returnedString + " " + (result / tempCarsList.Count) + "\n");
        }

        /// <summary>
        /// Method for calculate number of cars brands.
        /// </summary>
        override public void BrandsCounter()
        {
            if (cars.Count > 0)
            {
                HashSet<string> brands = new HashSet<string>();
                foreach (var product in cars)
                {
                    brands.Add(product.brand);
                }
                Console.Write("Number of car brands: " + brands.Count + "\n");
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}

               
             

