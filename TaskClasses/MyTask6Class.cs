using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask6Class
    {
        public MyTask6Class(double y, double b, double a, double x)
        {
            _y = y;
            _b = b;
            _a = a;
            _x = x;
        }

        public double _x { get; set; }
        public double _b { get; set; }
        public double _a { get; set; }
        public double _y { get; set; }

        public double K()
        {
            return (Math.Sqrt(_x + _b - _a) + Math.Log(_y)) / Math.Atan(_b + _a);
        }
    }
}
