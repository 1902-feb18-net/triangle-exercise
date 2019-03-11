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


		double area;


		public Triangle(double aangle, double bangle, double cangle)
		{
			Aangle = aangle;
			Bangle = bangle;
			Cangle = cangle;
			try
			{
				if (Aangle + Bangle + cangle != 180)
				{
					throw new ArgumentException("The angles do not describe a triangle. ");
				}
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public Triangle(int aside, int bside, int cside)
		{
			Aside = aside;
			Bside = bside;
			Cside = cside;
		}



		public bool IsEquilateral(Triangle tri)
		{
			if (tri.Aside ==tri.Bside && tri.Bside == tri.Cside)
			{
				return true;
			}
			return false;
		}




		public bool IsIsosceles(Triangle tri)
		{
			if (tri.Aside == tri.Bside || tri.Bside == tri.Cside || tri.Cside == tri.Aside)
			{
				return true;
			}
			return false;
		}






		public bool IsScalene(Triangle tri)
		{
			if (tri.Aside == tri.Bside || tri.Bside == tri.Cside || tri.Cside == tri.Aside)
			{
				return false;
			}
			return true;
		}




		public bool IsAcuteAngled(Triangle tri)
		{
			if( tri.Aangle <90 && tri.Bangle < 90 && tri.Cangle < 90)
			{
				return true;
			}
			return false;
		}

		public bool IsObtuseAngled(Triangle tri)
		{
			if (tri.Aangle > 90 || tri.Bangle > 90 || tri.Cangle > 90)
			{
				return true;
			}
			return false;
		}


		public bool IsRightAngled(Triangle tri)
		{
			if (tri.Aangle == 90 || tri.Bangle == 90 || tri.Cangle == 90)
			{
				return true;
			}
			return false;
		}


		public void Scale(Triangle tri, int scale)
		{
			tri.Aside = tri.Aside * scale;
			tri.Bside = tri.Bside * scale;
			tri.Cside = tri.Cside * scale;
		}



		public void Area(Triangle tri)
		{
			tri.area = .5 * tri.Aside * tri.Cside;
		}



	
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


    }
}
