using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask19Class
    {
        public MyTask19Class(double k, double a, double r, double x, double b,double y)
        {
            _k = k;
            _a = a;
            _r = r;
            _x = x;
            _b = b;
            _y = y;
        }

        public double _k { get; set; }
        public double _a { get; set; }
        public double _r { get; set; }
        public double _x { get; set; }
        public double _b { get; set; }
        public double _y { get; set; }

        public double D()
        {
            return (Math.Pow(_k, -_a * _r * _x) - _a * Math.Sqrt(6) - Math.Cos(3 * _a * _b)) / Math.Pow(Math.Sin(_a * Math.Asin(_x) + Math.Log(_y)), 2);
        }
    }
}
