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
    // Closing and erosion
    class TopHatFilter : Closing
    {
        public TopHatFilter(Bitmap image, int size, int morphologyType) : base(image, size, morphologyType)
        {
            maxSize = size;
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color currentColor = sourceImage.GetPixel(x, y);
            Color openingColor = resultImage.GetPixel(x, y);

            return Color.FromArgb(Clamp(openingColor.R - currentColor.R, 0, 255),
                                  Clamp(openingColor.G - currentColor.G, 0, 255),
                                  Clamp(openingColor.B - currentColor.B, 0, 255));
        }
    }
}
