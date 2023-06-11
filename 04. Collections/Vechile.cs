using vechileparts;

namespace vechiles
{
    public class Vechiles
    {

    }
    public class PassengerCar : Vechiles
    {
        public Engine engine { get; set; }
        public Transmission transmission { get; set; }
        public Chasis chasis { get; set; }

    }
    public class Bus : Vechiles
    {
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }

    }
    public class Scooter : Vechiles
    {
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }

    }
    public class Truck : Vechiles
    {
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }

    }

}
