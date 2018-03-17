using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageFilters
{
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
