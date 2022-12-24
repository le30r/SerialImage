using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialImage
{
    internal class Binarisator
    {
        public Bitmap Binarise(Bitmap src, int threshold)
        {
          

            // Resize the image
            if (src.Height > src.Width)
            {
                src.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            Bitmap resizedImage = new Bitmap(src, new Size(128, 64));

            // Convert the image to grayscale
            Bitmap grayscaleImage = new Bitmap(resizedImage.Width, resizedImage.Height);
            for (int x = 0; x < resizedImage.Width; x++)
            {
                for (int y = 0; y < resizedImage.Height; y++)
                {
                    Color pixelColor = resizedImage.GetPixel(x, y);
                    int grayScale = (int)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11));
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    grayscaleImage.SetPixel(x, y, newColor);
                }
            }

            // Binarize the image
            Bitmap binarizedImage = new Bitmap(grayscaleImage.Width, grayscaleImage.Height);
            for (int x = 0; x < grayscaleImage.Width; x++)
            {
                for (int y = 0; y < grayscaleImage.Height; y++)
                {
                    Color pixelColor = grayscaleImage.GetPixel(x, y);
                    
                    Color newColor = pixelColor.R < threshold ? Color.Black : Color.White;
                    binarizedImage.SetPixel(x, y, newColor);
                }
            }

            return binarizedImage;
        }
    }
}
