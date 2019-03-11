using System;
using System.Collections.Generic;

namespace TriangleLib
{
    public class Triangle
    {
        public double ang1 { get; set; }
        public double ang2 { get; set; }
        public double ang3 { get; set; }
        public double side { get; set; }
        public double hyp { get; set; }


        public bool IsTriangle(double ang1, double ang2, double ang3)
        {
            if ((ang1 + ang2 + ang3) == 180 && (ang1 != 0) || (ang2 != 0) || (ang3 != 0))
            {
                return true;
            }
            else
                return false;
        }

        public bool IsRight(double ang1, double ang2, double ang3)
        {
            if (ang1 == 90 || ang2 == 90 || ang3 == 90)
                return true;
            else
                return false;
        }

        public double SOH(double side, double hyp)
        {
            double output = 0;
            output = Math.Sin(side / hyp);
            return output;
        }

        public double CAH(double side, double hyp)
        {
            double output = 0;
            output = Math.Cos(side / hyp);
            return output;
        }

        public double TOA(double side, double hyp)
        {
            double output = 0;
            output = Math.Tan(side / hyp);
            return output;

        double _sideA;
        double _sideB;
        double _sideC;

        Triangle(double side)
        {
            _sideA = _sideB = _sideC = side;
        }

        Triangle(double sideA, double sideBC)
        {
            _sideA = sideA;
            _sideB = _sideC = sideBC;
        }

        Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double SideA { get => _sideA; set { _sideA = value; } }
        public double SideB { get => _sideB; set { _sideB = value; } }
        public double SideC { get => _sideC; set { _sideC = value; } }

        public double Area()
        {
            double s = (_sideA + _sideB + _sideB) / 2;
            return Math.Sqrt(s*(s - _sideA)*(s - _sideB)*(s - _sideC));
        }

        public double AngleC()
        {
            return Math.Atan(_sideA / _sideB);
        }

        public double AngleA()
        {
            return Math.Atan(_sideB / _sideC);
        }

        public double AngleB()
        {
            return Math.Atan(_sideC / _sideA);
        }

        public double Perimeter()
        {
            return _sideA + _sideB + _sideC;
        }


        // a1, a2
        public List<float> Vx { get; set; }
        // b1, b2
        public List<float> Vy { get; set; }
        // c1, c2
        public List<float> Vz { get; set; }
        // AB, BC, CA
        public float SideAB { get; set; }
        public float SideBC { get; set; }
        public float SideCA { get; set; }


        // Methods
        public float CalculateSide(List<float> vx, List<float> vy)
        {
            return (float)Math.Sqrt(Math.Pow(Math.Abs(vy[1] - vx[1]), 2) + Math.Pow(Math.Abs(Math.Abs(vy[0] - vx[0])), 2));
        }

        public void SetSideLengths()
        {
            SideAB = CalculateSide(Vx, Vy);
            SideBC = CalculateSide(Vy, Vz);
            SideCA = CalculateSide(Vz, Vx);
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


          //add angle checks as well
        public bool IsEquilateral()
        {
            return SideA == SideB && SideB == SideC;
        }

        public bool IsIsosceles()
        {
            return SideA == SideB || SideB == SideC || SideC == SideA;
        }

        public bool IsScalene()
        {
            return SideA != SideB && SideB != SideC && SideC != SideA;
        }

        public bool IsRightAngle()
        {
            return (SideC * SideC) == ((SideA * SideA) + (SideB * SideB) )
                || (SideA * SideA) == ((SideC * SideC) + (SideB * SideB) )
                || (SideB * SideB) == ((SideA * SideA) + (SideC * SideC) )  ;
        }


    }
}
