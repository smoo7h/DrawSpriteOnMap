using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawSpriteOnMap.Models
{
    public class Square
    {
        public bool Live { get; set; }
        public Point A { get; set; }
        public Point B { get; set; }
        public double Length { get; set; }

        public Point AB { get; set; }
        public Point BA { get; set; }


        public void GetPointAB()
        {
            Point newPoint = new Point();
            newPoint.X = B.X;
            newPoint.Y = A.Y;
            AB = newPoint;
        }

        public void GetPointBA()
        {
            Point newPoint = new Point();
            newPoint.X = A.X;
            newPoint.Y = B.Y;
            BA = newPoint;
        }

        public void GetPointA()
        {
            Point newPoint = new Point();
            newPoint.X = B.X - Length * 1;
            newPoint.Y = B.Y + Length;
            A = newPoint;
        }
        public void GetPointB()
        {
            Point newPoint = new Point();
            newPoint.X = A.X + Length * 1;
            newPoint.Y = A.Y - Length;
            B = newPoint;
        }
        public void FixSquare()
        {
            if (A == null && B != null)
            {
                GetPointA();
            }

            if (B == null && A != null)
            {
                GetPointB();
            }

            GetPointBA();

            GetPointAB();

        }
    }
}
