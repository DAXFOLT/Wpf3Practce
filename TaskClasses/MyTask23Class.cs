using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask23Class
    {
        public MyTask23Class(double x, double b, double z, double a)
        {
            _x = x;
            _b = b;
            _z = z;
            _a = a;
        }

        public double _x { get; set; }
        public double _b { get; set; }
        public double _z { get; set; }
        public double _a { get; set; }

        public double F()
        {
            return Math.Sqrt(Math.Abs(_x) + Math.Pow(Math.Cos(_x), 3) + Math.Pow(_z, 4)) / (Math.Log(_x) - Math.Asin(_b * _x - _a));
        }
    }
}
