using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask15Class
    {
        public MyTask15Class(double y, double m)
        {
            _y = y;
            _m = m;
        }

        public double _y { get; set; }
        public double _m { get; set; }

        public double N()
        {
            return (Math.Pow(_m, 2) + 2.8 * _m + 0.355) / (Math.Cos(2 * _y) + 3.6);
        }
    }
}
