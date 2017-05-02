using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawSpriteOnMap.Models
{
    public class DrawSprite
    {
        public IList<Image> Images { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }

        public SquareMover Mover { get; set; }


        public DrawSprite(IList<Image> images, int width, int height, double lat, double lon)
        {
            Images = images;
            Width = width;
            Height = height;
            Lat = lat;
            Lon = lon;
            Mover = new SquareMover(lat,lon);
            GetCords();
            //Console.WriteLine(Images.Count.ToString());
        }

        

        public void GetCords()
        {
            int count = 1;
            for (int i = 0; i < Images.Count; i++)
            {
               
                if (i != 0)
                {
                   
                    if (i % Width == 0)
                    {
                        count++;
                        //get color
                        //  Mover.MoveDownRow(Width, true);
                        Console.WriteLine("row" + count.ToString());

                        Color pixelColor = (Images[i] as Bitmap).GetPixel(Images[i].Width / 2, Images[i].Height / 2);
                        Console.WriteLine(pixelColor.Name);
                        if (pixelColor.Name == "ff000000")
                        {
                            Mover.MoveDownRow(Width, true);
                        }
                        else
                        {
                            Mover.MoveDownRow(Width,false);
                        }

                        
                       
                    }
                    else
                    {
                        //get color
                        Color pixelColor = (Images[i] as Bitmap).GetPixel(Images[i].Width/2, Images[i].Height/2);

                        Console.WriteLine(pixelColor.Name);

                        if (pixelColor.Name == "ff000000")
                        {
                            Mover.MoveSquareE( true);
                        }
                        else
                        {
                            Mover.MoveSquareE(false);
                        }
                    }
                    
                }
            }
        }


    }
}
