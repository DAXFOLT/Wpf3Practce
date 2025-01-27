using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask2Class
    {
        public MyTask2Class(double c, double x, double t)
        {
            _c = c;
            _x = x;
            _t = t;
        }
        public double _c { get; set; }
        public double _x { get; set; }
        public double _t { get; set; }

        public double L()
        {
            return Math.Pow(1 / Math.Tan(_c), 2) + (2 * Math.Pow(_x, 2) + 5) / Math.Sqrt(_c + _t);
        }
    }
}
