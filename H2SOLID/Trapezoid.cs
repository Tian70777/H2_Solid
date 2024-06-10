using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2SOLID
{
    public class Trapezoid: Square
    {
        private double b, c, d, h, s;
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public double D { get => d; set => d = value; }
        public double H { get => h; private set => h = value;  }

        public Trapezoid(double sideA, double sideB, double sideC, double sideD) : base(sideA)
        {
            // Check if the sides given form a valid trapezoid
            if(!IsValidTrapezoid(sideA, sideB, sideC, sideD))
            {
                throw new ArgumentException("Invalid trapezoid sides given.");
            }
            
            B = sideB;
            C = sideC;
            D = sideD;
            s = (A + B - C + D) / 2;
            H = 2 / (A - C) * Math.Sqrt(s * (s - A + C) * (s - B) * (s - D));
        }
        
        public double Perimeter()
        {
            return Math.Round((A + B + C + D), 2);
        }

        public double Area()
        {
            return Math.Round((A + C) * H / 2, 2);
        }
        private bool IsValidTrapezoid(double a, double b, double c, double d)
        {
            if(a <= 0 || b <= 0 || c <= 0 || d <= 0)
            {
                return false;
            }
            
            double min = Math.Min(Math.Min(a, b), Math.Min(c, d));
            // Check if the absolute difference between the sums of opposite sides is less than twice the length of the remaining sides
            return Math.Abs(a + b - c - d) < 2 * min && Math.Abs(a + c - b - d) < 2 * min;

        }

    }
}
