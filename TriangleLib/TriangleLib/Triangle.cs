using System;

namespace TriangleLib
{
    public class Triangle
    {
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



    }
}
