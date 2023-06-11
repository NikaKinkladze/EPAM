using CarsClass;

namespace DataBase
{
    public class CarDatabase
    {
        private static CarDatabase instance = null;
        private List<Car> cars;

        private CarDatabase()
        {
            cars = new List<Car>();
        }

        public static CarDatabase Instance
        {
            get
            {
                return instance ?? (instance = new CarDatabase());
            }
        }

        public void AddCar(string brand, string model, int quantity, decimal cost)
        {
            Car car = cars.Find(c => c.Brand == brand && c.Model == model);

            if (car != null)
            {
                car.Quantity += quantity;
                car.Cost = cost;
            }
            else
            {
                car = new Car(brand, model, quantity, cost);
                cars.Add(car);
            }
        }

        public int GetCount()
        {
            int count = 0;

            foreach (Car car in cars)
            {
                count += car.Quantity;
            }

            return count;
        }

        public int GetBrandCount()
        {
            return cars.Count;
        }

        public decimal GetAveragePrice()
        {
            decimal totalCost = 0;
            int count = 0;

            foreach (Car car in cars)
            {
                totalCost += car.Quantity * car.Cost;
                count += car.Quantity;
            }

            return totalCost / count;
        }

        public decimal GetAveragePrice(string brand)
        {
            decimal totalCost = 0;
            int count = 0;

            foreach (Car car in cars)
            {
                if (car.Brand.ToLower() == brand.ToLower())
                {
                    totalCost += car.Quantity * car.Cost;
                    count += car.Quantity;
                }
            }

            return count > 0 ? totalCost / count : 0;
        }

        public void ProcessCommand(string command)
        {
            string[] tokens = command.Split(' ');
            string commandName = tokens[0].ToLower();

            if (commandName == "count" && tokens.Length == 2)
            {
                string arguement = tokens[1].ToLower();

                if (arguement == "all")
                {
                    Console.WriteLine($"Total number of cars: {GetCount()}");
                }
                else if (arguement == "types")
                {
                    Console.WriteLine($"Number of car brands: {GetBrandCount()}");
                }
                else
                {
                    Console.WriteLine("Invalid argument for 'count' command.");
                }
            }
            else if (commandName == "average" && tokens.Length >= 2)
            {
                string arguement = tokens[1].ToLower();

                if (arguement == "price" && tokens.Length == 2)
                {
                    Console.WriteLine($"Average price of all cars: {GetAveragePrice():C}");
                }
                else if (arguement == "price" && tokens.Length == 4 && tokens[2].ToLower() == "type")
                {
                    string brand = tokens[3];
                    Console.WriteLine($"Average price of {brand} cars: {GetAveragePrice(brand):C}");
                }
                else
                {
                    Console.WriteLine("Invalid arguments for 'average' command.");
                }
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }
}
