using System;

namespace TriangleLib
{
    public class Triangle
    {
		int Aside;
		int Bside;
		int Cside;

		double Aangle;
		double Bangle;
		double Cangle;

		public Triangle(double aangle, double bangle, double cangle)
		{
			Aangle = aangle;
			Bangle = bangle;
			Cangle = cangle;
		}

		public Triangle(int aside, int bside, int cside)
		{
			Aside = aside;
			Bside = bside;
			Cside = cside;
		}
	}
}
