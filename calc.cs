using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLLLLL
{
    public class calc
    {
        List<string> det;
        List<string> colors;

        List<double> det_c;
        List<double> colors_c;

        double bas = 12000;

        public calc()
        {
            init();
        }

        void init()
        {
            det = new();
            det_c = new();

            det.Add("Капот".ToLower());
            det.Add("Передняя дверь".ToLower());
            det.Add("Задняя дверь".ToLower());
            det.Add("Передний бампер".ToLower());
            det.Add("Задний бампер".ToLower());
            det.Add("Крыша".ToLower());

            det_c.Add(1);
            det_c.Add(1.2);
            det_c.Add(1.1);
            det_c.Add(1);
            det_c.Add(1);
            det_c.Add(1.1);

            colors = new();
            colors_c = new();

            colors.Add("Белый".ToLower());
            colors.Add("Синий".ToLower());
            colors.Add("Желтый".ToLower());
            colors.Add("Красный".ToLower());
            colors.Add("Перламутровый".ToLower());
            colors.Add("Серый металлик".ToLower());


            colors_c.Add(1);
            colors_c.Add(1);
            colors_c.Add(1.1);
            colors_c.Add(1);
            colors_c.Add(1.2);
            colors_c.Add(1.3);
        }

        public double Calc(List<Tuple<string, string>> det_and_color)
        {
            double sum = 0;

            foreach (var c in det_and_color)
            {
                string det = c.Item1;
                string col = c.Item2;

                double koef = det_c[det.IndexOf(det)] + colors_c[colors.IndexOf(col)];

                sum += bas * koef;
            }

            return sum;
        }
    }
}
