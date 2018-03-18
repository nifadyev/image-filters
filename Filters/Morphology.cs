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
    // Basic class for all morphologies filters
    class Morphology : Filters
    {
        public int maxSize;
        public int morphologyType;
        public Bitmap resultImage;
        public bool[,] structureElement = null;

        public Morphology(Bitmap image, int size, int typeOfMorphology)
        {
            maxSize = size;
            morphologyType = typeOfMorphology;
            resultImage = image;
        }

        public void SetStructureElement(bool[,] input)
        {
            structureElement = input;
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            switch(morphologyType)
            {
                case 1:
                    return Dilation(resultImage, x, y);
                case 2:
                    return Erosion(resultImage, x, y);
                default:
                    return Color.Black;
            }
        }

        // Reduces black noise(with loss of object areas)
        protected Color Dilation(Bitmap sourceImage, int x, int y)
        {
            int maxR = 0;
            int maxG = 0;
            int maxB = 0;
            int radius = maxSize / 2;

            for (int i = -radius; i <= radius; ++i)
            {
                for (int j = -radius; j <= radius; ++j)
                {
                    int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourceImage.Height - 1);
                    Color currentColor = sourceImage.GetPixel(idX, idY);

                    if (structureElement == null || structureElement[i + radius, j + radius])
                    {
                        if (currentColor.R > maxR)
                        {
                            maxR = currentColor.R;
                        }
                        if (currentColor.G > maxG)
                        {
                            maxG = currentColor.G;
                        }
                        if (currentColor.B > maxB)
                        {
                            maxB = currentColor.B;
                        }
                    }
                }
            }

            return Color.FromArgb(maxR, maxG, maxB);
        }

        // Reduces white noise(with loss of object areas)
        protected Color Erosion(Bitmap sourceImage, int x, int y)
        {
            int minR = 255;
            int minG = 255;
            int minB = 255;
            int radius = maxSize / 2;

            for (int i = -radius; i <= radius; ++i)
            {
                for (int j = -radius; j <= radius; ++j)
                {
                    int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourceImage.Height - 1);
                    Color currentColor = sourceImage.GetPixel(idX, idY);

                    if (structureElement == null || structureElement[i + radius, j + radius])
                    {
                        if (currentColor.R < minR)
                        {
                            minR = currentColor.R;
                        }
                        if (currentColor.G < minG)
                        {
                            minG = currentColor.G;
                        }
                        if (currentColor.B < minB)
                        {
                            minB = currentColor.B;
                        }
                    }
                }
            }

            return Color.FromArgb(minR, minG, minB);
        }
    }

    // Reduces white noise(if objects without noise)
    class Opening : Morphology
    {
        public Opening(Bitmap sourceImage, int size, int typeOfMorphology) : base(sourceImage, size, typeOfMorphology)
        {
            maxSize = size;

            resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, Erosion(sourceImage, i, j));
                }
            }
        }
    }

    // Reduces black noise(if image background doesn't have noise)
    class Closing : Morphology
    {
        public Closing(Bitmap sourceImage, int size, int typeOfMorphology) : base(sourceImage, size, typeOfMorphology)
        {
            maxSize = size;

            resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, Dilation(sourceImage, i, j));
                }
            }
        }
    }
}


