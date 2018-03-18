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
    //Reduces noise level(effective on "pepper-salt" noise)
    class MedianFilter : Filters
    {
        int size = 3;
        public MedianFilter() {}

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int matrixSize = size * size;
            Color[] colors = new Color[matrixSize];
            int[] R = new int[matrixSize];
            int[] G = new int[matrixSize];
            int[] B = new int[matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                colors[i] = sourceImage.GetPixel(Clamp(x - 1 + i / size, 0, sourceImage.Width - 1), Clamp(y - 1 + i % size, 0, sourceImage.Height - 1));
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
