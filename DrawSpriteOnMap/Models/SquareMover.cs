using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawSpriteOnMap.Models
{
    public class SquareMover
    {

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public IList<Square> SquareList { get; set; }

        public SquareMover(double lat, double lon)
        {
            SquareList = new List<Square>();

            Latitude = lat;
            Longitude = lon;
            //create startSquare
            Square startSquare = new Square();
            Point startPoint = new Point();
            startPoint.Latitude = Latitude;
            startPoint.Longitude = Longitude;
            startSquare.Length = 0.0101;
            startSquare.A = startPoint;
            startSquare.FixSquare();
            SquareList.Add(startSquare);


        }

        public Square MoveDownRow(int width,bool live)
        {

            //get the 1st index of the row
            Square first = SquareList[SquareList.Count - width];

            //move south
            Square newSquare = MoveSquareS(first);
            newSquare.Live = live;
            
            return newSquare;

        }

    

        public Square MoveSquareNW(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X - currentSquare.Length;
            newPointA.Y = currentSquare.A.Y + currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X - currentSquare.Length;
            newPointB.Y = currentSquare.B.Y + currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
             SquareList.Add(newSquare);
            return newSquare;


        }

        public Square MoveSquareNE(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X + currentSquare.Length;
            newPointA.Y = currentSquare.A.Y + currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X + currentSquare.Length;
            newPointB.Y = currentSquare.B.Y + currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
            SquareList.Add(newSquare);
            return newSquare;


        }

        public Square MoveSquareSE(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X + currentSquare.Length;
            newPointA.Y = currentSquare.A.Y - currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X + currentSquare.Length;
            newPointB.Y = currentSquare.B.Y - currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
            SquareList.Add(newSquare);
            return newSquare;


        }

        public Square MoveSquareSW(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X - currentSquare.Length;
            newPointA.Y = currentSquare.A.Y - currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X - currentSquare.Length;
            newPointB.Y = currentSquare.B.Y - currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
             SquareList.Add(newSquare);
            return newSquare;


        }

        public Square MoveSquareN(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X;
            newPointA.Y = currentSquare.A.Y + currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X;
            newPointB.Y = currentSquare.B.Y + currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
            SquareList.Add(newSquare);
            return newSquare;

        }
        public Square MoveSquareS(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X;
            newPointA.Y = currentSquare.A.Y - currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X;
            newPointB.Y = currentSquare.B.Y - currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
             SquareList.Add(newSquare);
            return newSquare;

        }

        public Square MoveSquareW(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X - currentSquare.Length;
            newPointA.Y = currentSquare.A.Y;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X - currentSquare.Length;
            newPointB.Y = currentSquare.B.Y;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
             SquareList.Add(newSquare);
            return newSquare;

        }


        public Square MoveSquareE(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X + currentSquare.Length;
            newPointA.Y = currentSquare.A.Y;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X + currentSquare.Length;
            newPointB.Y = currentSquare.B.Y;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
             SquareList.Add(newSquare);
            return newSquare;

        }



        public Square MoveSquareNW(bool live)
        {
            Square currentSquare = SquareList.LastOrDefault();
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X - currentSquare.Length;
            newPointA.Y = currentSquare.A.Y + currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X - currentSquare.Length;
            newPointB.Y = currentSquare.B.Y + currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
            newSquare.Live = live;
            SquareList.Add(newSquare);
            
            return newSquare;


        }

        public Square MoveSquareNE(bool live)
        {
            Square currentSquare = SquareList.LastOrDefault();
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X + currentSquare.Length;
            newPointA.Y = currentSquare.A.Y + currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X + currentSquare.Length;
            newPointB.Y = currentSquare.B.Y + currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
            newSquare.Live = live;
            SquareList.Add(newSquare);
            return newSquare;


        }

        public Square MoveSquareSE(bool live)
        {
            Square currentSquare = SquareList.LastOrDefault();
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X + currentSquare.Length;
            newPointA.Y = currentSquare.A.Y - currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X + currentSquare.Length;
            newPointB.Y = currentSquare.B.Y - currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
            newSquare.Live = live;
            SquareList.Add(newSquare);
            return newSquare;


        }

        public Square MoveSquareSW(bool live)
        {
            Square currentSquare = SquareList.LastOrDefault();
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X - currentSquare.Length;
            newPointA.Y = currentSquare.A.Y - currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X - currentSquare.Length;
            newPointB.Y = currentSquare.B.Y - currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
             newSquare.Live = live;
            SquareList.Add(newSquare);

            return newSquare;


        }

        public Square MoveSquareN(bool live)
        {
             Square currentSquare = SquareList.LastOrDefault();
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X;
            newPointA.Y = currentSquare.A.Y + currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X;
            newPointB.Y = currentSquare.B.Y + currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
            newSquare.Live = live;
            SquareList.Add(newSquare);
            return newSquare;

        }
        public Square MoveSquareS(bool live)
        {
            Square currentSquare = SquareList.LastOrDefault();
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X;
            newPointA.Y = currentSquare.A.Y - currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X;
            newPointB.Y = currentSquare.B.Y - currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
            newSquare.Live = live;
            SquareList.Add(newSquare);
            return newSquare;

        }

        public Square MoveSquareW(bool live)
        {
            Square currentSquare = SquareList.LastOrDefault();
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X - currentSquare.Length;
            newPointA.Y = currentSquare.A.Y;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X - currentSquare.Length;
            newPointB.Y = currentSquare.B.Y;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
            newSquare.Live = live;
            SquareList.Add(newSquare);
            return newSquare;

        }


        public Square MoveSquareE(bool live)
        {
            Square currentSquare = SquareList.LastOrDefault();
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X + currentSquare.Length;
            newPointA.Y = currentSquare.A.Y;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X + currentSquare.Length;
            newPointB.Y = currentSquare.B.Y;

            newSquare.A = newPointA;
            newSquare.B = newPointB;
             newSquare.Live = live;
            SquareList.Add(newSquare);
            return newSquare;


        }

    }
}
