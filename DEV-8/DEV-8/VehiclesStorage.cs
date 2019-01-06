using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV8
{
    /// <summary>
    /// Store vehicles list,
    /// engaged in the addition of new vehicle,
    /// and implements some methods counting.
    /// </summary>
    public class VehiclesStorage 
    {
        private readonly string _typeOfVehicle;
        public List<Vehicle> Vehicles { get;}

        /// <summary>
        /// Constructor for VehiclesStorage class.
        /// Adds new cars to the cars list.
        /// </summary>
        public VehiclesStorage(string typeOfVehicle ,List<Vehicle> newList)
        {
            _typeOfVehicle = typeOfVehicle;
            Vehicles = newList;        
        }

        /// <summary>
        /// Method for count all types of vehicles.
        /// </summary>
        public void AllCounter()
        {
            var quantityOfAllVehicles = Vehicles.Select(i => i.Quantity).Sum(x => x);
            Console.Write("Total number of "+ _typeOfVehicle+ ": " + quantityOfAllVehicles + "\n");            
        }

        /// <summary>
        /// Method for calculate price of vehicles
        /// or calculate price of vehicles for only one brand.
        /// </summary>
        /// <param name="arg">Brand for calculate(if necessary).</param>
        public void AveragePriceCounter(string arg = null)
        {
            var result = 0.0;
            var tempCarsList = Vehicles;
            string returnedString;
            if (!string.IsNullOrEmpty(arg) && Vehicles.Exists(product => product.Brand.Equals(arg)))
            {
                returnedString = "Average cost of a " + _typeOfVehicle + " with the brand " + arg + ": ";
                tempCarsList = Vehicles.FindAll(product => product.Brand.Equals(arg));
            }
            else
            {
                returnedString = "Average " + _typeOfVehicle + " cost: ";
            }
            foreach (var product in tempCarsList)
            {
                result += product.UnitCost;
            }
            Console.Write(returnedString + " " + (result / tempCarsList.Count) + "\n");
        }

        /// <summary>
        /// Method for calculate number of vehicles brands.
        /// </summary>
        public void BrandsCounter()
        {
            var quantityOfBrands = Vehicles.GroupBy(i => i.Brand).Count();
            Console.Write("Number of " + _typeOfVehicle + " brands: " + quantityOfBrands + "\n");
        }
    }
}

               
             

