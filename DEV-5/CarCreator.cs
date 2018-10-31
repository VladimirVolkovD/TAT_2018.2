using System;

namespace DEV5
{
    /// <summary>
    /// Car сreator class.
    /// </summary>
    public class CarCreator
    {
        /// <summary>
        /// Creats new car.
        /// </summary>
        /// <returns>New car.</returns>
        public Car Create()
        {
            Console.Write("\nEnter the brand of product: ");
            string brand = Console.ReadLine().Trim();

            Console.Write("Enter the name of product: ");
            string model = Console.ReadLine().Trim();

            Console.Write("Enter the quantity of product: ");
            int quantity = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the price of product: ");
            string unitCost = Console.ReadLine();

            return new Car(brand, model, quantity, unitCost);
        }
    }
}

