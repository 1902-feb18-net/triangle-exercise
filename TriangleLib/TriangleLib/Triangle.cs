using System;

namespace TriangleLib
{

    public class Triangle
    {
        int Length { get; set; }
        int Height { get; set; }
        int side3 { get; set; }

        public double Showarea(int length, int Height)
        {
            return (length* Height) / 2;
        }

        public double ShowPerimeter(int Length, int Height, int side3)
        {
            return Length + Height + side3;
        }


        public bool IsEqualiteral(int Length, int Height,int side3)
        {
            if(Length == Height & Height == side3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsIsosceles(int Length, int Height, int side3)
        {
            if (Length == Height || Length == side3)
            {
                return true;
            }
            else
            {
               return false;
            }
        }

        public bool IsScalene(int Length, int Height, int side3)
        {
            if (Length != Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
 
}
