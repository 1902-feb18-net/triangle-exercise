using System;


namespace TriangleLib
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

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

        public double FindThirdSide(double a, double b, double angleAB)
        {
            double c = 0;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + 2 * a * b * Math.Cos(angleAB));
            return c;
        }
    }
}
