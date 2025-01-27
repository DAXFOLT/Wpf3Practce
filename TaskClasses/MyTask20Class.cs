using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask20Class
    {
        public MyTask20Class(double y, double x, double b, double a, double c)
        {
            _y = y;
            _x = x;
            _b = b;
            _a = a;
            _c = c;
        }

        public double _y { get; set; }
        public double _x { get; set; }
        public double _b { get; set; }
        public double _a { get; set; }
        public double _c { get; set; }

        public double U()
        {
            return (Math.Pow(Math.Tan(_y), 3) + Math.Pow(Math.Sin(_x), 5) * Math.Sqrt(_b - _c)) / Math.Sqrt(_a - _b + _c);
        }
    }
}
