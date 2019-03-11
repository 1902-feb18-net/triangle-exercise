using System;

namespace TriangleLib
{
    public class Triangle
    {
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
        }
    }
}
