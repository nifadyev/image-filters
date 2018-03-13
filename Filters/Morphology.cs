using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace ImageFilters
{
    abstract class Morphology : Filters
    {
        protected bool[,] mask;
        protected int maskWidth, maskHeight;

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int resultR = 0;
            int resultG = 0;
            int resultB = 0;

            for (int i = -maskWidth / 2; i <= maskWidth / 2; ++i)
            {
                for (int j = -maskHeight / 2; j <= maskHeight / 2; ++j)
                {
                    int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    if ((mask[i + maskWidth / 2, j + maskHeight / 2]) && (neighborColor.R > resultR))
                        resultR = neighborColor.R;
                    if ((mask[i + maskWidth / 2, j + maskHeight / 2]) && (neighborColor.G > resultG))
                        resultG = neighborColor.G;
                    if ((mask[i + maskWidth / 2, j + maskHeight / 2]) && (neighborColor.B > resultB))
                        resultB = neighborColor.B;
                }
            }
            return Color.FromArgb(resultR, resultG, resultB);
        }

        protected Color CalculateNewPixelColorMin(Bitmap sourceImage, int x, int y)
        {
            int resultR = 255;
            int resultG = 255;
            int resultB = 255;

            for (int i = -maskWidth / 2; i <= maskWidth / 2; ++i)
            {
                for (int j = -maskHeight / 2; j <= maskHeight / 2; ++j)
                {
                    int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    if ((mask[i + maskWidth / 2, j + maskHeight / 2]) && (neighborColor.R < resultR))
                        resultR = neighborColor.R;
                    if ((mask[i + maskWidth / 2, j + maskHeight / 2]) && (neighborColor.G < resultG))
                        resultG = neighborColor.G;
                    if ((mask[i + maskWidth / 2, j + maskHeight / 2]) && (neighborColor.B < resultB))
                        resultB = neighborColor.B;
                }
            }

            return Color.FromArgb(resultR, resultG, resultB);
        }
    }


    class Dilation : Morphology
    {
        public Dilation(bool[,] mask)
        {
            this.mask = mask;
            maskWidth = mask.GetLength(0);
            maskHeight = mask.GetLength(1);
        }

        new public Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                {
                    return null;
                }

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, CalculateNewPixelColor(sourceImage, i, j));
                }
            }

            return resultImage;
        }
    }

    class Erosion : Morphology
    {
        public Erosion(bool[,] mask)
        {
            this.mask = mask;
            maskWidth = mask.GetLength(0);
            maskHeight = mask.GetLength(1);
        }

        new public Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                {
                    return null;
                }

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, CalculateNewPixelColorMin(sourceImage, i, j));
                }
            }

            return resultImage;
        }
    }

    class Opening : Morphology
    {
        public Opening(bool[,] mask)
        {
            this.mask = mask;
            maskWidth = mask.GetLength(0);
            maskHeight = mask.GetLength(1);
        }

        new public Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap middleImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; ++i)
            {
                worker.ReportProgress((int)((float)i / 2 / middleImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; ++j)
                    middleImage.SetPixel(i, j, CalculateNewPixelColor(sourceImage, i, j));
            }

            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                {
                    return null;
                }

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, CalculateNewPixelColorMin(sourceImage, i, j));
                }
            }

            return resultImage;
        }
    }

    class Closing : Morphology
    {
        public Closing(bool[,] mask)
        {
            this.mask = mask;
            maskWidth = mask.GetLength(0);
            maskHeight = mask.GetLength(1);
        }

        new public Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap middleImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; ++i)
            {
                worker.ReportProgress((int)((float)i / 2 / middleImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; ++j)
                    middleImage.SetPixel(i, j, CalculateNewPixelColorMin(sourceImage, i, j));
            }

            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                {
                    return null;
                }

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, CalculateNewPixelColor(sourceImage, i, j));
                }
            }

            return resultImage;
        }
    }
}


