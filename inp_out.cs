using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLLLLL
{
    public class inp_out
    {
        List<Tuple<string, string>> det_and_color;

        List<string> det;
        List<string> colors;

        public inp_out()
        {
            det_and_color = new();

            init();
        }

        void init()
        {
            det = un.GetDet();

            colors = un.GetColors();
        }

        public List<Tuple<string, string>> input_d()
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (s == "")
                {
                    break;
                }
                else
                {
                    string[] ss = s.Split(", ");

                    if (det.Contains(ss[0].ToLower()))
                    {
                        if (colors.Contains(ss[1].ToLower()))
                        {
                            Tuple<string, string> t = new(ss[0], ss[1]);

                            det_and_color.Add(t);
                        }
                        else
                        {
                            Console.WriteLine("Цвет введён некорректно");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Название детали введено некорректно");
                    }
                }
            }

            return det_and_color;
        }
    }
}
