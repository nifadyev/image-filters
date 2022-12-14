// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    // Increases sharpness of image
    class HighSharpnessFilter : MatrixFilter
    {
        public HighSharpnessFilter()
        {
            const int sizeX = 3, sizeY = 3;
            kernel = new float[sizeX, sizeY]{ { 0, -1, 0 },
                                              {-1,  5,-1 },
                                              { 0, -1, 0 }};
        }
    }
}
