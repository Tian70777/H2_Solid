using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2SOLID.Shapes
{
    public class Square
    {
        private double a;
        public double A { get => a; set => a = value; }

        public Square(double sideA)
        {
            // Ensure the side is positive
            if (sideA <= 0)
            {
                throw new ArgumentException("Invalid square side given.");
            }

            A = sideA;
        }
        public double Perimeter()
        {
            return Math.Round(A * 4, 2);
        }
        public double Area()
        {
            return Math.Round(A * A, 2);
        }

    }
}
