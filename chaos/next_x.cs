using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaos
{
    class next_x
    {
        public static double next(int flag, double coef, double x)
        {
            if (flag == 1)
            {

                {
                    if (x <= 0.5) return coef * x;

                    else return -coef * x + coef;
                };
            }

            if (flag == 2)
            {
                { return coef * x * (1 - x); };

            }

            if (flag == 3)
            {
                { return coef * Math.Sin(Math.PI * x); };
            }

            if (flag == 4)
            {
                { return Math.Asin(x) / Math.PI; }
            }
            return 0;
        }
    }
}
