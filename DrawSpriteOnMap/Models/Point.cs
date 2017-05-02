using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawSpriteOnMap.Models
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double Latitude
        {
            get
            {


                return Y;
            }
            set
            {
                this.Y = value;
            }

        }
        public double Longitude
        {
            get
            {
                return X;
            }
            set
            {
                this.X = value;
            }
        }
    }
}
