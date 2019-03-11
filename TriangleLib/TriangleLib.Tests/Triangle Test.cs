using System;
using System.Collections.Generic;
using System.Text;
using TriangleLib;
using Xunit;

namespace TriangleLib.Tests
{
    public class Triangle_Test
    {
        [Theory]
        [InlineData(10, 3)]
        [InlineData(20, 14)]
        public void Test_Triangle_Area(double TriBase, double Height)
        {
            var tri = new Triangle();
            double x = tri.TriangleArea(TriBase, Height);

            Assert.True(x == (TriBase * Height) / 2);
        }

        [Theory]
        [InlineData(10, 3)]
        [InlineData(20, 14)]
        public void Test_Triangle_Area_False(double TriBase, double Height)
        {
            var tri = new Triangle();
            double x = tri.TriangleArea(TriBase, Height);

            Assert.True(x != (TriBase * Height) / 2 + 1);
        }
    }
}
