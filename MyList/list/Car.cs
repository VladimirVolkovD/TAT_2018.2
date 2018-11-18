namespace Car
{
    /// <summary>
    /// Represents entity of the car
    /// </summary>
    class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }

        /// <summary>
        /// Initialize new car object
        /// </summary>
        /// <param name="Model">Model of car</param>
        /// <param name="Brand">Brend of car</param>
        /// <param name="Color">Color of car</param>
        public Car(string Model, string Brand , string Color)
        {
            this.Model = Model;
            this.Brand = Brand;
            this.Color = Color;   
        }

        /// <summary>
        /// Сreates an object like the one passed
        /// </summary>
        /// <param name="Car">Source object to creating new object with same fields </param>
        public Car(Car Car)
        {
            Model = Car.Model;
            Brand = Car.Brand;
            Color = Car.Color;
        }
    }
}
