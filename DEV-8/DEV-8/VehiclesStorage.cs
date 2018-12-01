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
        string TypeOfVehicle;
        public List<Vehicle> Vehicles { get;}

        /// <summary>
        /// Constructor for VehiclesStorage class.
        /// Adds new cars to the cars list.
        /// </summary>
        public VehiclesStorage(string typeOfVehicle ,List<Vehicle> newList)
        {
            TypeOfVehicle = typeOfVehicle;
            Vehicles = newList;        
        }

        /// <summary>
        /// Method for count all types of vehicles.
        /// </summary>
        public void AllCounter()
        {
            int quantityOfAllVehicles = Vehicles.Select(i => i.Quantity).Sum(x => x);
            Console.Write("Total number of "+ TypeOfVehicle+ ": " + quantityOfAllVehicles + "\n");
            
        }

        /// <summary>
        /// Method for calculate price of vehicles
        /// or calculate price of vehicles for only one brand.
        /// </summary>
        /// <param name="arg">Brand for calculate(if necessary).</param>
        public void AveragePriceCounter(string arg = null)
        {
            double result = 0.0;
            var tempCarsList = Vehicles;
            string returnedString = String.Empty;
            if (!string.IsNullOrEmpty(arg) && Vehicles.Exists(product => product.Brand.Equals(arg)))
            {
                returnedString = "Average cost of a " + TypeOfVehicle + " in the brand " + arg.ToString() + ": ";
                tempCarsList = Vehicles.FindAll(product => product.Brand.Equals(arg));
            }
            else
            {
                returnedString = "Average " + TypeOfVehicle + " cost: ";
            }
            foreach (var product in tempCarsList)
            {
                result += product.unitCost;
            }
            Console.Write(returnedString + " " + (result / tempCarsList.Count) + "\n");
        }

        /// <summary>
        /// Method for calculate number of vehicles brands.
        /// </summary>
        public void BrandsCounter()
        {
            int quantityOfBrands = Vehicles.GroupBy(i => i.Brand).Count();
            Console.Write("Number of " + TypeOfVehicle + " brands: " + quantityOfBrands + "\n");
        }
    }
}

               
             

