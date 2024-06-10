using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace H2SOLID
{
    internal class RightTriangle : Square
    {
        private double b, c;
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public RightTriangle(double sideA, double sideB, double sideC) : base(sideA)
        {
            if (!IsValidRightTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("Invalid right triangle sides given.");
            }

            B = sideB;
            C = sideC;
        }
        public double Perimeter()
        {
            return Math.Round((A + B + C), 2);
        }
        public double Area()
        {
            return Math.Round((A * B / 2), 2);
        }

        private bool IsValidRightTriangle(double a, double b, double c)
        {
            // ensure sidesa re positive
            if(a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }

            // c is the hypotenuse, check the Pythagorean theorem
            return Math.Abs(c*c - (a*a + b*b)) < 0.0001;
        }
    }
}
