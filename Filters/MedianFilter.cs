using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageFilters
{
    class MedianFilter : MatrixFilter
    {
        public MedianFilter()
        {
            //kernel = new float[,];
        }

        //protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        //{
        //    //inputPixelValue[x + fx - edgex][y + fy - edgey]

        //    //int radiusX = kernel.GetLength(0) / 2;
        //    //int radiusY = kernel.GetLength(1) / 2;

        //    int width = sourceImage.Width / 2;
        //    int height = sourceImage.Height / 2;


        //    //float resultR = 0;
        //    //float resultG = 0;
        //    //float resultB = 0;

        //    //for (int l = -radiusY; l <= radiusY; l++)
        //    //{
        //    //    for (int k = -radiusX; k <= radiusX; k++)
        //    //    {
        //    //        int idX = Clamp(x + k, 0, sourceImage.Width - 1);
        //    //        int idY = Clamp(y + l, 0, sourceImage.Height - 1);
        //    //        Color neighborColor = sourceImage.GetPixel(idX, idY);

        //    //        resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
        //    //        resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
        //    //        resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
        //    //    }
        //    //}

        //    //return Color.FromArgb(Clamp((int)resultR, 0, 255),
        //    //                      Clamp((int)resultG, 0, 255),
        //    //                      Clamp((int)resultB, 0, 255));

        //    for (int l = 1; l < width - 1; l++)
        //    {
        //        for (int k = 1; k < height - 1; k++)
        //        {
        //            Color[] window = new Color[9];
        //            int[] windowR = new int[9];
        //            int[] windowG = new int[9];
        //            int[] windowB = new int[9];
        //            int count = 0;
        //            for (int i = l - 1; i < l + 2; i++)
        //            {
        //                for (int j = k - 1; j < k + 2; j++)
        //                {
        //                    window[count] = sourceImage.GetPixel(i, j);
        //                    windowR[count] = window[count].R;
        //                    windowG[count] = window[count].G;
        //                    windowB[count] = window[count].B;
        //                    count++;
        //                }
        //            }
        //            Array.Sort(windowR);
        //            Array.Sort(windowG);
        //            Array.Sort(windowB);
        //            int r = windowR[9 / 2];
        //            int g = windowG[9 / 2];
        //            int b = windowB[9 / 2];
        //            Color color = Color.FromArgb(r, g, b);


        //        }

        //        return color;/*Color.FromArgb(Clamp((int)resultR, 0, 255),
        //                              Clamp((int)resultG, 0, 255),
        //                              Clamp((int)resultB, 0, 255));*/


        //    }
    }
}
