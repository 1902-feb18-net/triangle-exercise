using System;
using System.Collections.Generic;

namespace TriangleLib
{
    public class Triangle
    {
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
