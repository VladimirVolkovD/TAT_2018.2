using System;
using System.Threading;

namespace DEV5
{
    /// <summary>
    /// Represents entity of car.
    /// </summary>
    public class Car : Product
    {
        public string brand { get; }
        public string model { get; }
        public int quantity { get; set;}
        public double unitCost; 

        /// <summary>
        /// Initialize new car object.
        /// </summary>
        /// <param name="brand">Brend of car.</param>
        /// <param name="model">Model of car.</param>
        /// <param name=quantity">Quantity of car.</param>
        /// <param name="unitCost">Cost of one car.</param>
        public Car(string brand, string model, int quantity, string unitCost)
        {
            char separatorOfRealValue = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            this.brand = brand;
            this.model = model;
            this.quantity = quantity;
            if (this.quantity <= 0)
            {
                throw new ArgumentException("Quantity of products must be positive");
            }
            if (!Double.TryParse(unitCost, out this.unitCost))
            {
                unitCost = unitCost.Replace('.', separatorOfRealValue);
                unitCost = unitCost.Replace(',', separatorOfRealValue);
            }
            this.unitCost = Double.Parse(unitCost);
            if (this.unitCost <= 0.0)
            {
                throw new ArgumentException("Price of car must be positive");
            }    
        }        
    }
}

