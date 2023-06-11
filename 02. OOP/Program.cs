using System;
using VechileParts;
using Vechile;

class Program
{
    static void Main(String[] args)
    {
        PassengerCar car = new PassengerCar
        {   
            engine = new Engine { Power = 300, Volume = "High", Type = "Diesel", SerialNumber = 3345123 },
            chasis = new Chasis { WheelsNumber = 4, Number = "zp-100-to", PermissableLoad = 1000 },
            transmission = new Transmission { Type = "Manual", NumberOfGears = 5, Manufacturer = "Chevrolette" },
            Model = "Chevrolette"
        };

        Bus bus = new Bus
        {
            engine = new Engine { Power = 200, Volume = "Medium", Type = "Petrol", SerialNumber = 2889845 },
            chasis = new Chasis { WheelsNumber = 8, Number = "tg-123-vd", PermissableLoad = 2500 },
            transmission = new Transmission { Type = "Manual", NumberOfGears = 5, Manufacturer = "Mercedes" },
            Model = "Mercedes"
        };

        Truck truck = new Truck
        {
            engine = new Engine { Power = 250, Volume = "Very high", Type = "Petrol", SerialNumber = 5184156 },
            chasis = new Chasis { WheelsNumber = 8, Number = "sd-123-gf", PermissableLoad = 5000 },
            transmission = new Transmission { Type = "Manual", NumberOfGears = 5, Manufacturer = "Ford" },
            Model = "Ford"
        };

        Scooter scooter = new Scooter
        {
            engine = new Engine { Power = 50, Volume = "Very low", Type = "Electricity", SerialNumber = 5787245 },
            chasis = new Chasis { WheelsNumber = 2, Number = "sd-234-gx", PermissableLoad = 100 },
            transmission = new Transmission { Type = "Auto", NumberOfGears = 2, Manufacturer = "Honda" },
            Model = "Honda"
        };

        Console.WriteLine($"Passenger car Model = {car.Model}");
        Console.WriteLine("");
        Console.WriteLine($"Engine:");
        Console.WriteLine($"             Power = {car.engine.Power}");
        Console.WriteLine($"             Volume = {car.engine.Volume}");
        Console.WriteLine($"             Type = {car.engine.Type}");
        Console.WriteLine($"             Serial Number = {car.engine.SerialNumber}");

        Console.WriteLine("");

        Console.WriteLine($"Chasis:");
        Console.WriteLine($"             Wheels Number = {car.chasis.WheelsNumber}");
        Console.WriteLine($"             Number = {car.chasis.Number}");
        Console.WriteLine($"             Permissable load = {car.chasis.PermissableLoad}");

        Console.WriteLine("");

        Console.WriteLine($"Transmission: ");
        Console.WriteLine($"             Type = {car.transmission.Type}");
        Console.WriteLine($"             Number of gears = {car.transmission.NumberOfGears}");
        Console.WriteLine($"             Manufacturer = {car.transmission.Manufacturer}");

        Console.WriteLine("");

        Console.WriteLine($"Bus Model = {bus.Model}");
        Console.WriteLine("");
        Console.WriteLine($"Engine:");
        Console.WriteLine($"             Power = {bus.engine.Power}");
        Console.WriteLine($"             Volume = {bus.engine.Volume}");
        Console.WriteLine($"             Type = {bus.engine.Type}");
        Console.WriteLine($"             Serial Number = {bus.engine.SerialNumber}");

        Console.WriteLine("");

        Console.WriteLine($"Chasis:");
        Console.WriteLine($"             Wheels Number = {bus.chasis.WheelsNumber}");
        Console.WriteLine($"             Number = {bus.chasis.Number}");
        Console.WriteLine($"             Permissable load = {bus.chasis.PermissableLoad}");

        Console.WriteLine("");

        Console.WriteLine($"Transmission: ");
        Console.WriteLine("");
        Console.WriteLine($"             Type = {bus.transmission.Type}");
        Console.WriteLine($"             Number of gears = {bus.transmission.NumberOfGears}");
        Console.WriteLine($"             Manufacturer = {bus.transmission.Manufacturer}");

        Console.WriteLine("");

        Console.WriteLine($"Truck: Model = {truck.Model}");
        Console.WriteLine("");
        Console.WriteLine($"Engine:");
        Console.WriteLine($"             Power = {truck.engine.Power}");
        Console.WriteLine($"             Volume = {truck.engine.Volume}");
        Console.WriteLine($"             Type = {truck.engine.Type}");
        Console.WriteLine($"             Serial Number = {truck.engine.SerialNumber}");

        Console.WriteLine("");

        Console.WriteLine($"Chasis:");
        Console.WriteLine($"             Wheels Number = {truck.chasis.WheelsNumber}");
        Console.WriteLine($"             Number = {truck.chasis.Number}");
        Console.WriteLine($"             Permissable load = {truck.chasis.PermissableLoad}");

        Console.WriteLine("");

        Console.WriteLine($"Transmission: ");
        Console.WriteLine($"             Type = {truck.transmission.Type}");
        Console.WriteLine($"             Number of gears = {truck.transmission.NumberOfGears}");
        Console.WriteLine($"             Manufacturer = {truck.transmission.Manufacturer}");

        Console.WriteLine("");

        Console.WriteLine($"Scooter: Model = {scooter.Model}");
        Console.WriteLine("");
        Console.WriteLine($"Engine:");
        Console.WriteLine($"             Power = {scooter.engine.Power}");
        Console.WriteLine($"             Volume = {scooter.engine.Volume}");
        Console.WriteLine($"             Type = {scooter.engine.Type}");
        Console.WriteLine($"             Serial Number = {scooter.engine.SerialNumber}");

        Console.WriteLine("");

        Console.WriteLine($"Chasis:");
        Console.WriteLine($"             Wheels Number = {scooter.chasis.WheelsNumber}");
        Console.WriteLine($"             Number = {scooter.chasis.Number}");
        Console.WriteLine($"             Permissable load = {scooter.chasis.PermissableLoad}");

        Console.WriteLine("");

        Console.WriteLine($"Transmission: ");
        Console.WriteLine($"             Type = {scooter.transmission.Type}");
        Console.WriteLine($"             Number of gears = {scooter.transmission.NumberOfGears}");
        Console.WriteLine($"             Manufacturer = {scooter.transmission.Manufacturer}");

        Console.ReadKey();

    }
}