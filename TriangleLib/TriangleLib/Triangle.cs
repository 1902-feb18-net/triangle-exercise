using System;

namespace TriangleLib
{
    public class Triangle
    {
        //decimal Base { get; set; }
        decimal Altitude { get; set; }
        decimal[] Sides { get; set; }

        public Triangle(decimal[] sides)
        {
            sides = Sides;
        }


        decimal getPerimeter(Triangle triangle)
        {
            decimal perimeter = 0;

            for (int i = 0; i < triangle.Sides.Length; i++)
            {
                perimeter += triangle.Sides[i];
            }
            return perimeter;
        }

        decimal getArea(Triangle triangle)
        {  
            return triangle.Altitude * triangle.Sides[0] / 2;
        }
    }
}
