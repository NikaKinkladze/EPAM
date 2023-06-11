using vechileparts;
using vechiles;

namespace solution
{
    public class Solution
    {
        public static void AllVechiles()
        {
            List<object> vechiles = new List<object>();

            PassengerCar car = new PassengerCar()
            {
                engine = new Engine() { Power = 1000, SerialNumber = 123412, Type = "Gasoline", Volume = "low" },
                chasis = new Chasis() { WheelsNumber = 4, Number = "VV-566-TT", PermissableLoad = 500 },
                transmission = new Transmission() { Type = "Manual", Manufacturer = "Dodge", NumberOfGears = 6 },

            };

            Scooter scooter = new Scooter()
            {
                engine = new Engine() { Power = 50, SerialNumber = 176412, Type = "Electric", Volume = "Very low" },
                chasis = new Chasis() { WheelsNumber = 2, Number = "BB-566-FF", PermissableLoad = 50 },
                transmission = new Transmission() { Type = "Automatic", Manufacturer = "Honda", NumberOfGears = 2 },

            };

            Bus bus = new Bus()
            {
                engine = new Engine() { Power = 1900, SerialNumber = 186542, Type = "Gasoline", Volume = "High" },
                chasis = new Chasis() { WheelsNumber = 8, Number = "KK-243-RR", PermissableLoad = 1500 },
                transmission = new Transmission() { Type = "Manual", Manufacturer = "Mercedes", NumberOfGears = 6 },

            };

            Truck truck = new Truck()
            {
                engine = new Engine() { Power = 2000, SerialNumber = 654729, Type = "Diesel", Volume = "very high" },
                chasis = new Chasis() { WheelsNumber = 6, Number = "GG-642-TT", PermissableLoad = 2000 },
                transmission = new Transmission() { Type = "Manual", Manufacturer = "Ford", NumberOfGears = 6 },

            };

            vechiles.Add(car);
            vechiles.Add(scooter);
            vechiles.Add(truck);
            vechiles.Add(bus);


            foreach (var vechile in vechiles)
            {
                if (vechile is PassengerCar)
                {
                    Console.WriteLine("Passenger car:");
                    Console.WriteLine("              Engine: ");
                    Console.WriteLine("                     Power: " + ((PassengerCar)vechile).engine.Power);
                    Console.WriteLine("                     Type: " + ((PassengerCar)vechile).engine.Type);
                    Console.WriteLine("                     Volume: " + ((PassengerCar)vechile).engine.Volume);
                    Console.WriteLine("                     SerialNumber: " + ((PassengerCar)vechile).engine.SerialNumber);
                    Console.WriteLine("              Chasis: ");
                    Console.WriteLine("                     Wheels number: " + ((PassengerCar)vechile).chasis.WheelsNumber);
                    Console.WriteLine("                     Number: " + ((PassengerCar)vechile).chasis.Number);
                    Console.WriteLine("                     Permissable load: " + ((PassengerCar)vechile).chasis.PermissableLoad);
                    Console.WriteLine("              Transmission: ");
                    Console.WriteLine("                           Type: " + ((PassengerCar)vechile).transmission.Type);
                    Console.WriteLine("                           Number of gears: " + ((PassengerCar)vechile).transmission.NumberOfGears);
                    Console.WriteLine("                           Manufacturer: " + ((PassengerCar)vechile).transmission.Manufacturer);
                    Console.WriteLine();
                }
                else if (vechile is Truck)
                {
                    Console.WriteLine("Truck:");
                    Console.WriteLine("              Engine: ");
                    Console.WriteLine("                     Power: " + ((Truck)vechile).engine.Power);
                    Console.WriteLine("                     Type: " + ((Truck)vechile).engine.Type);
                    Console.WriteLine("                     Volume: " + ((Truck)vechile).engine.Volume);
                    Console.WriteLine("                     SerialNumber: " + ((Truck)vechile).engine.SerialNumber);
                    Console.WriteLine("              Chasis: ");
                    Console.WriteLine("                     Wheels number: " + ((Truck)vechile).chasis.WheelsNumber);
                    Console.WriteLine("                     Number: " + ((Truck)vechile).chasis.Number);
                    Console.WriteLine("                     Permissable load: " + ((Truck)vechile).chasis.PermissableLoad);
                    Console.WriteLine("              Transmission: ");
                    Console.WriteLine("                           Type: " + ((Truck)vechile).transmission.Type);
                    Console.WriteLine("                           Number of gears: " + ((Truck)vechile).transmission.NumberOfGears);
                    Console.WriteLine("                           Manufacturer: " + ((Truck)vechile).transmission.Manufacturer);
                    Console.WriteLine();
                }
                else if (vechile is Bus)
                {
                    Console.WriteLine("Bus:");
                    Console.WriteLine("              Engine: ");
                    Console.WriteLine("                     Power: " + ((Bus)vechile).engine.Power);
                    Console.WriteLine("                     Type: " + ((Bus)vechile).engine.Type);
                    Console.WriteLine("                     Volume: " + ((Bus)vechile).engine.Volume);
                    Console.WriteLine("                     SerialNumber: " + ((Bus)vechile).engine.SerialNumber);
                    Console.WriteLine("              Chasis: ");
                    Console.WriteLine("                     Wheels number: " + ((Bus)vechile).chasis.WheelsNumber);
                    Console.WriteLine("                     Number: " + ((Bus)vechile).chasis.Number);
                    Console.WriteLine("                     Permissable load: " + ((Bus)vechile).chasis.PermissableLoad);
                    Console.WriteLine("              Transmission: ");
                    Console.WriteLine("                           Type: " + ((Bus)vechile).transmission.Type);
                    Console.WriteLine("                           Number of gears: " + ((Bus)vechile).transmission.NumberOfGears);
                    Console.WriteLine("                           Manufacturer: " + ((Bus)vechile).transmission.Manufacturer);
                    Console.WriteLine();
                }
                else if (vechile is Scooter)
                {
                    Console.WriteLine("Scooter:");
                    Console.WriteLine("              Engine: ");
                    Console.WriteLine("                     Power: " + ((Scooter)vechile).engine.Power);
                    Console.WriteLine("                     Type: " + ((Scooter)vechile).engine.Type);
                    Console.WriteLine("                     Volume: " + ((Scooter)vechile).engine.Volume);
                    Console.WriteLine("                     SerialNumber: " + ((Scooter)vechile).engine.SerialNumber);
                    Console.WriteLine("              Chasis: ");
                    Console.WriteLine("                     Wheels number: " + ((Scooter)vechile).chasis.WheelsNumber);
                    Console.WriteLine("                     Number: " + ((Scooter)vechile).chasis.Number);
                    Console.WriteLine("                     Permissable load: " + ((Scooter)vechile).chasis.PermissableLoad);
                    Console.WriteLine("              Transmission: ");
                    Console.WriteLine("                           Type: " + ((Scooter)vechile).transmission.Type);
                    Console.WriteLine("                           Number of gears: " + ((Scooter)vechile).transmission.NumberOfGears);
                    Console.WriteLine("                           Manufacturer: " + ((Scooter)vechile).transmission.Manufacturer);
                    Console.WriteLine();
                }
            }
        }
    }
}
