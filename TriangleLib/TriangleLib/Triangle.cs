using System;

namespace TriangleLib
{
    public class Triangle
    {
        //three sides
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        //need to modify at least one side if setting another!
       
        //three angles?
        //AngleAB
        //AngleBC
        //AngleCA

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

        public int CalculatePerimeter()
        { return SideA + SideB + SideC; }

        //Area = b*h/2


    }
}
