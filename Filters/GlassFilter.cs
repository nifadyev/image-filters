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
    //Creates "glass" between image and screen
    class GlassFilter : Filters
    {
        Random r = new Random();

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int idx = Clamp(x + (int)((r.NextDouble() - 0.5) * 10), 0, sourceImage.Width - 1);
            int idy = Clamp(y + (int)((r.NextDouble() - 0.5) * 10), 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(idx, idy);
        }
    }
}
