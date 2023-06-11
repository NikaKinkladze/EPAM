using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesAndStructures;
using Flyers;

namespace ExecutionMethod
{
    internal class Execution
    {
        public static void exetution()
        {


            var bird = new Bird(new Coordinate(0, 0, 0));
            var airplane = new Airplane(new Coordinate(0, 0, 0));
            var drone = new Drone(new Coordinate(0, 0, 0));

            var destination = new Coordinate(1000, 1000, 1000);

            bird.FlyTo(destination);
            airplane.FlyTo(destination);
            drone.FlyTo(destination);

            var birdTime = bird.GetFlyTime(destination);
            var airplaneTime = airplane.GetFlyTime(destination);
            var droneTime = drone.GetFlyTime(destination);

            Console.WriteLine($"Bird fly time: {birdTime} hours");
            Console.WriteLine($"Airplane fly time: {airplaneTime} hours");
            Console.WriteLine($"Drone fly time: {droneTime} hours");
        }
    }
}
