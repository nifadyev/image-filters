// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageFilters
{
    // Stretches the range of colors
    class LinearStretching : Filters
    {
        int maxR = 0, minR = 0;
        int maxG = 0, minG = 0;
        int maxB = 0, minB = 0;
        int counter = 0;

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);

            if (counter == 0)
            {
                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        Color currentColor = sourceImage.GetPixel(i, j);

                        maxR = Math.Max(maxR, currentColor.R);
                        maxG = Math.Max(maxG, currentColor.G);
                        maxB = Math.Max(maxB, currentColor.B);

                        minR = Math.Min(minR, currentColor.R);
                        minG = Math.Min(minG, currentColor.G);
                        minB = Math.Min(minB, currentColor.B);
                    }
                }
            }
            counter++;

            int resultR = Clamp(((sourceColor.R - minR) * 255 / (maxR - minR)), 0, 255);
            int resultG = Clamp(((sourceColor.G - minG) * 255 / (maxG - minG)), 0, 255);
            int resultB = Clamp(((sourceColor.B - minB) * 255 / (maxB - minB)), 0, 255);

            return Color.FromArgb(Clamp(resultR, 0, 255), Clamp(resultG, 0, 255), Clamp(resultB, 0, 255));
        }
    }
}
