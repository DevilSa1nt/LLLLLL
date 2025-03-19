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
            det = un.GetDet();
            det_c = un.GetDetPrice();

            colors = un.GetColors();
            colors_c = un.GetColorsPrice();
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
