using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


/* Квантование цвета - изменение диапазона градиентов с 255 до n, где n задается на форме
  Например, если n = 16, то от 0 до 16 - 0, от 16 до 32 - 16 и тд
 */

/*
 Итак – метод медианного сечения. Он прост до безобразия. Первым делом надо из всех уникальных 
 цветов изображения составить RGB куб. Далее рассечь его по самой длинной стороне. 
 Например, диапазон красного у нас от 7 до 231 (длина 231-7=224), зелёного от 32 до 170 (длина 170-32=138),
 синего от 12 до 250 (длина 250-12=238), значит, будем «резать» куб по синей стороне. Получившиеся сегменты 
 так же рассекаем по длинной стороне и т.д. пока не получим 256 сегментов. Для каждого сегмента высчитать средний цвет – 
 так мы и получим палитру.
 */

namespace ImageFilters
{
    class ColorQuantization : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int constant = 16;
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(Clamp((sourceColor.R / (256 / constant)) * (256 / constant), 0, 255),
                                               Clamp((sourceColor.G / (256 / constant)) * (256 / constant), 0, 255),
                                               Clamp((sourceColor.B / (256 / constant)) * (256 / constant), 0, 255));

            return resultColor;
        }
    }
}
