// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    // Makes the main color of the image equal lite brown
    class SepiaFilter : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)(0.36 * sourceColor.R + 0.53 * sourceColor.G + 0.11 * sourceColor.B);
            int constant = 15;
            Color resultColor = Color.FromArgb(Clamp(intensity + 2 * constant, 0, 255), 
                                               Clamp(intensity + (int)(0.5 * constant), 0, 255), 
                                               Clamp(intensity - constant, 0, 255));

            return resultColor;
        }
    }
}
