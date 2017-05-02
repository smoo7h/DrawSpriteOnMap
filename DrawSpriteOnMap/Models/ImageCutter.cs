using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DrawSpriteOnMap.Models
{
    public class ImageCutter
    {
        public Image FullImage { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int SquareWidth { get; set; }
        public int SquareHeight { get; set; }
        public IList<Image> CutImages { get; set; }



        public ImageCutter(string fileLocation, int height, int width)
        {
            FullImage = Image.FromFile(fileLocation);
            CutImages = new List<Image>();
            Width = width;
            Height = height;
            SquareWidth = FullImage.Width / Width;
            SquareHeight = FullImage.Height / Height;
            CutImages = CutImage();
            WriteImagesToFolder();
            

        }

        public void WriteImagesToFolder()
        {

            if (Directory.Exists("images"))
            {
                Directory.Delete("images", true);

            }

            Directory.CreateDirectory("images");
            Thread.Sleep(1000);
            for (int i = 0; i < CutImages.Count; i++)
            {
                string imagename = String.Format(@"images/{0}.png", (i).ToString());
                CutImages[i].Save(imagename, ImageFormat.Png);
            }
            Console.WriteLine("done");


        }

        private IList<Image> CutImage()
        {
            IList<Image> imgarray = new List<Image>();
            Image img = FullImage;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    var index = i * Width + j;
                    Bitmap newimg = new Bitmap(SquareWidth, SquareHeight);
                    imgarray.Add(newimg);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, SquareWidth, SquareHeight), new Rectangle(j * SquareHeight, i * SquareWidth, SquareWidth, SquareHeight), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            
            return imgarray;

        }



    }
}
