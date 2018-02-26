using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    class SobolFilter : MatrixFilter
    {
        private float[,] kernelY = { {-1, -2, -1 },
                                       { 0, 0, 0   },
                                       { 1, 2, 1}  };

        private float[,] kernelX = { {-1, -2, 1 },
                                       { -2, 0, 2 },
                                       { -1, 2, 1}};

        public SobolFilter()
        {
            //kernel = new float[3,3] { { -1, -2, 1 }, { -2, 0, 2 }, { -1, 2, 1 } };
            //kernel = { { -1, -2, 1 },{ -2, 0, 2 },{ -1, 2, 1}};
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusXkernelX = kernelX.GetLength(0) / 2;
            int radiusYkernelX = kernelX.GetLength(1) / 2;
            int radiusXkernelY = kernelY.GetLength(0) / 2;
            int radiusYkernelY = kernelY.GetLength(1) / 2;

            float resultRkernelX = 0;
            float resultGkernelX = 0;
            float resultBkernelX = 0;

            float resultRkernelY = 0;
            float resultGkernelY = 0;
            float resultBkernelY = 0;

            int intensity;

            for (int l = -radiusYkernelX; l <= radiusYkernelX; l++)
            {
                for (int k = -radiusXkernelX; k <= radiusXkernelX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    // Применение GrayScale для NeighborColor
                    intensity = (int)(0.36 * neighborColor.R + 0.53 * neighborColor.G + 0.11 * neighborColor.B);
                    neighborColor = Color.FromArgb(intensity, intensity, intensity);


                    resultRkernelX += neighborColor.R * kernelX[k + radiusXkernelX, l + radiusYkernelX];
                    resultGkernelX += neighborColor.G * kernelX[k + radiusXkernelX, l + radiusYkernelX];
                    resultBkernelX += neighborColor.B * kernelX[k + radiusXkernelX, l + radiusYkernelX];

                    resultRkernelY += neighborColor.R * kernelY[k + radiusXkernelY, l + radiusYkernelY];
                    resultGkernelY += neighborColor.G * kernelY[k + radiusXkernelY, l + radiusYkernelY];
                    resultBkernelY += neighborColor.B * kernelY[k + radiusXkernelY, l + radiusYkernelY];
                }
            }

            return Color.FromArgb(Clamp((int)Math.Sqrt(resultRkernelX * resultRkernelX + resultRkernelY * resultRkernelY), 0, 255),
                      Clamp((int)Math.Sqrt(resultGkernelX * resultGkernelX + resultGkernelY * resultGkernelY), 0, 255),
                      Clamp((int)Math.Sqrt(resultBkernelX * resultBkernelX + resultBkernelY * resultBkernelY), 0, 255));
        }
    }
}
