using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2SOLID.Shapes
{
    public class Rectangle : Square
    {
        private double b;
        public double B { get => b; set => b = value; }

        public Rectangle(double sideA, double sideB) : base(sideA)
        {
            // Ensure sides are positive
            if (sideA <= 0 || sideB <= 0)
            {
                throw new ArgumentException("Invalid rectangle sides given.");
            }

            B = sideB;
        }

        public double Perimeter()
        {
            return Math.Round((A + B) * 2, 2);
        }

        public double Area()
        {
            return Math.Round(A * B, 2);
        }
    }
}
