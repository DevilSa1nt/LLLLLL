using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLLLLL
{
    public static class un
    {
        public static List<string> GetDet()
        {
            List<string> det = new();
            det.Add("Капот".ToLower());
            det.Add("Передняя дверь".ToLower());
            det.Add("Задняя дверь".ToLower());
            det.Add("Передний бампер".ToLower());
            det.Add("Задний бампер".ToLower());
            det.Add("Крыша".ToLower());

            return det;
        }

        public static List<string> GetColors()
        {
            List<string> colors = new();
            colors.Add("Белый".ToLower());
            colors.Add("Синий".ToLower());
            colors.Add("Желтый".ToLower());
            colors.Add("Красный".ToLower());
            colors.Add("Перламутровый".ToLower());
            colors.Add("Серый металлик".ToLower());

            return colors;
        }

        public static List<double> GetDetPrice()
        {
            List<double> det_c = new();
            det_c.Add(1);
            det_c.Add(1.2);
            det_c.Add(1.1);
            det_c.Add(1);
            det_c.Add(1);
            det_c.Add(1.1);

            return det_c;
        }

        public static List<double> GetColorsPrice()
        {
            List<double> colors_c = new();
            colors_c.Add(1);
            colors_c.Add(1);
            colors_c.Add(1.1);
            colors_c.Add(1);
            colors_c.Add(1.2);
            colors_c.Add(1.3);

            return colors_c;
        }
    }
}
