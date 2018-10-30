using System;
using System.Collections.Generic;

namespace DEV5
{
    class AveragePriceCounter : Icountable
    {
        public void Count(List<Car> cars, string arg = null)
        {
            double result = 0.0;
            var tempCarsList = cars;
            string returnedString = String.Empty;
            if (!string.IsNullOrEmpty(arg) && cars.Exists(product =>  product.brand.Equals(arg)))
            {
                returnedString = "Average cost of a car in the brand " + arg.ToString() + " : ";
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
            Console.Write(returnedString+ " " + (result / tempCarsList.Count));            
        }
    }
}

