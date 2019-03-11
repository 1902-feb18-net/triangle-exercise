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
        public static double Rad(double deg)
        {
            return deg * Math.PI / 180;
        }

        // finding 3rd side given 2 sides and an angle in between
        public static double Thirdside(double side1, double side2, double angleDeg)
        {
            double angleRad = Rad(angleDeg);
            return Math.Sqrt(side1 * side1 + side2 * side2 - 2 * side1 * side2 * Math.Cos(angleRad));
        }

        //public static bool SssCongruent(double side1, double side2, double side3)
        //{
        //    if(side1 == side2 && side2 == side3)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public static double RightTrianglePerimeter (double side1, double side2)
        {
            double side3 = PythagoreanTheorem(side1, side2);
            return side1 + side2 + side3;
        }

        public static double PythagoreanTheorem(double side1, double side2)
        {
            // a^2 + b^2 = c^2, so solve for c
            return Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
        }

        public static double SASPerimeter (double side1, double side2, double deg)
        {
            // formula is a^2 = b^2 + c^2 - 2bcCos(A)
            double side3 = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2) - 2 * side1 * side2 * Math.Cos(deg));
            return side1 + side2 + side3;
        }

        public static double TriangleArea (double b, double h)
        {
            // A = 0.5 * b * h
            return 0.5 * b * h;
        }
    }
}
