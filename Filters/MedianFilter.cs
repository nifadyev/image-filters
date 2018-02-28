using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageFilters
{
    class MedianFilter : Filters
    {
        public MedianFilter()
        {
            //kernel = new float[,];
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color[] colors = new Color[9];
            int[] R = new int[9];
            int[] G = new int[9];
            int[] B = new int[9];

            colors[0] = sourceImage.GetPixel(Clamp(x - 1, 0, sourceImage.Width - 1), Clamp(y - 1, 0, sourceImage.Height - 1));
            colors[1] = sourceImage.GetPixel(Clamp(x - 1, 0, sourceImage.Width - 1), y);
            colors[2] = sourceImage.GetPixel(Clamp(x - 1, 0, sourceImage.Width - 1), Clamp(y + 1, 0, sourceImage.Height - 1));
            colors[3] = sourceImage.GetPixel(x, Clamp(y - 1, 0, sourceImage.Height - 1));
            colors[4] = sourceImage.GetPixel(x, y);
            colors[5] = sourceImage.GetPixel(x, Clamp(y + 1, 0, sourceImage.Height - 1));
            colors[6] = sourceImage.GetPixel(Clamp(x + 1, 0, sourceImage.Width - 1), Clamp(y - 1, 0, sourceImage.Height - 1));
            colors[7] = sourceImage.GetPixel(Clamp(x + 1, 0, sourceImage.Width - 1), y);
            colors[8] = sourceImage.GetPixel(Clamp(x + 1, 0, sourceImage.Width - 1), Clamp(y + 1, 0, sourceImage.Height - 1));

            for (int i = 0; i < 9; i++)
            {
                R[i] = colors[i].R;
                G[i] = colors[i].G;
                B[i] = colors[i].B;
            }

            Array.Sort(R);
            Array.Sort(G);
            Array.Sort(B);

            return Color.FromArgb(R[4], G[4], B[4]);
        }
    }
}
