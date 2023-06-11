using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VechileParts;

namespace Vechile
{
    public class PassengerCar
    {
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }
        public string Model { get; set; }
    }
    public class Truck
    {
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }
        public string Model { get; set; }
    }

    public class Bus
    {
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }
        public string Model { get; set; }
    }

    class Scooter
    {
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }
        public string Model { get; set; }
    }
}
