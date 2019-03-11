using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TriangleLib;

namespace TriangleLib.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void FindRightTrianglePerimeter()
        {
            // arrange
            double side1 = 3;
            double side2 = 4;

            // act
            double result = TriangleLib.Triangle.RightTrianglePerimeter(side1, side2);

            //assert


        }
    }
}