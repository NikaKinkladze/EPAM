namespace VechileParts
{
    public class Engine
    {
        public int Power { get; set; }
        public string Volume { get; set; }
        public string Type { get; set; }
        public int SerialNumber { get; set; }
    }

    public class Chasis
    {
        public int WheelsNumber { get; set; }
        public String Number { get; set; }
        public int PermissableLoad { get; set; }
    }

    public class Transmission
    {
        public string Type { get; set; }
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }
    }
}
