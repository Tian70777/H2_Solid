using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2SOLID.Shapes
{
    public class Parallelogram : Square
    {
        private double b;
        private double v;
        public double B { get => b; set => b = value; }
        public double V { get => v; set => v = value; }

        public Parallelogram(double sideA, double sideB, double sideV) : base(sideA)
        {
            // Ensure sides are positive
            if (sideA <= 0 || sideB <= 0 || sideV <= 0)
            {
                throw new ArgumentException("Invalid parallelogram sides given.");
            }

            B = sideB;
            V = sideV;
        }

        public double Perimeter()
        {
            return Math.Round((A + B) * 2, 2);
        }

        public double Area()
        {
            return Math.Round(A * B * Math.Sin(V), 2);
        }

    }
}
