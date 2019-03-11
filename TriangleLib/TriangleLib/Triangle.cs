using System;

namespace TriangleLib
{
    public class Triangle
    {
        // The assumption here is that one end of the base length is at (0, 0)
        // and the other vertex is at (SideLengthA, 0)
        public double SideLengthA { get; set; } // BaseLength
        public double OtherVertexY { get; set; }
        public double OtherVertexX { get; set; }
        
        public double SideLengthB()
        {
            return Math.Sqrt(Math.Pow(OtherVertexX, 2) + Math.Pow(OtherVertexY, 2));
        }

        public double SideLengthC()
        {
            return Math.Sqrt(Math.Pow(SideLengthA - OtherVertexX, 2) + Math.Pow(OtherVertexY, 2));
        }

        public double GetPerimeter()
        {
            return SideLengthA + SideLengthB() + SideLengthC();
        }

        public double GetArea()
        {
            // Heron's formula, 
            double p = GetPerimeter();
            double b = SideLengthB();
            double c = SideLengthC();
            double a = SideLengthA;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double GetAngleA()
        {
            // Law of Cosines
            double p = GetPerimeter();
            double b = SideLengthB();
            double c = SideLengthC();
            double a = SideLengthA;
            return Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2))/(2 * b * c));
        }

        public double GetAngleB()
        {
            // Law of Cosines 
            double p = GetPerimeter();
            double b = SideLengthB();
            double c = SideLengthC();
            double a = SideLengthA;
            return Math.Acos((Math.Pow(c, 2) + Math.Pow(a, 2) - Math.Pow(b, 2))/(2 * c * a));
        }

        public double GetAngleC()
        {
            // Law of Cosines 
            double p = GetPerimeter();
            double b = SideLengthB();
            double c = SideLengthC();
            double a = SideLengthA;
            return Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2))/(2 * a * b));
        }

        public double GetSemiPerimeter()
        {
            return GetPerimeter() / 2;
        }
    }
}
