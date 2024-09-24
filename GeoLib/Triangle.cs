using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLib
{
    public class Triangle : IArea
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double calculateArea()
        {
            var s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public bool isRightTriangle()
        {
            double[] sides = { A, B, C };
            Array.Sort(sides);
            if (sides[2] * sides[2] == (sides[1] * sides[1] + sides[0] * sides[0]))
                return true;
            return false;
        }
    }
}
