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
    }
}
