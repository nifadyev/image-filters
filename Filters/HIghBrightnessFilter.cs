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
    // Increases brightness of all image, depends on constant
    class HIghBrightnessFilter : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int constant = 25;
            Color resultColor = Color.FromArgb(Clamp(sourceColor.R + constant, 0, 255), 
                                               Clamp(sourceColor.G + constant, 0, 255),
                                               Clamp(sourceColor.B + constant, 0, 255));

            return resultColor;
        }
    }
}
