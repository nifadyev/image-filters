// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    class GaussianFilter : MatrixFilter
    {
        public void CreateGaussianKernel(int radius, float sigma)
        {
            int size = 2 * radius + 1; // Размер ядра

            kernel = new float[size, size];

            float norm = 0; // Коэффициент нормировки ядра

            // Расчет ядра линейного фильтра
            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j < radius; j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            }

            // Нормирование ядра
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] /= norm;
                }
            }
        }

        public GaussianFilter()
        {
            CreateGaussianKernel(3, 2);
        }
    }
}
