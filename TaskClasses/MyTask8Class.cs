using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask8Class
    {
        public MyTask8Class(double y, double x, double a, double c)
        {
            _y = y;
            _a = a;
            _x = x;
            _c = c;
        }

        public double _y { get; set; }
        public double _a { get; set; }
        public double _x { get; set; }
        public double _c { get; set; }

        public double P()
        {
            return (Math.Pow(_a, 5) + Math.Pow(Math.Sin(_y - _c), 4)) / (Math.Pow(Math.Sin(_x + _y), 3) + Math.Abs(_x - _y));
        }
    }
}
