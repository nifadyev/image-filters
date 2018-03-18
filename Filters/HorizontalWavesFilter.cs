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
    // Makes image waivy
    class HorizontalWavesFilter : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int idx = Clamp((int)(x + 20 * Math.Sin((2 * Math.PI * y) / 60)), 0, sourceImage.Width - 1);
            int idy = Clamp(y, 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(idx, idy);
        }
    }
}
