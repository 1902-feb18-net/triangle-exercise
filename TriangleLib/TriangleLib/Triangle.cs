using System;


namespace TriangleLib
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double angleAB { get; set; }
        public double angleBC { get; set; }
        public double angleAC { get; set; }

        public double TriangleArea(double TriBase, double height)
        {
            return (TriBase * height) / 2;
        }

        public double CircumRadiusTri(double a, double b, double c)
        {
            return (a * b * c) / Math.Sqrt((a + b + c) * (b + c - a) * (c + a - b) * (a + b - c));
        }

        public bool IsEquilateral(double a, double b, double c)
        {
            return (a == b) && (b == c);
        }

        public bool IsIsosceles(double a, double b, double c)
        {
            return (a == b) && (b != c) || (a == c) && (b != c) || (b == c) || (a != c);
        }

        public bool IsScalene(double a, double b, double c)
        {
            return (a != b) && (b != c) && (a != c);
        }

        public double FindThirdSide(double a, double b, double _angleAB)
        {
            double c = 0;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + 2 * a * b * Math.Cos(_angleAB));
            return c;
        }
        public static double Rad(double deg)
        {
            return deg * Math.PI / 180;
        }

        // finding 3rd side given 2 sides and an angle in between
        //public static double Thirdside(double side1, double side2, double angleDeg)
        //{
        //    double angleRad = Rad(angleDeg);
        //    return Math.Sqrt(side1 * side1 + side2 * side2 - 2 * side1 * side2 * Math.Cos(angleRad));
        //}

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

        //public static double TriangleArea (double b, double h)
        //{
        //    // A = 0.5 * b * h
        //    return 0.5 * b * h;
        //}
    }
}
