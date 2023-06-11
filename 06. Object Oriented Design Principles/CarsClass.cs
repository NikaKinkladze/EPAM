namespace CarsClass
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }

        public Car(string brand, string model, int quantity, decimal cost)
        {
            Brand = brand;
            Model = model;
            Quantity = quantity;
            Cost = cost;
        }
    }
}
