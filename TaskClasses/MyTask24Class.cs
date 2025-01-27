using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask24Class
    {
        public MyTask24Class(double a, double b, double x, double z)
        {
            _a = a;
            _b = b;
            _x = x;
            _z = z;
        }

        public double _a { get; set; }
        public double _b { get; set; }
        public double _x { get; set; }
        public double _z { get; set; }

        public double F()
        {
            return (Math.Pow(Math.Cos(_b * Math.Pow(_x, 5)), 7) - (Math.Sin(Math.Pow(_a, 2)) + Math.Cos(Math.Pow(_x, 3) + Math.Pow(_z, 5) - Math.Pow(_a, 2)))) / (Math.Asin(Math.Pow(_a, 2)) + Math.Acos(Math.Pow(_x, 7) - Math.Pow(_a, 2)));
        }
    }
}
