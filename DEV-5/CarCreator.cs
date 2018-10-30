using System;

namespace DEV5
{
    public class CarCreator
    {
        public Car Create()
        {
            try
            {
                Console.Write("\nEnter the brand of product: ");
                string brand = Console.ReadLine();

                Console.Write("Enter the name of product: ");
                string model = Console.ReadLine();

                Console.Write("Enter the quantity of product: ");
                int quantity = Int32.Parse(Console.ReadLine());

                Console.Write("Enter the price of product: ");
                string unitCost = Console.ReadLine();

                return new Car(brand, model, quantity, unitCost);
            }
            catch (Exception)
            {
                throw new Exception("Build error");
            }
        }
    }
}
