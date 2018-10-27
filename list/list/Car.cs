namespace Car
{
    class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }

        public Car(string Model, string Brand , string Color)
        {
            this.Model = Model;
            this.Brand = Brand;
            this.Color = Color;   
        }

        public Car(Car Car)
        {
            this.Model = Car.Model;
            this.Brand = Car.Brand;
            this.Color = Car.Color;
        }
    }
}
