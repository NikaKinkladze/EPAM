using Flyers;
using InterfacesAndStructures;

namespace ExecutionMethod
{
    internal class Execution
    {
        public static void exetution()
        {
            Coordinate initialPosition = new Coordinate(0, 0, 0);
            Coordinate destination = new Coordinate(10, 10, 10);

            Bird bird = new Bird(initialPosition);
            Airplane airplane = new Airplane(initialPosition);
            Drone drone = new Drone(initialPosition);

            Console.Write("Bird:");
            Console.WriteLine($"Fly time to destination: {bird.GetFlyTime(destination)} hours");

            Console.Write("\nAirplane:");
            Console.WriteLine($"Fly time to destination: {airplane.GetFlyTime(destination)} hours");

            Console.Write("\nDrone:");
            Console.WriteLine($"Fly time to destination: {drone.GetFlyTime(destination)} hours");

            Console.ReadLine();
        }
    }
}
