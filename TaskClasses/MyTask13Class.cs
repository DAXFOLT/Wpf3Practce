using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask13Class
    {
        public MyTask13Class( double a, double x, double b)
        {
           
            _a = a;
            _x = x;
            _b = b;
        }

        public double _a { get; set; }
        public double _x { get; set; }
        public double _b { get; set; }


        public double R()
        {
            return _a / (_x - _a) + (Math.Pow(_b, _x) + Math.Pow(Math.Cos(_x), 3)) / (Math.Pow(Math.Log(_a), 3) + 4.5);
        }
    }
}
