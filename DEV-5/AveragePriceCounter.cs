using System;
using System.Collections.Generic;

namespace DEV5
{
    /// <summary>
    /// Average price counter implementins method for calculate price of cars.
    /// Can calculate price of cars for only one brand.
    /// </summary>
    class AveragePriceCounter : Icountable
    {
        /// <summary>
        /// Method for calculate price of cars
        /// or calculate price of cars for only one brand.
        /// </summary>
        /// <param name="cars">Lis of cars.</param>
        /// <param name="arg">Brand for calculate(if necessary).</param>
        public void Count(List<Car> cars, string arg = null)
        {
            double result = 0.0;
            var tempCarsList = cars;
            string returnedString = String.Empty;
            if (!string.IsNullOrEmpty(arg) && cars.Exists(product =>  product.brand.Equals(arg)))
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
            Console.Write(returnedString+ " " + (result / tempCarsList.Count) + "\n");            
        }
    }
}

