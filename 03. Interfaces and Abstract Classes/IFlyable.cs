using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flyers;

namespace InterfacesAndStructures
{
    public struct Coordinate
    {
        public double X;
        public double Y;
        public double Z;

        public Coordinate(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }

    public interface IFlyable
    {
        void FlyTo(Coordinate newPoint);
        double GetFlyTime(Coordinate newPoint);
    }
}
