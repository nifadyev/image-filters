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
    class MaximumFilter : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color tmp = sourceImage.GetPixel(x, y);
            int R = tmp.R, G = tmp.G, B = tmp.B;
            int max = R;

            if (G > max) max = G;
            if (B > max) max = B;
            if (R != max) R = 0;
            if (B != max) B = 0;
            if (G != max) G = 0;

            return Color.FromArgb(R, G, B);
        }
    }
}
