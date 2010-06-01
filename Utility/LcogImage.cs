using System;
using System.Drawing;

namespace LcogClient.Utility
{
    public class LcogImage
    {
        public static Image Resize(Image image, int width, int height)
        {
            Bitmap newImage = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.DrawImage(image, 0, 0, width, height);
            }

            return newImage;
        }
    }
}
