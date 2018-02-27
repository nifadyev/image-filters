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
    //commit: change converting gray scale
    class SobolFilter : MatrixFilter
    {
        private float[,] kernelY = { {-1, -2, -1 },
                                     { 0, 0, 0   },
                                     { 1, 2, 1}  };

        private float[,] kernelX = { {-1, -2, 1 },
                                     { -2, 0, 2 },
                                     { -1, 2, 1}};

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

            for (int l = -radiusYkernelX; l <= radiusYkernelX; l++)
            {
                for (int k = -radiusXkernelX; k <= radiusXkernelX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    resultRkernelX += neighborColor.R * kernelX[k + radiusXkernelX, l + radiusYkernelX];
                    resultGkernelX += neighborColor.G * kernelX[k + radiusXkernelX, l + radiusYkernelX];
                    resultBkernelX += neighborColor.B * kernelX[k + radiusXkernelX, l + radiusYkernelX];

                    resultRkernelY += neighborColor.R * kernelY[k + radiusXkernelY, l + radiusYkernelY];
                    resultGkernelY += neighborColor.G * kernelY[k + radiusXkernelY, l + radiusYkernelY];
                    resultBkernelY += neighborColor.B * kernelY[k + radiusXkernelY, l + radiusYkernelY];
                }
            }

            float resultR = (float)Math.Sqrt(resultRkernelX * resultRkernelX + resultRkernelY * resultRkernelY);
            float resultG = (float)Math.Sqrt(resultGkernelX * resultGkernelX + resultGkernelY * resultGkernelY);
            float resultB = (float)Math.Sqrt(resultBkernelX * resultBkernelX + resultBkernelY * resultBkernelY);
            int intensity = (int)(resultR + resultG + resultB) / 3;

            return Color.FromArgb(Clamp((int)intensity, 0, 255), Clamp((int)intensity, 0, 255), Clamp((int)intensity, 0, 255));
        }
    }
}
