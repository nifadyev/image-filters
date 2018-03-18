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
    //Find blicks and dicrease them
    class IdealReflector : Filters
    {
        int maxR = 0;
        int maxG = 0;
        int maxB = 0;

        public IdealReflector(Bitmap sourceImage)
        {
            for (int i = 0; i < sourceImage.Width - 1; i++)
            {
                for (int j = 0; j < sourceImage.Height - 1; j++)
                {
                    Color currentColor = sourceImage.GetPixel(i, j);

                    if (currentColor.R > maxR)
                    {
                        maxR = currentColor.R;
                    }
                    if (currentColor.G > maxG)
                    {
                        maxG = currentColor.G;
                    }
                    if (currentColor.B > maxB)
                    {
                        maxB = currentColor.B;
                    }
                }
            }
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color currentColor = sourceImage.GetPixel(x, y);
            int resultR = currentColor.R * 255 / maxR;
            int resultG = currentColor.G * 255 / maxG;
            int resultB = currentColor.B * 255 / maxB;

            return Color.FromArgb(Clamp(resultR, 0, 255), Clamp(resultG, 0, 255), Clamp(resultB, 0, 255));
        }
    }
}
