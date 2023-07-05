using InterfacesAndStructures;

namespace Flyers
{

    public class Airplane : IFlyable
    {
        private double currentSpeed;

        public Coordinate CurrentPosition { get; set; }

        public Airplane(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
            currentSpeed = 200;
        }

        public void FlyTo(Coordinate newPosition)
        {
            CurrentPosition = newPosition;
            var distance = CalculateDistance(newPosition, CurrentPosition);
            var acceleration = 10;
            var speedIncrease = 0d;

            for (var i = 10; i <= distance; i += 10)
            {
                speedIncrease += acceleration;
            }

            currentSpeed += speedIncrease;
        }

        public double GetFlyTime(Coordinate newPosition)
        {
            var distance = CalculateDistance(newPosition, CurrentPosition);
            var acceleration = 10;
            var speedIncrease = 0d;

            for (var i = 10; i <= distance; i += 10)
            {
                speedIncrease += acceleration;
            }

            var finalSpeed = currentSpeed + speedIncrease;
            return distance / finalSpeed;
        }

        private static double CalculateDistance(Coordinate position1, Coordinate position2)
        {
            return Math.Sqrt(Math.Pow(position2.X - position1.X, 2) + Math.Pow(position2.Y - position1.Y, 2) + Math.Pow(position2.Z - position1.Z, 2));
        }
    }
    public class Drone : IFlyable
    {
        private const int HOVER_TIME = 1; // in minutes
        private const int HOVER_INTERVAL = 10; // in minutes

        public Coordinate CurrentPosition { get; set; }

        public Drone(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        public void FlyTo(Coordinate newPosition)
        {
            CurrentPosition = newPosition;
        }

        public double GetFlyTime(Coordinate newPosition)
        {
            var distance = CalculateDistance(newPosition, CurrentPosition);
            var time = 0d;
            var elapsed = 0;

            while (distance > 0)
            {
                if (elapsed == HOVER_INTERVAL)
                {
                    time += HOVER_TIME / 60d; // convert to hours
                    elapsed = 0;
                }
                else
                {
                    var moveDistance = Math.Min(distance, 50); // move 50 meters at a time
                    distance -= moveDistance;
                    time += moveDistance / 50d; // drone moves at 50 km/h
                    elapsed += 1;
                }
            }

            if (elapsed == HOVER_INTERVAL)
            {
                time += HOVER_TIME / 60d;
            }

            return time;
        }

        private static double CalculateDistance(Coordinate position1, Coordinate position2)
        {
            return Math.Sqrt(Math.Pow(position2.X - position1.X, 2) + Math.Pow(position2.Y - position1.Y, 2) + Math.Pow(position2.Z - position1.Z, 2));
        }
    }
    public class Bird : IFlyable
    {
        private double currentSpeed;

        public Coordinate CurrentPosition { get; set; }

        public Bird(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
            currentSpeed = new Random().Next(0, 21);
        }

        public void FlyTo(Coordinate newPosition)
        {
            CurrentPosition = newPosition;
        }

        public double GetFlyTime(Coordinate newPosition)
        {
            var distance = CalculateDistance(newPosition, CurrentPosition);
            return distance / currentSpeed;
        }

        private static double CalculateDistance(Coordinate position1, Coordinate position2)
        {
            return Math.Sqrt(Math.Pow(position2.X - position1.X, 2) + Math.Pow(position2.Y - position1.Y, 2) + Math.Pow(position2.Z - position1.Z, 2));
        }
    }
}
