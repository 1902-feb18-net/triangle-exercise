using System;


namespace TriangleLib
{
    public class Triangle
    {

        double TriangleArea(double TriBase, double height)
        {
            return (TriBase * height) / 2;
        }

        double CircumRadiusTri(double a, double b, double c, double area)
        {
            return (a * b * c) / Math.Sqrt((a + b + c) * (b + c - a) * (c + a - b) * (a + b - c));
        }

        bool IsEquilateral(double a, double b, double c)
        {
            return (a == b) && (b == c);
        }

        bool IsIsosceles(double a, double b, double c)
        {
            return (a == b) && (b != c) || (a == c) && (b != c) || (b == c) || (a != c);
        }

        bool IsScalene(double a, double b, double c)
        {
            return (a != b) && (b != c) && (a != c);
        }

        double FindThirdSide(double a, double b, double angleAB)
        {
            double c = 0;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + 2 * a * b * Math.Cos(angleAB));
            return c;
        }
    }
}
