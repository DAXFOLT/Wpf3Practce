using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask17Class
    {
        public MyTask17Class(double y, double x, double a, double b)
        {
            _y = y;
            _x = x;
            _a = a;
            _b = b;
        }

        public double _y { get; set; }
        public double _x { get; set; }
        public double _a { get; set; }
        public double _b { get; set; }

        public double T()
        {
            return (Math.Sqrt(_x + _b - _a) + Math.Log(_y)) / Math.Atan(_b + _a);
        }
    }
}
