using DrawSpriteOnMap.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawSpriteOnMap
{
    class Program
    {
        static void Main(string[] args)
        {
            //paste output here https://jsfiddle.net/npc2410s/3/
            //vairables 
            double lat = 43.80022782085926;
            double lon = -79.46874957722167;
            //cute the image into peices
            ImageCutter cutter = new ImageCutter(@"bulbasaur.png", 16,16);
            //draw the sprite on a map
            DrawSprite ds = new DrawSprite(cutter.CutImages, cutter.Width, cutter.Height, lat, lon);
            //print it out
            File.Delete("out.txt");
            File.Delete("DrawImg.csv");
            using (StreamWriter sw = new StreamWriter(@"OutPutForFiddle.txt", false))
            {
                using (StreamWriter sw2 = new StreamWriter(@"ImageCrds.csv", false))
                {
                    //write the js code for fiddle test
                    sw.Write("function initMap(){var myLatLng = {lat: 43.8041958395909,lng: -79.754306699939};var map = new google.maps.Map(document.getElementById('map'), {zoom: 10,center: myLatLng});");

                    Random r = new Random();
                    foreach (Square currS in ds.Mover.SquareList)
                    {
                        currS.FixSquare();

                        if (currS.Live == true)
                        {
                            //write out the cords for mapping software as csv
                            sw2.WriteLine(String.Format(@"{0},{1},{2},{3}", currS.A.X, currS.A.Y, currS.B.X, currS.B.Y));
                             //write the js code for fiddle test
                            sw.WriteLine(GetCordString(currS.A.Latitude.ToString(), currS.A.Longitude.ToString(), r.Next(5000).ToString()));
                            sw.WriteLine(GetCordString(currS.B.Latitude.ToString(), currS.B.Longitude.ToString(), r.Next(5000).ToString()));
                            sw.WriteLine(GetCordString(currS.AB.Latitude.ToString(), currS.AB.Longitude.ToString(), r.Next(5000).ToString()));
                            sw.WriteLine(GetCordString(currS.BA.Latitude.ToString(), currS.BA.Longitude.ToString(), r.Next(5000).ToString()));
                        }
                    }
                    //write the js code for fiddle test
                    sw.Write("}");
                    sw.Close();
                    sw2.Close();
                }
            }
            Console.Read();
        }

        public static string GetCordString(string lat, string lon, string count)
        {

            string corstring = String.Format(@"var marker{2} = new google.maps.Marker(|position: |lat: {0}, lng: {1} !, map: map, title: '{0}, {1}'!);", lat, lon, count);
            return corstring.Replace("|", "{").Replace("!", "}");
        }
    }
}
