using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLib.Figures
{
    public class Circle : IArea
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double calculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
